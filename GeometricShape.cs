﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopconcepts
{
    public abstract class GeometricShape
    {
        protected string Name { get; set; }
        protected int Faces { get; set; }
        public GeometricShape(string name, int faces)
        {
            Name = name;
            Faces = faces;
        }
        public abstract void RotateShape();
        public abstract void ShowInfo();
    }
    
}