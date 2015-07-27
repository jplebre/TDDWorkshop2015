using System;

namespace FizzBuzz
{
	public class FizzBuzz
	{
        public static string Generate()
        {
            string output = "";

            for (int i = 1; i <= 100; i++)
            {
                bool testFizz = i % 3 == 0;
                bool testBuzz = i % 5 == 0;

                switch (true)
                {
                    case testFizz: 
                        output += "Fizz";
                    case testBuzz:
                        output += "Buzz";
                    default:
                        output += ",";
                }
                        
                        
                            
                if (i % 3 == 0)
                {
                    output += "Fizz";
                }
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }
                else
                    output += i.ToString();

                output += ",";
            }


            return output;
        }

	}
}

