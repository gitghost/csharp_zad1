using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_one
{
    class Program
    {
        static void Main()
        {
            TestOne();
            TestTwo();
            TestThree();
            TestFour();
   

            Console.WriteLine("\n -END- ");
            Console.ReadLine();
        }

        public static void TestOne()
        {
            Console.WriteLine("TEST ONE");
            var content = new List<List<string>>();
            var lineA = new List<string>();
            lineA.Add("111");
            lineA.Add("112");
            content.Add(lineA);
            var lineB = new List<string>();
            lineB.Add("211");
            lineB.Add("212");
            content.Add(lineB);
            var test1 = new HtmlTable(content);
            test1.ShowAll();
        }

        public static void TestTwo()
        {
            Console.WriteLine("TEST TWO");
            var content = new List<List<string>>();
            var lineA = new List<string>();
            lineA.Add("1naprawdedlugieteksty");
            lineA.Add("2naprawdedlugieteksty");
            lineA.Add("3naprawdedlugieteksty");
            content.Add(lineA);

            var lineB = new List<string>();
            lineB.Add("4naprawdedlugieteksty");
            lineB.Add("5naprawdedlugieteksty");
            lineB.Add("6naprawdedlugieteksty");
            content.Add(lineB);

            var test2 = new HtmlTable(content);
            test2.ShowAll();

        }
        public static void TestThree()
        {
            Console.WriteLine("TEST THREE");
            StreamReader sr = new StreamReader("data.txt");
            string line = sr.ReadLine();
            string[] head=line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
           
            var head_list = new List<string>();         //potrzbuje listy
            foreach (string element in head)
            { head_list.Add(element);
                Console.Write(element+ " ");
            }
            Console.WriteLine();

            var body_list = new List<List<string>>();
            var body_line = new List<string>();
            var body_temp = new List<string>();

            string[] one_line= {};

            while ((line=sr.ReadLine()) != null)
            {
                one_line = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string element in one_line)
                {
                    body_temp.Add(element);
                    Console.Write(element + " ");
                }
                body_line = CopyList(body_temp);
                body_temp.Clear();
                body_list.Add(body_line);
                Console.WriteLine();
            }

                


            var test3 = new HtmlTable(head_list,body_list);
            test3.Generate();
            System.IO.File.WriteAllText(@"\\beta-d\users$\lk08150\Dokumenty\CSHARP\ZAD1\task_one\index.html", test3.html);

        }

        public static void TestFour()
        {
            Console.WriteLine("TEST FOUR");
            List<string> inhead = new List<string>(new string[] { "jeden", "dwa", "trzy","cztery","piec"});
            var content = new List<List<string>>();
            var lineC = new List<string>();
            lineC.Add("111");
            lineC.Add("112");
            lineC.Add("113");
            lineC.Add("114");
            lineC.Add("115");
            content.Add(lineC);
            var lineD = new List<string>();
            lineD.Add("211");
            lineD.Add("212");
            lineD.Add("213");
            lineD.Add("214");
            lineD.Add("215");
            content.Add(lineD);

            var test4 = new HtmlTable(inhead,content);
            test4.ShowAll();
        }


        public static List<String> CopyList(List<string> input)
        {
            var nowa =new List<string>();
            foreach(string element in input)
            {
                nowa.Add(element);
            }
            return nowa;
        }

    }

  

    
}
