using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//testy do Program

namespace C_Hash_1
{
    class htmlTable
    {
        public string content;

        internal void tableStart()
        {
            content += "<html><style> table {font-family: arial, sans-serif; border-collapse: collapse; width: 100%;} td, th {border: 1px solid #dddddd; text-align: left; padding: 8px;} tr:nth-child(even) {background-color: #dddddd;} </style> <table>\n\n";
        }
        internal void tableEnd()
        {
            content += "</table></html>";
        }

        internal void bodyStart()
        {
            content += "<tbody>\n";
        }

        internal void bodyEnd()
        {
            content += "</tbody>\n";
        }

        internal void footStart()
        {
            content += "<tfoot>\n";
        }

        internal void footEnd()
        {
            content += "</tfoot>\n";
        }

        internal void rowStart()
        {
            content += "<tr>\n";
        }

        internal void rowEnd()
        {
            content += "</tr>\n";
        }

        internal void headStart()
        {
            content += "<thead>\n";
        }

        internal void headEnd()
        {
            content += "</thead>\n";
        }

        internal void addHeadContent(string text)
        {
            content += "<th>";
            content += text;
            content += "</th>\n";
        }

        internal void addContent(string text)
        {
            content += "<td>";
            content += text;
            content += "</td>\n";
        }


        public htmlTable()
        {

        }

        public htmlTable(int w, int k, string[] tresc)
        {
            int ti = 0;
            tableStart();
            for (int i = 0; i < w; i++)
            {
                rowStart();
                for (int j = 0; j < k; j++)
                {
                    addContent(tresc[ti]);
                    ti++;
                }
                rowEnd();
            }
            tableEnd();

        }
    }

    class Program
    {
        public void test1(int w, int k)
        {
            //TEST 1: 2x2 proste liczby
            htmlTable tab = new htmlTable();
            tab.tableStart();
            for (int i = 0; i < w; i++)
            {
                tab.rowStart();
                for (int j = 0; j < k; j++)
                {
                    int temp = (i + 1) * (j + 1);
                    string s = temp.ToString();
                    tab.addContent(s);
                }
                tab.rowEnd();
            }
            tab.tableEnd();
            Console.WriteLine(tab.content);
            Console.WriteLine("-------------------------\n");
            File.WriteAllText("wynik.html", tab.content);
        }


        internal void test2(int w, int k)
        {
            //TEST 2: 2x3 długie teksty
            htmlTable tab2 = new htmlTable();
            tab2.tableStart();
            for (int i = 0; i < w; i++)
            {
                tab2.rowStart();
                for (int j = 0; j < k; j++)
                {
                    int temp = (i + 1) * (j + 1);
                    string s = "tekst " + temp.ToString();
                    tab2.addContent(s);
                }
                tab2.rowEnd();
            }
            tab2.tableEnd();
            Console.WriteLine(tab2.content);
            Console.WriteLine("-------------------------\n");
            File.WriteAllText("wynik2.html", tab2.content);
        }

        internal void test3(string plik)
        {
            //TEST 3: odczyt z pliku, zapis do .html
            htmlTable tab3 = new htmlTable();
            var lines = File.ReadAllLines(plik);
            tab3.tableStart();
            foreach (var lin in lines)
            {
                tab3.rowStart();
                var cols = lin.Split(';');

                foreach (var col in cols)
                {
                    tab3.addContent(col);
                }
            }
            tab3.tableEnd();
            File.WriteAllText("wynik3.html", tab3.content);
        }

        internal void test4(int w, int k)
        {
            //TEST 4: 2x5 z wierszem nagłówkowym
            htmlTable tab4 = new htmlTable();
            tab4.tableStart();
            for (int i = 0; i < w; i++)
            {
                if (i == 0)
                {
                    tab4.headStart();
                }
                else
                {
                    tab4.rowStart();
                }
                for (int j = 0; j < k; j++)
                {
                    int temp = (i + 1) * (j + 1);
                    string s = "tekst " + temp.ToString();
                    if (i == 0)
                    {
                        tab4.addHeadContent(s);
                    }
                    else
                    {
                        tab4.addContent(s);
                    }
                }
                if (i == 0)
                {
                    tab4.headEnd();
                }
                else
                {
                    tab4.rowEnd();
                }
            }
            tab4.tableEnd();
            Console.WriteLine(tab4.content);
            Console.WriteLine("-------------------------\n");
            File.WriteAllText("wynik4.html", tab4.content);
        }

        internal void test5(int w, int k)
        {
            //KONSTRUKTOR
            string[] temp = { "halo", "walo", "jurek", "sznurek", "widly", "igly" };
            htmlTable tab5 = new htmlTable(w, k, temp);
            Console.WriteLine(tab5.content);
            Console.WriteLine("-------------------------\n");
        }

        static void Main(string[] args)
        {

            Program testy = new Program();
            testy.test1(2, 2);
            testy.test2(2, 3);
            testy.test3("dane.csv");
            testy.test4(2, 5);
            testy.test5(3, 2);
        }
    }
}
