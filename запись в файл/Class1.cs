using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MultiFilesAndDelegates
{
    class myClass
    {
        static private string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            , filename;

       
        static public void WriteHello(string Name, string FileName)
        {
            string _text = "Привет, " + Name + "!" + "\n";
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            filename = path + "\\" + FileName;
            StreamWriter sw = File.AppendText(filename);
            sw.WriteLine(_text);
            sw.Close();
        }
        static public string ReadTaskFile(string fileName)
        {
            string _input = "";
            int counter = 0;
            fileName = path + "\\" + fileName;
            StreamReader sr = new StreamReader(fileName);

            _input = sr.ReadLine();
            return _input;

            /*while ( sr.ReadLine() != null)
            {
                _input = sr.ReadLine();
                counter++;
            }
            return _input;*/

        }
    }
}

