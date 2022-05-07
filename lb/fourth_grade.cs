using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb
{
    class fourth_grade: first_grade
    {
        public fourth_grade(string _name, string _lastname, int _group, string _status, string _fakultet)
            : base(_name, _lastname,_group, _status, _fakultet)
        {
        }
        public override void Display()
        {
            base.Display();
        }
    }
}
