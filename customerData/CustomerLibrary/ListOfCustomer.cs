using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace CustomerLibrary
{
    /// <summary>
    /// Class ListOfCustomer 
    /// Class ListOfCustomer inherits from the class List<> therefore no constructor is needed.
    /// For a better overview, the class is divided into individual regions.
    /// The methods are described in more detail in the individual regions.
    /// </summary>
    public class ListOfCustomer : List<Customer>
    {
        #region Variables
        private const int KEYSIZE = 256;
        private const string KEY = "pemgail9uzpgzl88";
        #endregion

        #region PrivateMethods

        /// <summary>
        /// ProofMail checks if a mail address has already been used for a customer.
        /// </summary>
        private bool ProofMail(string mail)
        {
            bool isExisting = false;
            foreach (Customer oneCustomer in this)
            {
                if (oneCustomer.MAIL == mail)
                {
                    isExisting = true;
                }
            }

            return isExisting;
        }

        /// <summary>
        /// ProofCustomerNr checks if a customer number has already been used for a customer.
        /// </summary>
        private bool ProofCustomerNr(int customerNr)
        {
            bool isExisting = false;
            foreach (Customer oneCustomer in this)
            {
                if (oneCustomer.CUSTOMERNR == customerNr)
                {
                    isExisting = true;
                }
            }

            return isExisting;
        }
        #endregion

        #region PublicMethods

        /// <summary>
        /// SaveToCSV is a method to encrypt the customer data and export it in a CSV file.
        /// </summary>
        public void SaveToCSV(string path)
        {
            FileStream fileStream = File.Open(path, FileMode.OpenOrCreate);
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(KEY);
            PasswordDeriveBytes password = new PasswordDeriveBytes("123", null);
            byte[] keyBytes = password.GetBytes(KEYSIZE / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            CryptoStream cryptoStream = new CryptoStream(fileStream, encryptor, CryptoStreamMode.Write);
            StreamWriter streamWriter = new StreamWriter(cryptoStream);

            foreach (Customer oneCustomer in this)
            {
                streamWriter.WriteLine(oneCustomer.ToString());
            }
            streamWriter.Close();
            fileStream.Close();
            cryptoStream.Close();
        }

        /// <summary>
        /// ImportCSV is a method to import a already saved CSV file and decrypt the data.
        /// </summary>
        public void ImportCSV(string path)
        {
            FileStream fileStream = File.Open(path, FileMode.Open);
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(KEY);
            PasswordDeriveBytes password = new PasswordDeriveBytes("123", null);
            byte[] keyBytes = password.GetBytes(KEYSIZE / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            CryptoStream cryptoStream = new CryptoStream(fileStream, decryptor, CryptoStreamMode.Read);
            StreamReader streamReader = new StreamReader(cryptoStream);

            while (streamReader.Peek() != -1)
            {
                string decryptedCustomer = streamReader.ReadLine();
                string[] splitCustomer = decryptedCustomer.Split(';');
                AddCustomer(new Customer(splitCustomer[0], splitCustomer[1], splitCustomer[2], Convert.ToDouble(splitCustomer[3]), Convert.ToInt32(splitCustomer[4]), Convert.ToDateTime(splitCustomer[5])));
            }

            streamReader.Close();
            fileStream.Close();
            cryptoStream.Close();
        }

        /// <summary>
        /// AddCustomer is a method to a add a new customer to the ListOfCustomer.
        /// Before a new customer is added the method checks if the mail address and the customer number 
        /// is unique. Otherwise an exception is thrown.
        /// </summary>
        public void AddCustomer(Customer newCustomer)
        {
            if (ProofMail(newCustomer.MAIL)) throw new Exception("This mail adress has already been used.");
            if (ProofCustomerNr(newCustomer.CUSTOMERNR)) throw new Exception("Customer Number has already been used.");
            this.Add(newCustomer);
        }
        #endregion
    }
}
