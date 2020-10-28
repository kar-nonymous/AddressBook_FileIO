// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Contacts.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kumar Kartikeya"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_IOFile
{
    /// <summary>
    /// Contacts class to enter different personal information of the user
    /// </summary>
    public class Contacts
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phnNo { get; set; }
        public string email { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Contacts"/> class.
        /// </summary>
        public Contacts()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            this.firstName = firstName;

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            this.lastName = lastName;

            Console.WriteLine("Enter address");
            string address = Console.ReadLine();
            this.address = address;

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();
            this.city = city;

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            this.state = state;

            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            this.email = email;

            Console.WriteLine("Enter zip");
            string zip = Console.ReadLine();
            this.zip = zip;

            Console.WriteLine("Enter phone number");
            string phnNo = Console.ReadLine();
            this.phnNo = phnNo;
        }
    }
}