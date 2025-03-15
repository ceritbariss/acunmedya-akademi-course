using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProgrammingLanguage
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public ProgrammingLanguage()
        {
            
        }
        public ProgrammingLanguage(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }
    }
}
