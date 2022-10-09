using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI.WebControls;

namespace WCFAssignment1Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        /// <summary>
        /// The function is used to check whether the integer is prime.
        /// </summary>
        /// <param name="number">The integer need to be checked. </param>
        /// <returns>The result message to show if it is prime. </returns>
        public string CheckPrime(int number)
        {
            string isPrime = "prime number";
            string notPrime = "not prime number";

            if (number == 2 || number == 3)
                return isPrime;

            if (number <= 1 || number % 2 == 0 || number % 3 == 0)
                return notPrime;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return notPrime;
            }
            return isPrime;            
        }

        /// <summary>
        /// The function is used to add to calculate the sum of all the digits
        /// </summary>
        /// <param name="number">The number need to be calculated. </param>
        /// <returns>The sum of all the digits. </returns>
        public int SumDigits(int number)
        {
            int sum = 0;
            foreach(char c in number.ToString())
            {
                sum += int.Parse(c.ToString());
            }
            return sum;
        }

        /// <summary>
        /// The function is used to reverse a string
        /// </summary>
        /// <param name="word">The string need to be reversed. </param>
        /// <returns>A reversed string. </returns>
        public string ReverseString(string word)
        {
            string newWord = "";
            for(int i = word.Length - 1; i >= 0; i--)
            {
                newWord+=word[i];
            }
            return newWord;
        }

        /// <summary>
        /// The function is used to to print HTML tags
        /// </summary>
        /// <param name="tag">The HTML tag. </param>
        /// <param name="data">The data. </param>
        /// <returns>A data surrounded with HTML tag. </returns>
        public string PrintHTMLTag(string tag, string data)
        {
            return string.Format("<{0}>{1}</{0}>", tag, data);
        }

        /// <summary>
        /// The function is used to sort 5 numbers
        /// </summary>
        /// <param name="sort">The sort type. </param>
        /// <param name="numbers">A string contains 5 numbers. </param>
        /// <returns>A sorted array and convert it to string. </returns>
        public string SortNumbers(string sort, string numbers)
        {
            try
            {
                int[] intArray = Array.ConvertAll(numbers.Split(','), x => int.Parse(x));
                Array.Sort(intArray);
                if (sort == "Ascending")
                {
                    return string.Join(",", intArray);
                }
                else if (sort == "Descending")
                {
                    Array.Reverse(intArray);
                    return string.Join(",", intArray);
                }
                return "--Please enter a valid sort type.--\n";
            }
            catch
            {
                return "--Please enter a valid integer array.--\n";
            }
            
        }     
        
    }
}
