using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HP_calculator
{
    public class Calculator
    {
        public Interfacestack<double> terms;

        public Calculator(IStack<double> start)
        {
            this.terms = start;
        }

        public void ChangeStack(IStack<double> newStack)
        {
            double[] vals = terms.GetAll();
            foreach (double i in vals)
            {
                newStack.Push(i);
            }
            terms = newStack;
        }

        public void PushTerm(double term)
        {
            terms.Push(term);
        }
    }

}
