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
        private int height;

        public Box(int width, int heigth)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연수로 초기화 해주세요");

            }
        }

        public int getWidth() { return this.width; }
        public int getHeight() { return this.height; }
        public void setWidth()
        {
            if(width > 0) { this.width = width; }
            else { Console.WriteLine("너비는 자연수로 입력해주세요"); }
        }

        public void setHeight()
        {
            if (height > 0) { this.height = height; }
            else { Console.WriteLine("높이는 자연수로 입력해주세요"); }
        }

        public int Area()
        {
            return this.width * this.height;
        }
    }
}
