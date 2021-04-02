using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    class Circle : Shape
    {
        #region Constructors
        
        public Circle():base()
        {
            
            
        }

        public override void AbstractFunction()
        {
            Console.WriteLine("Overrided");
        }

        #endregion

        #region Functions
        public float area()
        {
            f();
            Console.WriteLine(inheritedProtected());
            return 1.5f;
        }
        private float f()
        {
            return 1;
        }
        #endregion
    }
}
