using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BankAccount
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            /*
             14. A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
             bank name, IBAN, BIC code and 3 credit card numbers associated with the account. 
             Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
             */


            Console.OutputEncoding = Encoding.Unicode;

            string holderName = "Ivan Ivanov Kolev";
            decimal balance = 13500300.56M;
            string bankName = "MYBANK";
            string iban = "BG62STSA93000017809629";
            string bicCode = "STSA9300";
            string firstCreditCart = "1111222233334444";  //ulong firstCreditCart -> as a number if this is the purpose
            string secondCreditCart = "2222333344445555"; //ulong secondCreditCart -> as a number if this is the purpose
            string thirdCreditCart = "3333444455556666";  //ulong thirdCreditCart  -> as a number if this is the purpose

            Console.WriteLine("Holder Name: {0}\nBalance:{1:C2}\nBank Name: {2}\nIBAN: {3}\nBIC code: {4}\nCredit Cards:\n{5}\n{6}\n{7}",
                holderName, balance, bankName, iban, bicCode, firstCreditCart, secondCreditCart, thirdCreditCart);
        }
    }
}
