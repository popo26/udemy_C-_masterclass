using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78_OOP_Properties
{
    class Box
    {
        //member variable
        private int volume;

        //property - getter and setter1
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        //property -getter and setter2
        public int FrontSurface
        {
            get
            {
                return Length * Height;
            }
        
        }

        //constractor
        public Box(int length, int height, int width)
        {
            Length = length;
            Height= height;
            Width = width;  
        }

        public int GetVolume()
        { 
            this.volume = Length * Height * Width;
            return volume;
        }
    }
}
