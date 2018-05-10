using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    /// <summary>
    /// Class Customer 
    /// A class to create a new customer.
    /// For a better overview, the class is divided into individual regions.
    /// The methods are described in more detail in the individual regions.
    /// </summary>
    public class Customer
    {
        #region Membervariables
        private string Name;
        private string Surname;
        private string Mail;
        private double Balance;
        private DateTime LastChange;
        private int CustomerNr;
        #endregion

        #region Constructor
        public Customer(string name, string surname, string mail, double balance, int customerNr, DateTime lastChange)
        {
            NAME = name;
            SURNAME = surname;
            MAIL = mail;
            BALANCE = balance;
            LastChange = lastChange;
            CustomerNr = customerNr;
        }
        #endregion

        #region Properties
        public string NAME
        {
            get
            {
                return this.Name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new FormatException("Name is null, empty or white space.");
                if (!Regex.IsMatch(value, @"^[a-zA-Z]+$")) throw new FormatException("Only letters of the alphabet allowed for name."); ;

                Name = value;
            }
        }

        public string SURNAME
        {
            get
            {
                return Surname;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new FormatException("Surname is null, empty or white space.");
                if (!Regex.IsMatch(value, @"^[a-zA-Z]+$")) throw new FormatException("Only letters of the alphabet allowed for surname."); ;

                Surname = value;
            }
        }

        public string MAIL
        {
            get
            {
                return Mail;
            }

            private set
            {
                if (!Regex.IsMatch(value,@"^[a-zA-Z0-9.#%&'*+/=?^`{|}!@~$_-]+$")) throw new FormatException("Mail contains invalid symbol(s).");
                if (new Regex(@"@").Matches(value).Count != 1) throw new FormatException("Mail must contain exactly one @.");
                if (!value.Split('@')[1].Contains('.')) throw new FormatException("Mail must have at least one . after the @.");
                if (value.Split('@')[0].Length < 1) throw new FormatException("There must be at least one character before the @.");
                string[] mailSplit = value.Split('@')[1].Split('.');
                if (mailSplit[mailSplit.Length - 1].Length < 2 || mailSplit[mailSplit.Length - 1].Length > 4) throw new FormatException("The part after the final . must be 2‐4 characters long and contain only letters.");

                Mail = value;
            }
        }

        public double BALANCE
        {
            get
            {
                return Balance;
            }

            private set
            {
                if (value < double.MinValue || value > double.MaxValue) throw new ArgumentOutOfRangeException("Balance must be a valid value");
                Balance = value;
            }
        }
        public int CUSTOMERNR
        {
            get
            {
                return CustomerNr;
            }
        }

        public DateTime LASTCHANGE
        {
            get
            {
                return LastChange;
            }
        }
        #endregion

        #region PublicMethods
        public void AddMoney(double amount)
        {
            if (Balance + amount > Double.MaxValue) throw new InvalidOperationException("Impossible transaction. Proof amount.");
            Balance += amount;
            LastChange = DateTime.Today;
        }

        public void PayMoney(double amount)
        {
            if (Balance - amount < Double.MinValue) throw new InvalidOperationException("Impossible transaction. Proof amount.");
            Balance -= amount;
            LastChange = DateTime.Today;
        }

        public void ChangeSurname(string changedSurname)
        {
            SURNAME = changedSurname;
        }

        public void ChangeMail(string changedMail)
        {
            MAIL = changedMail;
        }

        public override string ToString()
        {
            return Name + ";" + Surname + ";" + Mail + ";" + Balance + ";" + CustomerNr + ";" + LastChange.ToShortDateString();
        }
        #endregion
    }
}
