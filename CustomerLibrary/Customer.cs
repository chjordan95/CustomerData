using System;
using System.Collections.Generic;
using System.Globalization;
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
                if (string.IsNullOrWhiteSpace(value)) throw new FormatException(Properties.Resources.nameNull);
                else if (!Regex.IsMatch(value, @"^[a-zA-Z]+$")) throw new FormatException(Properties.Resources.nameLetters); ;

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
                if (string.IsNullOrWhiteSpace(value)) throw new FormatException(Properties.Resources.surnameNull);
                else if (!Regex.IsMatch(value, @"^[a-zA-Z]+$")) throw new FormatException(Properties.Resources.surnameLetters); ;

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
                if (new Regex(@"@").Matches(value).Count != 1) throw new FormatException(Properties.Resources.mailExactAt);
                else if (value.StartsWith(".") || value.EndsWith(".")) throw new FormatException(Properties.Resources.mailDots);
                else if (value.Split('@')[0].EndsWith(".") || value.Split('@')[1].StartsWith(".")) throw new FormatException(Properties.Resources.mailDotsAt);
                else if (!Regex.IsMatch(value,@"^[a-zA-Z0-9.#%&'*+/=?^`{|}!@~$_-]+$")) throw new FormatException(Properties.Resources.mailSymbols);
                else if (!value.Split('@')[1].Contains('.')) throw new FormatException(Properties.Resources.mailOneDot);
                else if (value.Split('@')[0].Length < 1) throw new FormatException(Properties.Resources.mailCharakter);
                string[] mailSplit = value.Split('@')[1].Split('.');
                if (mailSplit[mailSplit.Length - 1].Length < 2 || mailSplit[mailSplit.Length - 1].Length > 4) throw new FormatException(Properties.Resources.mailLength);

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
                if (value < double.MinValue || value > double.MaxValue) throw new ArgumentOutOfRangeException(Properties.Resources.balance);
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
            if (Balance + amount > Double.MaxValue) throw new InvalidOperationException(Properties.Resources.amountImpossible);
            else if (amount < 0) throw new ArgumentException(Properties.Resources.amountPositive);
            Balance += amount;
            LastChange = DateTime.Today;
        }

        public void PayMoney(double amount)
        {
            if (Balance - amount < Double.MinValue) throw new InvalidOperationException(Properties.Resources.amountImpossible);
            else if (amount < 0) throw new ArgumentException(Properties.Resources.amountPositive);
            Balance -= amount;
            LastChange = DateTime.Today;
        }

        public void ChangeMail(string changedMail)
        {
            MAIL = changedMail;
        }
        public void ChangeSurname(string changedSurname)
        {
            SURNAME = changedSurname;
        }

        public override string ToString()
        {
            return Name + ";" + 
                Surname + ";" + 
                Mail + ";" 
                + Balance + ";" 
                + CustomerNr + ";" + 
                LastChange.ToString("yyyyMMdd",CultureInfo.InvariantCulture);
        }
        #endregion


    }
}
