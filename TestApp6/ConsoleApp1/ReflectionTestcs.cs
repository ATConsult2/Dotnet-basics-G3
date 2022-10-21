#define DEBUG1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

using static System.Console;

namespace andrestech.learning2022.krasn
{
    internal class ReflectionTestcs
    {
        static void Main2(string[] args) {

            F1();
            F2();

            Book book = new Book() { Author = "А. Чехов", Title = "Дядя Ваня" };

            Type type = typeof(Book);
            PropertyInfo[] props = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (PropertyInfo prop in props) {
                WriteLine(prop.Name + " ---- " + prop.PropertyType + " ------- " + prop.Module);
            }
            PropertyInfo propId = type.GetProperty("Id", BindingFlags.NonPublic | BindingFlags.Instance);
            WriteLine("Private Id:" + propId.GetValue(book));
            WriteLine(book.getId());
            propId.SetValue(book, "---111---");
            WriteLine(book.getId());

            //---------------
            Type typeLib = typeof(Library);
            Attribute attr = typeLib.GetCustomAttribute(
                typeof(LogLevelAttribute), false);
            if (attr is LogLevelAttribute lla)
                WriteLine("Level:" + lla.Level);
        }

        [Conditional("DEBUG1")]
        static void F1() => WriteLine("F1 wire!");

        [Conditional("DEBUG2")]
        static void F2() { WriteLine("F2 wire!"); }
    }
}
