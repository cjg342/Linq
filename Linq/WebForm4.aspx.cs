using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] countries = { "India", "USA", "UK" };

            int minCount = countries.Min(x => x.Length);
            int maxCount = countries.Max(x => x.Length);

            TextBox1.Text=("The shortest country name has {0} characters in its name "+ minCount);
            TextBox2.Text=("The longest country name has {0} characters in its name "+ maxCount);


            ////More examples
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int smallestNumber = Numbers.Min();
            //int smallestEvenNumber = Numbers.Where(n => n % 2 == 0).Min();

            //int largestNumber = Numbers.Max();
            //int largestEvenNumber = Numbers.Where(n => n % 2 == 0).Max();

            //int sumOfAllNumbers = Numbers.Sum();
            //int sumOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Sum();

            //int countOfAllNumbers = Numbers.Count();
            //int countOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Count();

            //double averageOfAllNumbers = Numbers.Average();
            //double averageOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Average();

            //Console.WriteLine("Smallest Number = " + smallestNumber);
            //Console.WriteLine("Smallest Even Number = " + smallestEvenNumber);

            //Console.WriteLine("Largest Number = " + largestNumber);
            //Console.WriteLine("Largest Even Number = " + largestEvenNumber);

            //Console.WriteLine("Sum of All Numbers = " + sumOfAllNumbers);
            //Console.WriteLine("Sum of All Even Numbers = " + sumOfAllEvenNumbers);

            //Console.WriteLine("Count of All Numbers = " + countOfAllNumbers);
            //Console.WriteLine("Count of All Even Numbers = " + countOfAllEvenNumbers);

            //Console.WriteLine("Average of All Numbers = " + averageOfAllNumbers);
            //Console.WriteLine("Average of All Even Numbers = " + averageOfAllEvenNumbers);









        }
    }
}