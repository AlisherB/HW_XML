using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Console;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Student.xml");
            Student student = new Student();
            XmlElement element = xmlDoc.DocumentElement;

            XmlNode classStudent = xmlDoc.CreateElement("Student");
            xmlDoc.DocumentElement.AppendChild(classStudent);

            Write("Введите имя: ");
            student.Name = ReadLine();
            XmlNode name = xmlDoc.CreateElement("name");
            name.InnerText = student.Name;
            classStudent.AppendChild(name);

            Write("Введите фамилию: ");
            student.Surname = ReadLine();
            XmlNode surname = xmlDoc.CreateElement("surname");
            surname.InnerText = student.Surname;
            classStudent.AppendChild(surname);

            Write("Введите возраст: ");
            student.Age = ReadLine();
            XmlNode age = xmlDoc.CreateElement("age");
            age.InnerText = student.Age;
            classStudent.AppendChild(age);

            Write("Введите специальность: ");
            student.Speciality = ReadLine();
            XmlNode speciality = xmlDoc.CreateElement("speciality");
            speciality.InnerText = student.Speciality;
            classStudent.AppendChild(speciality);
            
            xmlDoc.Save("Student.xml");
            ReadLine();
        }
    }
}
