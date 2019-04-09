using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_one
{
    public class HtmlTable
    {

        public string html;
        List<string> head;
        List<List<string>> body;
        List<string> foot;


        public HtmlTable()
        {
            head = new List<string>();
            body = new List<List<string>>();
            foot = new List<string>();
        }
        public HtmlTable(List<List<string>> inbody):this()//samo body
        {
            foreach(List<string> sublist in inbody)
            {
                this.body.Add(sublist);
            }
        }
        public HtmlTable(List<string> inhead):this()//sam head
        {
            this.head = inhead;
        }
        public HtmlTable(List<string> inhead, List<List<string>> inbody) : this(inbody)// head + body
        {
            this.head = inhead;
        }
        public HtmlTable(List<string> inhead, List<List<string>> inbody,List<string> infoot):this(inhead,inbody) // head+body+foot
        {
            this.foot = infoot;
        }

        public void Generate()//generuje HTMLA
        {
            if (this.body.Count > 0 | this.head.Count >0)
            {
                html = "<!DOCTYPE html>\n<html>\n";
                if (this.head.Count > 0)
                {
                    html += "<head>\n<tr>";
                    foreach (string element in this.head)
                    {
                        html += "<th> " + element + " </th>\n";
                    }
                    html += "</tr></head>\n";
                }
                else
                {
                    html += "<head>\n</head>\n";
                }
                if(this.body.Count>0)
                {
                    html += "<body>\n";
                    foreach (List<string> sublist in this.body)
                    {
                        html += "<tr>\n";
                        foreach(string element in sublist)
                        {
                            html += "<td> " + element + " </td>\n";
                        }
                        html += "</tr>\n";
                    }
                }
                else
                {
                    html += "<body>\n</body>\n";
                }
                if (this.foot.Count > 0)
                {
                    html += "<foot>\n<tr>";
                    foreach (string element in this.foot)
                    {
                        html += "<th> " + element + " </th>\n";
                    }
                    html += "</tr></foot>\n";
                }
                else
                {
                    html += "<foot>\n</foot>\n";
                }
                html += "</html>\n";
            }
        }
        public void CreateHead(List<string> head)
        {
            if (this.head.Count == 0)
            {
                this.head = head;
            }
            else{ Console.WriteLine("HEAD JUZ ISTNIEJE");}
        }
        public void AddHead(string head)
        {
            this.head.Add(head);
        }

        public void CreateBody(List<List<string>> body)
        {
            this.body = body;
        }
        public void AddBodyRow(List<string> bodyrow)
        {
            this.body.Add(bodyrow);
            foreach(string element in bodyrow)
            {
                Console.WriteLine("element = "+ element);
            }
        }
        public List<string> AddRow(int i)
        {
            string text;
            List<string> wiersz=new List<string>();
            while(i>0)
            {
                text = Console.ReadLine();
                wiersz.Add(text);
                i--;
            }
            return wiersz;
        }


        public void CreateFoot(List<string> foot)
        {
            if (this.foot.Count == 0)
            {
                this.foot = foot;
            }
            else { Console.WriteLine("FOOT JUZ ISTNIEJE"); }
        }
        public void AddFoot(string foot)
        {
            this.foot.Add(foot);
        }

        public void ShowAll ()
        {
            if(this.head.Count>0)
            {
                Console.WriteLine("head:");
                foreach (string element in this.head) { Console.Write(element + "\t"); }
                Console.WriteLine();
            }
            if (this.body.Count > 0)
            {
                Console.WriteLine("body:");
                foreach (List<string> sublist in this.body)
                {
                    foreach (string element in sublist)
                    {
                        Console.Write(element + "\t");
                    }
                    Console.WriteLine();
                }

            }
            if (this.foot.Count > 0)
            {
                Console.WriteLine("foot:");
                foreach (string element in this.foot) { Console.Write(element + "\t"); }
            }
            Console.WriteLine();
        }
    }
}
