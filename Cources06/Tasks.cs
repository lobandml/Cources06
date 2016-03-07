using Cources06.DiffWays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Cources06
{
    class Tasks
    {
        private static int IntParseInput(string message)
        {
            int result;
            do
            {
                Console.WriteLine(message);
            }
            while (!Int32.TryParse(Console.ReadLine(), out result));
            return result;
        }

        private static double DoubleParseInput(string message)
        {
            double result;
            do
            {
                Console.WriteLine(message);
            }
            while (!Double.TryParse(Console.ReadLine(), out result));
            return result;
        }

        public static void Task1()
        {
            Notebook testnotebook=new Notebook("mod1","man1",9000);
            Console.WriteLine(testnotebook.ToString());
        }
        public static void Task2()
        {
            List < Train > depot= new List<Train>();
            int counter = 0;
            while (counter < 8)
            {
                //заглушка ввода
                depot.Add(new Train("Днепропетровск",counter,new DateTime(1996,1,counter+1)));
                counter++;
            }
            depot.Sort();

            
            int number = IntParseInput("Введите номер поезда: ");
            bool founded = false;
            for (int i = 0; i < depot.Count; i++)
            {
                if (depot[i].Sign == number)
                {
                    founded = true;
                    Console.WriteLine(depot[i].ToString());
                    break;
                }
            }
            if (!founded)
            {
                Console.WriteLine("Такого поезда нет");
            }
            
        }

        static void ClassTaker(MyClass cl)
        {
            cl.change = "Изменено";
        }
        static void StructTaker(MyStruct st)
        {
            st.change = "Изменено";
        }

        public static void Task3()
        {
            MyClass myclassinst = new MyClass();
            myclassinst.change = "Не изменено";
            ClassTaker(myclassinst);
            MyStruct mystructinst = new MyStruct();
            mystructinst.change = "Не изменено";
            StructTaker(mystructinst);
            Console.WriteLine("Class: " + myclassinst.change);
            Console.WriteLine("Struct: " + mystructinst.change);
            

        }
        public static void Task4()
        {
            int day = IntParseInput("Введите день");
            int month = IntParseInput("Введите месяц");
            
            try
            {
                DateTime birthday = new DateTime(DateTime.Now.Year, month, day);
                if (birthday < DateTime.Now)
                {
                    birthday = birthday.AddYears(1);
                }
                
                //Например, между 7 и 8- 1 день или 0? 
                int b = birthday.Subtract(DateTime.Now).Days;
                Console.WriteLine("{0} days", b);
            }
            catch
            {
                Console.WriteLine("Введена неправильная дата.");
            }

        }
        public static void Task5()
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();

            int color = IntParseInput("Введите цвет (0-2)");
            Printer.Print(str, color);
        }
        public static void Task6()
        {
            Console.WriteLine(Accauntant.AskForBonus(Post.Junior, 200).ToString());
            Console.WriteLine(Accauntant.AskForBonus(Post.Junior, 201).ToString());
            Console.WriteLine(Accauntant.AskForBonus(Post.Middle, 222).ToString());
        }
    }
}
