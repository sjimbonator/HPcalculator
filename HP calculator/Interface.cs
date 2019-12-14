using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_calculator
{
    /// <summary>
    /// Interface waarin methodes staan die elk stacktype gebruikt.
    /// </summary>
    public interface Interfacestack<T>
    {
        /// <summary>
        /// Pushed een item naar de stack. Voegt dus een item toe aan de "bovenkant" van de stack.
        /// </summary>
        /// <param name="item"></param>
        void Push(double item);

        /// <summary>
        /// Returned de stack in de vorm van een omgedraaide array.
        /// </summary>
        double[] GetALL();

        /// <summary>
        /// Returned en verwijdert het "bovenste" item van de stack.
        /// </summary>
        double Pop();

        /// <summary>
        /// Returned het aantal items in de stack.
        /// </summary>
        int Count();
    }
}
