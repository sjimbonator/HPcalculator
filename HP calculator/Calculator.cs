using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HP_calculator
{
    public class Calculator
    {
        private Interfacestack<double> stack;

        /// <summary>
        /// Constructor voor de Calculator class.
        /// </summary>
        public Calculator(Interfacestack<double> start)
        {
            this.stack = start;
        }

        /// <summary>
        /// Haalt de oude stack in arrayform op. Pushed alle items van de oude stack in de nieuwe stack en 
        /// stopt de nieuwe stack in de stack variabele.
        /// </summary>
        public void ChangeStack(Interfacestack<double> newStack)
        {
            double[] oldstack = stack.GetALL();
            foreach (double i in oldstack)
            {
                newStack.Push(i);
            }
            stack = newStack;
        }

        /// <summary>
        /// Roept de Push methode van de stack aan.
        /// </summary>
        public void PushStack(double item)
        {
            stack.Push(item);
        }

        /// <summary>
        /// Roept de Pop methode van de stack aan.
        /// </summary>
        /// <returns></returns>
        public double PopStack()
        {
            return stack.Pop();
        }

        /// <summary>
        /// Roept de GetALL methode van de stack aan.
        /// </summary>
        public double[] GetALLTerm()
        {
            return stack.GetALL();
        }

        /// <summary>
        /// Roept de Count methode van de stack aan.
        /// </summary>
        public int Count()
        {
            return stack.Count();
        }

    }

}
