using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ForwardDifferenceTable
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Calc_Click(object sender, EventArgs e)
        {
            string user_Input = txt_Input.Text;
            user_Input = user_Input.Replace(" ", "");

            string[] user_Sequnce = user_Input.Split(new Char[] { ',', ' ' });
            int len = user_Sequnce.Count();

            float[] converted_Sequence = new float[len];

            for (int i = 0; i < len; i++)
            {
                float x = float.Parse(user_Sequnce[i]);
                converted_Sequence[i] = x;
            }

            IEnumerable<float> real_Sequence = converted_Sequence;

            do
            {
                txt_Output.Text += string.Join(", ", real_Sequence) + "\n";
            }
            while ((real_Sequence = ForwardDifference(real_Sequence)).Any());
        }

        private void Btn_One_Click(object sender, EventArgs e)
        {
            txt_Input.Text += "1";
        }

        private void Btn_Two_Click(object sender, EventArgs e)
        {
            txt_Input.Text += "2";
        }

        private void Btn_Three_Click(object sender, EventArgs e)
        {
            txt_Input.Text += "3";
        }

        private void Btn_Four_Click(object sender, EventArgs e)
        {
            txt_Input.Text += "4";
        }

        private void Btn_Five_Click(object sender, EventArgs e)
        {
            txt_Input.Text += "5";
        }

        private void Btn_Six_Click(object sender, EventArgs e)
        {
            txt_Input.Text += "6";
        }

        private void Btn_Seven_Click(object sender, EventArgs e)
        {
            txt_Input.Text += "7";
        }

        private void Btn_Eight_Click(object sender, EventArgs e)
        {
            txt_Input.Text += "8";
        }

        private void Btn_Nine_Click(object sender, EventArgs e)
        {
            txt_Input.Text += "9";
        }

        private void Btn_Zero_Click(object sender, EventArgs e)
        {
            txt_Input.Text += "0";
        }

        private void Btn_Decimal_Click(object sender, EventArgs e)
        {
            txt_Input.Text += ".";
        }

        private void Btn_Comma_Click(object sender, EventArgs e)
        {
            txt_Input.Text += ",";
        }

        static IEnumerable<float> ForwardDifference(IEnumerable<float> sequence, uint order = 1u)
        {
            switch (order)
            {
                case 0u:
                    return sequence;
                case 1u:
                    return sequence.Skip(1).Zip(sequence, (next, current) => next - current);
                default:
                    return ForwardDifference(ForwardDifference(sequence), order - 1u);
            }
        }

        private void Btn_About_Click(object sender, EventArgs e)
        {
            System.Windows.MessageBox.Show("GE_ELEC: Numericals Project \n Author: Gabriel Hansley Suarez \n Collaborator: Antonio Lorenzo Hecali \n Date: 04/01/2019", "ABOUT", MessageBoxButton.OK);
        }

        private void Btn_Help_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();

            help.Show();
        }

        private void Btn_Ref_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://nptel.ac.in/courses/122104019/numerical-analysis/Rathish-kumar/rathish-oct31/fratnode8.html");
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
