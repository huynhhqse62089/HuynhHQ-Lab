using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Suppliers
    {
        private string supplierId;
        private string companyName;
        private string contactName;
        private string contactTitle;
        private string address;
        private string city;
        private string region;
        private string postalCode;
        private string country;
        private string phone;
        private string fax;
        private string homePage;

        public string HomePage
        {
            get { return homePage; }
            set { homePage = value; }
        }


        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }


        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }


        public string Country
        {
            get { return country; }
            set { country = value; }
        }


        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }


        public string Region
        {
            get { return region; }
            set { region = value; }
        }


        public string City
        {
            get { return city; }
            set { city = value; }
        }


        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public string ContactTitle
        {
            get { return contactTitle; }
            set { contactTitle = value; }
        }


        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }


        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }


        public string SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }

    }
}
