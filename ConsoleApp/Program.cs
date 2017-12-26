using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            List<Student> studentCollection = new List<Student>();
            Random rand = new Random();

            #region filling
            {
                Student studentTemp = new Student();
                studentTemp.Age = 16;
                studentTemp.Name = "Alexey";
                studentTemp.LastName = "Popov";
                studentTemp.Group = "TTP-12";
                studentTemp.MidleScore = 4.1;
                studentCollection.Add(studentTemp);
            }
            #endregion

            #region Write
            using (StreamWriter writer = new StreamWriter("FileStudent.txt", false))
            {
                for (int i = 0; i < studentCollection.Count; i++)
                {
                    writer.WriteLine(studentCollection[i].Age);
                    writer.WriteLine(studentCollection[i].Name);
                    writer.WriteLine(studentCollection[i].LastName);
                    writer.WriteLine(studentCollection[i].Group);
                    writer.WriteLine(studentCollection[i].MidleScore);
                }
            }
            Console.WriteLine("Ифнормация успешно записана в файл!");
            #endregion


            Console.ReadLine();
        }
    }
}
