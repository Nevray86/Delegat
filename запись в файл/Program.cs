using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;

namespace MultiFilesAndDelegates
{
    delegate void myDelegate(string myStr, string tmp);

    class Program
    {
        static void Main(string[] args)
        {
           
           // Regex regex = new Regex(@"(\d+)", RegexOptions.IgnoreCase);
            Regex regex = new Regex(@"(\S)", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(myClass.ReadTaskFile("Journal.txt"));
            // MatchCollection matches = Regex.Matches("", @"(\D)");

            string x = "";
            
            if (matches.Count != null)
            {
                
                for (int i = 0; i < matches.Count; i++)
                    
                {



                    /* string a = matches[i].ToString();
                     string s = matches[0].ToString();
                     int S = int.Parse(s);
                     string z = matches[2].ToString();
                     int Z = int.Parse(z);*/


                    x += matches[i].ToString();
                   

                }

                double rez = Convert.ToDouble(new DataTable().Compute(x, ""));
                Console.WriteLine(rez);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            Console.ReadLine();
        }
    }
}



