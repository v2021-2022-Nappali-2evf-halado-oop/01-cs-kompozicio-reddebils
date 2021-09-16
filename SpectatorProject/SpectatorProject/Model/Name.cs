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
    }

        
    }
