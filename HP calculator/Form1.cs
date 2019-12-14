using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HP_calculator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maakt een nieuw object "calc" van het type Calculator. De form manipuleert de stack via dit object.
        /// </summary>
        public Calculator calc = new Calculator(new ArrayStack<double>());

        /// <summary>
        /// De nummerknoppen komen hier binnen. Er word gekeken welk teken er word verstuurd.
        /// Vervolgens word de bijbehorende code gerunt.
        /// </summary>
        private void InputFilter(object sender, EventArgs e)
        {
            string input = ((Button)sender).Text;
            if (input == "(-)")
            {
                if (Display.Text != "")
                {
                    Display.Text = "-" + Display.Text;
                }
                else
                {
                    Display.Text = Display.Text + "-";
                }
            }
            else
            {               
                if (input == ".")
                {
                    if (!Display.Text.Contains(","))
                        Display.Text = Display.Text + ",";
                }
                else
                {
                    if (Display.Text == "0")
                    { Display.Text = ""; }
                    Display.Text = Display.Text + input;
                }
            }
        }

        /// <summary>
        /// Hier gaan de "+", "-", "/" en "*" knoppen naartoe. Eerst word er gekeken of er wel twee items in de stack staan.
        /// Als dit zo is worden de bovenste twee items gepopt, wordt er met deze items een berekening gedaan en wordt
        /// het resultaat van die berekening gepushed.
        /// </summary>
        private void Calculate(object sender, EventArgs e)
        {
            if (calc.Count() < 2) { return; }
            else
            {
                string input = ((Button)sender).Text;
                double num1 = calc.PopStack();
                double num2 = calc.PopStack();
                if (input == "/")
                {
                    calc.PushStack(num2 / num1);
                }
                else if (input == "*")
                {
                    calc.PushStack(num2 * num1);
                }
                else if (input == "-")
                {
                    calc.PushStack(num2 - num1);
                }
                else if (input == "+")
                {
                    calc.PushStack(num2 + num1);
                }
                UpdateList();
            }
        }

        /// <summary>
        /// Als er iets op het scherm staat wordt dit op de stack gepushed. 
        /// Vervolgens word het display geleegd en de ListBox geupdate.
        /// </summary>
        private void NaarStack(object sender, EventArgs e)
        {
            if(Display.Text !="")
            {
                calc.PushStack(Convert.ToDouble(Display.Text));
                Display.Text = "";
                UpdateList();
            }
        }

        /// <summary>
        /// Haalt als het displayscherm niet leeg is één karakter uit het displayscherm.
        /// </summary>
        private void Backspace(object sender, EventArgs e)
        {
            if (Display.Text != "") Display.Text = Display.Text.Remove(Display.Text.Length - 1, 1);
        }

        /// <summary>
        /// Vangt de clicks op de radioknoppen op. Filtert op het type stack waar op geklikt is.
        /// Stuurt dat type stack op naar de ChangeStack methode uit de Calculator class en 
        /// refreshed de ListBox.
        /// </summary>
        private void RadioClicked(object sender, EventArgs e)
        {
            string RadioText = (sender as RadioButton).Text;
            
                if(RadioText=="ArrayStack")
                   {
                     calc.ChangeStack(new ArrayStack<double>());
                     UpdateList();
                   }
                else if(RadioText=="ListStack")
                   {
                     calc.ChangeStack(new ListStack<double>());
                     UpdateList();
                   }
                else if(RadioText=="MyListStack")
                   {
                      calc.ChangeStack(new MyListStack<double>());
                      UpdateList();
                   }      
        }

        /// <summary>
        /// Zet de stack om in een array en gebruikt deze als DataSource voor de ListBox.
        /// </summary>
        private void UpdateList()
        {
            listBox1.DataSource = calc.GetALLTerm();
        }

        /// <summary>
        /// Lege void waar ik knoppen die niks horen te doen naar toe stuur.
        /// </summary>
        private void TheVoid(object sender, EventArgs e)
        {

        }
    }
}
