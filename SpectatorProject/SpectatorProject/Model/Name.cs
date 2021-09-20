using System;
using System.Collections.Generic;
using System.Text;

namespace SpectatorProject.Model
{
    /// <summary>
    /// Státusz enum
    /// </summary>
    enum Status
    {
        Inactive,
        Active,
        Expired
    }
    /// <summary>
    /// Név osztály
    /// </summary>
    class Name
    {
        private string firstName;
        private string lastName;

        public Name(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string Fullname
        {
            get
            {
                return lastName + " " + firstName;
            }
        }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }

        //ToString metódus
        public override string ToString()
        {
            return "Néző neve: " + Fullname;
        }
    }

        
    }
