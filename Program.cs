using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Program
    {
        public static int classVar = 0;
        static void Main(string[] args)
        {
            //클래스 변수 호출
            Program.classVar = -1;

            //인스턴스 변수처럼 글래스 변수 사용 불가에 주의(자바에서는 ok)
            //Program p = new Program();
            //p.classVar = -3;

            //property 실습
            Box box1 = new Box(100, 200);
            box1.Width = -3;
            Console.WriteLine(box1.Width);
            Console.WriteLine(box1.Area);

            
        }
    }
}
