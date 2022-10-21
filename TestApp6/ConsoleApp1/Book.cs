using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace andrestech.learning2022.krasn
{
    internal class Book
    {
        private String Id { get; set; } = "AAA-120454-FICTION-00";
        public string Title { get; set; }   
        public string Author { get; set; }

        public string getId() { return Id; }

    }
}
