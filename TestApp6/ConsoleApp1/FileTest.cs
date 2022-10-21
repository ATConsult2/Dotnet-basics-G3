using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace andrestech.learning2022.krasn1
{
    internal class FileTest
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("info.txt");
            //file.Exists

            File.WriteAllText("info.txt", "Hi!!!\n" +
                "Test2\n" + $"{DateTime.Now:yyyy.MM.dd HH:mm:ss.ff}\n", Encoding.UTF8);

            string[] lines =
                File.ReadAllLines("info.txt", Encoding.UTF8);

            foreach (string line in lines) WriteLine(line);


            using (FileStream fs = new FileStream
                ("info2.txt", FileMode.Append))
            {
                string data = "Hi!!!\n" +
                "Привет!!\n" + $"{DateTime.Now:yyyy.MM.dd HH:mm:ss.ff}\n";
                
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                fs.Write(buffer, 0, buffer.Length);
                
            }
                
                }
    }
}
