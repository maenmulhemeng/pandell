using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    abstract class Shape
    {
        public Shape()
        {
            Title = "";
            ID = 0;
        }
        #region Properties
        public string Title { get; set; }
        public int ID { get; set; }
        #endregion

        #region
        
        private bool uninherited()
        {
            return true;
        }

        protected bool inheritedProtected()
        {
            return false;
        }

        public bool inheritedPublic()
        {
            return true;
        }

        public abstract void AbstractFunction();
        #endregion
    }
}
