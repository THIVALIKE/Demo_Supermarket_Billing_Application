using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Supermarket_Billing_System
{
    public class Customer
    {
        int _id;

        public int Id
        {
            get { return _id; }
        }

        string _name;

        public string Name
        {
            get { return _name; }

        }

        gender gender;

        public gender Gender
        {
            get { return gender; }
            
        }
        string _mobile_num;

        public string Mobile_num
        {
            get { return _mobile_num; }

        }

        string _email_id;

        public string Email_id
        {
            get { return _email_id; }

        }

        Address address_details;

        public Address Address_details
        {
            get { return address_details; }
            set { address_details = value; }
        }

        public Customer(int Id, string Name,gender Gen ,string Mobile_num, string Email_id, Address Address_info)
        {
            this._id = Id;
            this._name = Name;
            this.gender = Gen;
            this._mobile_num = Mobile_num;
            this._email_id = Email_id;
            this.Address_details = Address_info;
        }

        public Customer()
        {

        }

        
    }

    enum gender
    {
        Male=0,
        Female=1,
        Trans=2
    }
}
