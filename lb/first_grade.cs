using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb
{
    class first_grade
    {
        public first_grade(string _name, string _lastname, int _group, string _status, string _fakultet)
        {
            Name = _name;
            LastName = _lastname;
            Group = _group;
            Status = _status;
            Fakultet = _fakultet;
        }
        public string _name;
        public string _lastname;
        public int _group;
        public string _status;
        public string _fakultet;
        public string Fakultet
        {
            get { return _fakultet; }
            set { _fakultet = value; }
        }
        public string Name
        { 
            get
            {
                return _name;
            }
            set
            {
                if (value == " ") _name = "Имя не введено";
                else _name = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                if (value == " ") _lastname = "Фамилия не введена";
                else _lastname = value;
            }
        }
        public int Group 
        {
            get
            {
                return _group;
            }
            set 
            {
                _group = value;
            }
        } 
        public string Status 
        {
            get
            {
                return _status;
            }
            set
            {
              _status = value;
            }
        }
        public virtual void Display() 
        {
            Console.WriteLine("первый курс ");
            string inform = _lastname + " " + _name + " " +"группа номер " + _group + " " + _status;
            Console.WriteLine(inform);
            string study = "факультет " + _fakultet + " учится на программиста (но не факт, что станет) ";// записать в лист
            Console.WriteLine(study);
        }
    }
}
