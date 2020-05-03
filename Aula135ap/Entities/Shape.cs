using System;
using System.Collections.Generic;
using System.Text;
using Aula135ap.Entities.Enums;

namespace Aula135ap.Entities
{
    abstract class Shape      // shape é figura
    {
        public Color Color { get; set; }

        
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
