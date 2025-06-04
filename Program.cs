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

            //생성자
            //기본생성자 - 생성자를 하나라도 정의하면 기본생성자를 따로 작성해줘야함
            //Product p = new Product();

            //팩토리 메서드 패턴 (생성자에 private를 사용하는 경우)
            Product p = Product.GetInstance("아아", 1500);

            //정적 생성자 예제
            Console.WriteLine("첫번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("두번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세번째 위치");

            //상수, readonly 키워드 비교 예시
            MyMath m = new MyMath();
            Console.WriteLine(MyMath.PI);

            Item item1 = new Item("고구마", 1000);
            Item item2 = new Item("사과", 1300);
            Item item3 = new Item("감자", 2000);
            Console.WriteLine(item1.id);
            Console.WriteLine(item2.id);
            Console.WriteLine(item3.id);
            //item3.id = 3 //readonly 키워드가 지정된 인스턴스 변수는 수정 불가


            //property 실습
            Box box1 = new Box(100, 200);
            box1.Width = -3;
            Console.WriteLine(box1.Width);
            Console.WriteLine(box1.Area);


            //값 복사
            int a = 10;
            int b = a; //값 복사
            b = 20;
            Console.WriteLine(a); //a와 b가 별개 변수

            //참조 복사
            Test test = new Test();
            test.value = 5;
            Change(test);  //레퍼런스 넘김에 주의
            Console.WriteLine(test.value);
            
        }

        class Test
        {
            public int value = 10;
        }
        static void Change(Test input) //메인 메소드와 같은 위치,레퍼런스를 매개변수로 받음
        {
            input.value = 20;
        }
    }
}
