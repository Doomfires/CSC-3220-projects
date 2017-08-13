using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_ErkinGeorge
{
    public class Registrant
    {
        private string _Name;
        private string _Company;
        private string _City;
        private string _State;
        private int _Zip;
        private string _Phone;
        private string _Email;

        //default constructor 
        public Registrant()
        {
            _Name = "";
            _Company = "";
            _City = "";
            _State = "";
            _Zip = 0;
            _Phone = "";
            _Email = "";
        }

        public Registrant(string name, string company, string phone, string email, string city, string state, int zip)
        {
            _Name = name;
            _Company = company;
            _Phone = phone;
            _Email = email;
            _City = city;
            _State = state;
            _Zip = zip;
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }  
        }

        public string Company
        {
            get { return _Company; }
            set { _Company = value; }
        }

        public string Phone

        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string cityState
        {
            get { return _City + ", " + _State + " " + _Zip; }
        }
        
        public string City
        {
            set { _City = value; }
        }    

        public string State
        {
            set { _State = value; }
        }

        public int Zip
        {
            set { _Zip = value; }
        }
    }
}
