using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc1
{

    public partial class Form1 : Form
    {
        List<Display> Displays = new List<Display>();
        Display operators = new Display
        {
            Sum = "+",
            Sub = "-",
            Dev = "/",
            Mult = "*"
        };
        private double a;
        private double b;
        private double c;
      
        public Form1()
        {
            InitializeComponent();
            TxtDisplay.Text = "";
        }

        private void SelectedBtn(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            TxtDisplay.Text += clicked.Text;
        }
        #region Display the text
        //Display the numbers in Textbox but dont delete previcious
        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtDisplay.Text==c.ToString()) 
            {
                TxtDisplay.Text = c.ToString();

            }
            else if(string.IsNullOrEmpty(TxtDisplay.Text))
            {
                TxtDisplay.Text = button1.Text;
            }
            else
            {
                TxtDisplay.Text += button1.Text;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(TxtDisplay.Text==c.ToString()) 
            {
                TxtDisplay.Text = c.ToString();

            } 
           
            else if(string.IsNullOrEmpty(TxtDisplay.Text))
            {
                TxtDisplay.Text = button2.Text;
            }
            else
            {
                TxtDisplay.Text += button2.Text;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == c.ToString())
            {
                TxtDisplay.Text = c.ToString();

            }

            else if (string.IsNullOrEmpty(TxtDisplay.Text))
            {
                TxtDisplay.Text = button3.Text;
            }
            else
            {
                TxtDisplay.Text += button3.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == c.ToString())
            {
                TxtDisplay.Text = c.ToString();

            }

            else if (string.IsNullOrEmpty(TxtDisplay.Text))
            {
                TxtDisplay.Text = button4.Text;
            }
            else
            {
                TxtDisplay.Text += button4.Text;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == c.ToString())
            {
                TxtDisplay.Text = c.ToString();

            }

            else if (string.IsNullOrEmpty(TxtDisplay.Text))
            {
                TxtDisplay.Text = button5.Text;
            }
            else
            {
                TxtDisplay.Text += button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == c.ToString())
            {
                TxtDisplay.Text = c.ToString();

            }

            else if (string.IsNullOrEmpty(TxtDisplay.Text))
            {
                TxtDisplay.Text = button6.Text;
            }
            else
            {
                TxtDisplay.Text += button6.Text;
            }
        } 

        private void button7_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == c.ToString())
            {
                TxtDisplay.Text = c.ToString();

            }

            else if (string.IsNullOrEmpty(TxtDisplay.Text))
            {
                TxtDisplay.Text = button7.Text;
            }
            else
            {
                TxtDisplay.Text += button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == c.ToString())
            {
                TxtDisplay.Text = c.ToString();

            }

            else if (string.IsNullOrEmpty(TxtDisplay.Text))
            {
                TxtDisplay.Text = button8.Text;
            }
            else
            {
                TxtDisplay.Text += button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == c.ToString())
            {
                TxtDisplay.Text = c.ToString();

            }

            else if (string.IsNullOrEmpty(TxtDisplay.Text))
            {
                TxtDisplay.Text = button9.Text;
            }
            else
            {
                TxtDisplay.Text += button9.Text;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == c.ToString())
            {
                TxtDisplay.Text = c.ToString();

            }
            if (!TxtDisplay.Text.EndsWith("+")&&!TxtDisplay.Text.EndsWith("-")&&!TxtDisplay.Text.EndsWith("/")&&!TxtDisplay.Text.EndsWith("*") && !TxtDisplay.Text.EndsWith("="))
            {
                TxtDisplay.Text+= button0.Text;
            }
           
        }
      

        private void BtnSeparator_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == c.ToString())
            {
                TxtDisplay.Text = c.ToString();

            }
            if (!string.IsNullOrEmpty(TxtDisplay.Text) && !TxtDisplay.Text.EndsWith("+") && !TxtDisplay.Text.EndsWith("-") && !TxtDisplay.Text.EndsWith("/") && !TxtDisplay.Text.EndsWith("*") && !TxtDisplay.Text.EndsWith("="))
            {
                TxtDisplay.Text += BtnSeparator.Text;
            }
        }
        
        private void BtnPlus_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TxtDisplay.Text) && !TxtDisplay.Text.EndsWith("+") && !TxtDisplay.Text.EndsWith("-") && !TxtDisplay.Text.EndsWith("/") && !TxtDisplay.Text.EndsWith("*") && !TxtDisplay.Text.EndsWith("=") && !TxtDisplay.Text.EndsWith(","))
            {
                TxtDisplay.Text += BtnPlus.Text;
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtDisplay.Text) && !TxtDisplay.Text.EndsWith("+") && !TxtDisplay.Text.EndsWith("-") && !TxtDisplay.Text.EndsWith("/") && !TxtDisplay.Text.EndsWith("*") && !TxtDisplay.Text.EndsWith("="))
            {
                TxtDisplay.Text += BtnMinus.Text;
            }
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtDisplay.Text) && !TxtDisplay.Text.EndsWith("+") && !TxtDisplay.Text.EndsWith("-") && !TxtDisplay.Text.EndsWith("/") && !TxtDisplay.Text.EndsWith("*") && !TxtDisplay.Text.EndsWith("="))
            {
                TxtDisplay.Text += BtnMult.Text;
            }
          
        }

        private void BtnDevide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtDisplay.Text) && !TxtDisplay.Text.EndsWith("+") && !TxtDisplay.Text.EndsWith("-") && !TxtDisplay.Text.EndsWith("/") && !TxtDisplay.Text.EndsWith("*") && !TxtDisplay.Text.EndsWith("="))
            {
                TxtDisplay.Text += BtnDevide.Text;
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtDisplay.Text))
            {
                char last = TxtDisplay.Text.Last();
                int k = TxtDisplay.Text.IndexOf(last.ToString());
                MessageBox.Show(k.ToString());
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
        }


        #endregion Display the text


        #region Operations
       
        //Plus
        private void Plus()
        {
            if (!string.IsNullOrEmpty(TxtDisplay.Text)&&TxtDisplay.Text.Contains("+"))
            {
                int i = TxtDisplay.Text.IndexOf("+");
                a = Convert.ToDouble((TxtDisplay.Text.Substring(0,i)).ToString());
                
                b = Convert.ToDouble((TxtDisplay.Text.Substring(i + 1)).ToString());
                c=a + b;
            }
            
           
             
        }
        //Minus
        private void Minus()
        {
            if (!string.IsNullOrEmpty(TxtDisplay.Text) && TxtDisplay.Text.Contains("-"))
            {
                int i = TxtDisplay.Text.IndexOf("-");
                a = Convert.ToDouble((TxtDisplay.Text.Substring(0, i)).ToString());

                b = Convert.ToDouble((TxtDisplay.Text.Substring(i + 1)).ToString());

            }
            c = a-b;
        }
        ////Delete
        private void Devide()
        {
            if (!string.IsNullOrEmpty(TxtDisplay.Text) && TxtDisplay.Text.Contains("/"))
            {
                int i = TxtDisplay.Text.IndexOf("/");
                a = Convert.ToDouble((TxtDisplay.Text.Substring(0, i)).ToString());

                b = Convert.ToDouble((TxtDisplay.Text.Substring(i + 1)).ToString());

            }
            c = a/b;
        }
        ////Multiplicate
        private void Multiplicate()
        {
            if (!string.IsNullOrEmpty(TxtDisplay.Text) && TxtDisplay.Text.Contains("*"))
            {
                int i = TxtDisplay.Text.IndexOf("*");
                a = Convert.ToDouble((TxtDisplay.Text.Substring(0, i)).ToString());

                b = Convert.ToDouble((TxtDisplay.Text.Substring(i + 1)).ToString());

            }
            c = a*b;
        }
        #endregion Operations


        #region Result and Reset
        //delete process  and  show result
        private void BTnResult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDisplay.Text))
            {
                TxtDisplay.Text="";
            }
            else if(TxtDisplay.Text.Contains("+"))
            {
                Plus();
                TxtDisplay.Text = c.ToString();
            }else if (TxtDisplay.Text.Contains("-"))
            {
                Minus();
                TxtDisplay.Text = c.ToString();
            }
            else if (TxtDisplay.Text.Contains("/"))
            {
                Devide();
                TxtDisplay.Text = c.ToString();
            }
            else if (TxtDisplay.Text.Contains("*"))
            {
                Multiplicate();
                TxtDisplay.Text = c.ToString();
            }

        }

      
        #endregion Result and Reset

        //keep in memory result before reset

    }
}
