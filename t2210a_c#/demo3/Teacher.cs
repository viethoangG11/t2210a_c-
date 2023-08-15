uusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_C_.Demo3
{
    public class Teacher
    {
        private List<string> tels;
        public Teacher()
        {

            tels = new List<string>();

        }
        public List<string> Tels
        {
            get => tels;
            set => tels = value;
        }

        //indexer
        public string this[int index]
        {
            get => Tels[index];
            set => Tels[index] = value;
        }

        public virtual void Teach()
        {
            Console.WriteLine("Teach....");
        }
    }
}