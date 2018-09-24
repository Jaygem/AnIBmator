using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnIBmator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public InkCanvas dodo;
        public Window Controls;
        public MainWindow()
        {
            InitializeComponent();
            dodo = new InkCanvas();
            grid1.Children.Add(dodo);
            SourceInitialized += (s, a) =>
            {
                Controls = new StrokeControls();
                Controls.Owner = this;
                Controls.Show();
            };
            
            

        }

        public void Move_Stroke_Click(object sender, RoutedEventArgs e)
        {
            StrokeCollection sc = this.dodo.Strokes;
            Console.WriteLine("Point is " +sc[0].GetBezierStylusPoints()[0].X + " and " + sc[0].GetBezierStylusPoints()[0].Y);
            for (int i = 0; i < dodo.Strokes.Count; i++)
            {
                for (int j = 0; j < dodo.Strokes[i].StylusPoints.Count; j++)
                {
                    // since StylusPoint[j] is returning a reference to
                    // a struct you need to set it to a variable
                    var y = dodo.Strokes[i].StylusPoints[j].Y;

                    //Set it to x=200 and y= stroke y value
                    dodo.Strokes[i].StylusPoints[j] = new StylusPoint(200, y);
                }
           
            }
            /*Rect bounds = sc.GetBounds();
            Point p = new Point(bounds.Left, bounds.Top);
            Matrix mat = new Matrix();
            mat.Translate(-1, -1);
            sc.Transform(mat, false);*/



        }
    }
}
