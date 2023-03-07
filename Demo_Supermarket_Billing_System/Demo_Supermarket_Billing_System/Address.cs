using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Supermarket_Billing_System
{
    public class Address
    {
        string _house_no;

        public string House_no
        {
            get { return _house_no; }
        }
        string _street_name;

        public string Street_name
        {
            get { return _street_name; }
        }
        string _village_name;

        public string Village_name
        {
            get { return _village_name; }
        }
        string _taluk_name;

        public string Taluk_name
        {
            get { return _taluk_name; }
        }
        string _pincode;

        public string Pincode
        {
            get { return _pincode; }
        }
        string _district;

        public string District
        {
            get { return _district; }
        }

        public Address(string house_no, string street_name, string village_name, string taluk_name, string district, string pin_code)
        {
            this._house_no = house_no;
            this._street_name = street_name;
            this._village_name = village_name;
            this._taluk_name = taluk_name;
            this._district = district;
            this._pincode = pin_code;
        }

        public Address()
        {

        }
    }
}
