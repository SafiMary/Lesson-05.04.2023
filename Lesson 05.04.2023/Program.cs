using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_05._04._2023
{
    public class myTest
    {
        public int a;
        public myTest()
        {
            Console.WriteLine("Создан объект");
        }
        public static int myDouble(int _arg)
        {
            return _arg + 2;
        }
    }
    internal class Program
    {
        static void myConvert(string _promt,out int? a) //out- куда сложить
        {
             a = null;
            Console.WriteLine(_promt);
            try
            {
              a = int.Parse(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            //return a;
        }
        static void Main(string[] args)
        {
            var a = 4;
            int? a1 = null;//расширенный тип данных кот-й может сод-ть ноль
            string b = "6a";
            while (a1== null)
            {
                 myConvert("Введите число",out a1);
            }
            var aaa = new myTest();
           // Console.WriteLine(aaa.myDouble(a));
            myTest.myDouble(3);
            Console.WriteLine(a1);
            //Console.WriteLine(aaa);
            int[] arr = new int[3] { 1, 2, 4 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            var _list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                _list.Add(arr[i]);
                Console.WriteLine(_list[i]);
            }
            _list.Add(-7);
            int counter = 0;
            foreach (var item in _list)
            {
                Console.Write("Элемент {0}  равен {1}\n", counter, item);//плейсхолдер назначили место для элемента
                //Console.Write($"Элемент {counter} равен {item}");
                counter++;
            }
            Console.ReadKey();
        }
    }
}
