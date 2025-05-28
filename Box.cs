using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Box
    {
        private int width;
        public int Width 
        { 
            get { return width; }
            set 
            { 
                if (value < 0)
                {
                    Console.WriteLine("너비는 자연수로 입력해주세요");
                }
                else
                {
                    width = value;
                }
            }
        }

        private int height;

        public int Height
        {
            get { return height; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("너비는 자연수로 입력해주세요");
                }
                else
                {
                    height = value;
                }
            }
        }

        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area
        {
            get { return Width * Height; }
        }
    }
}
