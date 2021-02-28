using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_HAS_A_Relation__A_
{
    class Address
    {
        private string houseNo;
        private string roadNo;
        private string city;
        private string countryName;


        public Address(string houseNo, string city, string roadNo, string countryName)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.city = city;
            this.countryName = countryName;
        }

        public string HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }
        }
        public string RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }
        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }

        public string CountryName
        {
            set { this.countryName = value; }
            get { return this.countryName; }
        }

        public void PrintAddress()
        {
            Console.WriteLine("Address:Road No-{0},House No-{1}, City-{2} , Country Name-{3}", this.houseNo, this.roadNo, this.city, this.countryName);
        }
    }
}