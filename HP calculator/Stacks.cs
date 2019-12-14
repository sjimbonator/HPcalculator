using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_calculator
{
    /// <summary>
    ///De ArrayStack werkt met een array en een integer. De integer houdt bij welk item uit de array het meest recent
    ///is gepushed. 
    /// </summary>
    public class ArrayStack<T> : Interfacestack<T>
    {
        public double[] list = new double[10];
        int top = -1;

        /// <summary>
        /// Als er niet genoeg ruimte in de array is voor het nieuwe item wordt de array 5 groter gemaakt.
        /// Als er (vervolgens) genoeg ruimte is in de array wordt er 1 opgeteld bij de top variabele.
        /// Vervolgens wordt de variabele item aan de array toegevoegd op de plek van de top variabele.
        /// </summary>
        public void Push(double item)
        {
            if (Count() == list.Length)
            {
                Array.Resize(ref list, Count()+5);
            }
            top += 1;
            list[top]=item;
        }

        /// <summary>
        /// Verwijdert en returned het laatst toegevoegde item.
        /// </summary>
        public double Pop()
        {
            double num = list[top];
            top -= 1;
            return num;
        }

        /// <summary>
        /// Returned een omgedraaide versie van list voor in de ListBox.
        /// </summary>
        public double[] GetALL()
        {
            int top2 = top + 1;
            double[] list2 = new double[top2];          
            Array.Copy(list, list2, top2);
            Array.Reverse(list2);
            return list2;
        }

        /// <summary>
        /// Returned het aantal items in list.
        /// </summary>
        public int Count()
        {
            return top + 1;
        }
    }

    /// <summary>
    /// ListStack werkt met een list en de methodes die al standaard in c# zitten.
    /// </summary>
    public class ListStack<T> : Interfacestack<T>
    {
        List<double> list = new List<double>();

        /// <summary>
        /// Returned het aantal items in list.
        /// </summary>
        public int Count()
        {
            return list.Count();
        }

        /// <summary>
        /// Voegt een item toe aan list.
        /// </summary>
        public void Push(Double item)
        {
            this.list.Add(item);
        }

        /// <summary>
        /// Returned alle items in list als omgedraaide array.
        /// </summary>
        public double[] GetALL()
        {
            double[] list2 = list.ToArray(); 
            Array.Reverse(list2);
            return list2;
        }

        public double Pop()
        {
            double top = list.Last();
            list.RemoveAt(Count() - 1);
            return top;

        }
    }

    /// <summary>
    /// Maakt een MyList en bijbehorende methodes. Deze MyList wordt in de class MyListStack gebruikt
    /// om een stack te maken. 
    /// </summary>
    public class MyList<T>
    {
        private MyList<T> previous;
        private double item;

        /// <summary>
        /// Constructor van MyList.
        /// </summary>
        public MyList(double item, MyList<T> previous)
        {
            this.item = item;
            this.previous = previous;
        }     

        /// <summary>
        /// Returned het item op een bepaalde index.
        /// </summary>
        public double GetItem(int index)
        {
            if (index == 0)
            {
                return item;
            }
            else
            {
                return previous.GetItem(index - 1);
            }
        }

        /// <summary>
        /// Voegt een item toe aan de Mylist en zorgt dat het laatst toegevoegde item bovenaan de MyList staat.
        /// </summary>
        /// <param name="item"></param>
        public void Push(double item)
        {
            previous = new MyList<T>(this.item, previous);
            this.item = item;

        }

        /// <summary>
        /// Returned het aantal items in de MyList.
        /// </summary>
        public int Count()
        {
            if (previous == null) return 1;
            return previous.Count() + 1;
        }

        /// <summary>
        /// Stopt alle items uit de MyList in een array en returned deze.
        /// </summary>
        public double[] GetALL()
        {
            double[] list2 = new double[Count()];
            for (int i = 0; i < Count(); i++)
            {
                list2[i] = GetItem(i);
            }
            return list2;
        }

        /// <summary>
        /// Returned het huidige item en haalt deze ook uit de stack.
        /// </summary>
        public double Pop()
        {
            double item2 = item;
            item = previous.item;
            previous = previous.previous;
            return item2;
        }
    }

    /// <summary>
    /// Gebruikt de MyList class om een stack te maken.
    /// </summary>
    public class MyListStack<T> : Interfacestack<T>
    {
        private MyList<double> Mylist = null;

        /// <summary>
        /// Maakt de MyList pas aan als er items zijn om te pushen. Zodra dit zo is stuurt deze methode
        /// het te-pushen door naar de Push methode van de MyList class.
        /// </summary>
        public void Push(double item)
        {
            if (Mylist == null)
            {
                Mylist = new MyList<double>(item, null);
            }
            else
            {
                Mylist.Push(item);
            }           
        }

        /// <summary>
        /// Roept de de GetALL methode van de MyList class aan, maar als de private Mylist nog nul is
        /// returned deze methode een array met 0 items voor opmaak redenen.
        /// </summary>
        public double[] GetALL()
        {
            if (Mylist != null) return Mylist.GetALL();
            else
            {
                double[] list2 = new double[0];
                return list2;
            }

        }

        /// <summary>
        /// Roept de Pop methode van de MyList class aan. Tenzij er nog maar een item in de stack zit.
        /// In dat geval wordt het object Mylist genulld nadat het enige item wat er nog in zat in een
        /// variabele is gestopt. Die variabele wordt gereturned.
        /// </summary>
        public double Pop()
        {
            if(Count()==1)
            {
                double item = Mylist.GetItem(0);
                Mylist = null;
                return item;
            }
            else
            {
                return Mylist.Pop();
            }
        }

        /// <summary>
        /// Roept de Count methode van de MyList class aan.
        /// </summary>
        public int Count()
        {
            return Mylist.Count();
        }
    }

}
