using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//class Transform
//{
//    public int number;
//    string str;

//public int Number
//{
//    get
//    {
//        return number;
//    }

//    set
//    {
//        number = value;
//    }
//}

//public static int Square(ref int x)
//{
//    return x = x * x;
//}

//public void AddMultiply(int a, int b, out int sum, out int multiply)
//{
//    sum = a + b;
//    multiply = a * b;
//}
// int a = 10;
//Transform t = new Transform();
//int p = 5;
//Transform.Square(ref p);
//int x = int.Parse(Console.ReadLine());
//t.Number = x;
//Console.WriteLine(t.Number);
//int res1, res2;

//t.AddMultiply(10, 15,out res1,out res2);
////t.Square(ref a);
//Console.WriteLine("value of result is {0} , {1} ", res1, res2);
//Console.ReadKey();
//Transform obj = t;

//t.number = 10;
//Console.WriteLine(obj.number);
//t.number = 15;
//Console.WriteLine(obj.number);
//Console.ReadKey();

//interface IAdd
//{
//    int addition(int x, int y);
//    int subtraction(int x, int y);
//}


//            AsyncCallback 
//                BeginInvoke 
//            IAdd obj = new compute();
//            int x = obj.subtraction(5,2);
//            Console.WriteLine(x);
//            Console.Read();
//        }
//    }
//        class compute : IAdd
//        {
//            public int multiplication(int x, int y)
//            {
//                return x * y;
//            }

//            public int addition(int x, int y)
//            {
//                return x + y;
//            }

//            public int subtraction(int x, int y)
//            {
//                return x - y;
//            }
//        }

//}

namespace Dev001
{
    class Program
    {

        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            var t = obj.MyMethod("Asynch calling example check for subsequent delays in strings");

            Console.WriteLine("Going to call the method Asynchronously");
            Console.WriteLine("Control is back to Main");
            
            Console.WriteLine(t.Result);
            Console.ReadLine();
        }
       
    }

    public class MyClass
    {
        public async Task<string> MyMethod(string text)
        {
            string str = await Task.Run(() =>
            {
                Thread.Sleep(1000);

                return "Hello" + text;
            });
            return str;
        }
    }
}
