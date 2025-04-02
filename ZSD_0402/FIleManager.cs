using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace ZSD_0402
{
    class FileManager
    {
        private string fileName;
        public FileManager(string fileName)
        {
            this.fileName = fileName;
        }
        public List<Person> ReadFile()
        {
            List<Person> lista = new List<Person>();
            try
            {
                StreamReader read = new StreamReader(fileName, Encoding.UTF8);
                read.ReadLine();
                while (!read.EndOfStream)
                {
                    lista.Add(new Person(read.ReadLine()));
                }
                read.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Hiba!");
            }
            return lista;
        }

        public void WriteFile(List<Person> lista)
        {
            try
            {
                StreamWriter write = new StreamWriter(fileName, false, Encoding.UTF8);
                write.WriteLine("Első sor");
                foreach (Person item in lista)
                {
                    write.WriteLine(item.Height + "-" + item.Weight);
                }
                write.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Hiba!");
            }
        }
    }
}
