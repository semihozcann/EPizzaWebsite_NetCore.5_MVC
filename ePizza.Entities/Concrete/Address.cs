﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Entities.Concrete
{
    public class Address
    {
        public Address()
        {

        }
        public Address(string street, string locality, string city, string zipCode)
        {
            Street = street;
            Locality = locality;
            City = city;
            ZipCode = zipCode;
        }

        public int Id { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public int UserId { get; set; }
    }
}
