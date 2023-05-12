using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latintanc
{
    internal class Par
    {
        private string tanctipus;
        private string nonev;
        private string ferfinev;

        public string Tanctipus { get => tanctipus; set => tanctipus = value; }
        public string Nonev { get => nonev; set => nonev = value; }
        public string Ferfinev { get => ferfinev; set => ferfinev = value; }

        public Par(string tanctipus,string nonev, string ferfinev)
        {
            this.tanctipus = tanctipus;
            this.nonev = nonev;
            this.ferfinev = ferfinev;
        }

        public override string ToString()
        {
            return $"{tanctipus}, {nonev}, {ferfinev}\n";
        }
    }
}
