using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTestCreate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FResize(object sender, EventArgs e)
        {
            textInput.Top = 0; textOutput.Top = 0;
            textInput.Width = PAN.Width / 2; textOutput.Width = (PAN.Width / 2)+1;
            textInput.Left = 0; textOutput.Left = PAN.Width / 2;
            textInput.Height = PAN.Height; textOutput.Height = PAN.Height;

        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            textOutput.Text = null;
            int j = 0;
            for (int i = 0; i < textInput.Lines.Length; i++)
            {
                switch (j)
                {
                    case 0:
                        textOutput.Text += "<q name = \"question            " + textInput.Lines[i] + "\" > " + '\r' + '\n';
                        break;

                    case 1:
                        textOutput.Text += "<v1>variant          " + textInput.Lines[i] + "</v1 >" + '\r' + '\n';
                        break;
                    case 2:
                        textOutput.Text += "<v2>variant          " + textInput.Lines[i] + "</v2 >" + '\r' + '\n';
                        break;
                    case 3:
                        textOutput.Text += "<v3>variant          " + textInput.Lines[i] + "</v3 >" + '\r' + '\n';
                        break;
                    case 4:
                        textOutput.Text += "<v4>variant          " + textInput.Lines[i] + "</v4 >" + '\r' + '\n';
                        break;
                    case 5:
                        textOutput.Text += "<v5>variant          " + textInput.Lines[i] + "</v5 >" + '\r' + '\n';
                        break;
                    case 6:
                        textOutput.Text += "</q >" + '\r' + '\n';
                        break;
                }


                if (j == 6)
                { j = 0;
                    i--;
                }
                else
                { j++; }
            }
        }
    }
}
