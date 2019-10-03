﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab1
{
    class Square : Shape
    {
        public Square(int width)
            :base(width, width)
        {

        }

        public override float Area()
        {
            return width * width;
        }
    }
}
