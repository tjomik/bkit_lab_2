
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;



namespace LAB_2
{
    abstract class Figure
    {
       public string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }
        string _Type;
        public abstract double FindArea();

        public override string ToString()
        {
            return this.Type + " площадью " + this.FindArea().ToString();

        }

    }
}