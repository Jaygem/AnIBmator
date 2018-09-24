using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AnIBmator
{
    /// <summary>
    /// Interaction logic for StrokeControls.xaml
    /// </summary>
    public partial class StrokeControls : Window
    {
        
        public StrokeControls()
        {
            InitializeComponent();
        }

        private void StrokeMod_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)this.Owner).Move_Stroke_Click(sender,e);
        }
    }
}
