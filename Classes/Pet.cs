using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Pet
    {
        private string _name;

        public Pet()
        {
            _name = "Rover";
        }

        public string Name //Example of a name property
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value; 
            }
        }
        
        public Pet(string n)  ///Method signature
        {
            _name = n;
        }
        

      /*  public string getName()
        {
            return name;
        }

        public void setName(string n)
        {
            name = n;
        }*/
    }
}
