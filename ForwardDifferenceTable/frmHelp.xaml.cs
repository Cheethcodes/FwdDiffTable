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

namespace ForwardDifferenceTable
{
    public partial class frmHelp : Window
    {
        public frmHelp()
        {
            InitializeComponent();

            lb_Formula.Text = "The forward difference table can be calculated by having a set of inputs which will act as the 0th level of the tree and grouping them into two without rearrangement then subtracting the second number from the first in the groups. The answers resulting will form the 1st level of the tree. From the current level, group to two and subtract the second number from the first number without rearrangement again to form the next level until only 1 node is left on that level. \n\nsource: https://nptel.ac.in/courses/122104019/numerical-analysis/Rathish-kumar/rathish-oct31/fratnode8.html";
            lb_Input.Text = "The program accepts input of the following format:\nx,x,x,x,x or x, x, x, x, x\nwhere x can be a floating point number or an integer.\nPlease use the keyboard placed inside the program to prevent any issues.";
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
