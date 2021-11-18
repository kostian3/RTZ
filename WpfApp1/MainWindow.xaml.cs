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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Why (object sender, RoutedEventArgs e) 
        {

            string s = Whot.Text;
            int length = s.Length;
            char end = s[length - 1];
            string[] ar = { ".", "!", "?", "-", "  ", "*", "%" };
            for (int i = 0; i < ar.Length; i++)
            {
                s = s.Replace(ar[i], "");
            }
            for (int i = 0; i < ar.Length; i++)
            {
                s = s.Replace(",,", ",");
            }
            for (int i = 0; i < ar.Length; i++)
            {
                s = s.Replace(",,", "");
            }
            for (int i = 0; i < ar.Length; i++)
            {
                s = s.Replace(" , ", " ");
            
            }
            bool a  = false;
            char[] f = { '.', '!', '?'};
            for (int i = 0; i < f.Length; i++)
            { 
            if (end == f[i])
                {
                    a = true;

                }

            }
            if (a == true)
            {
                MessageBox.Show($"{s}{end}");
            }
            else { MessageBox.Show($"{s}"); }
            


        }
    }
 
}
