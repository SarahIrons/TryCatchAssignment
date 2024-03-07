using System;
using System.Runtime.Serialization;

namespace TryCatchAssignment
{       //TRY/CATCH ASSIGNMENT

    //Perform these actions and create a console app that includes the following:


    //Ask the user for their age.

    //Display the year the user was born.

    //Exceptions must be handled using “try/catch.”

    //Display appropriate error messages if the user enters zero or negative numbers.

    //Display a general message if an exception was caused by anything else.
    class Program
    {

      static void Main()

        {
            int yearOfBirth; //declare integer year of birth
            DateTime dateTime = DateTime.Now;// set current date/time
            Console.WriteLine("Today's date + time is: " + dateTime);
            Console.WriteLine("Please enter your age: ");
            string input = Console.ReadLine();
            int number;//declare int for number to be used (conversion in operation for age)
          

            try
            {
                // Convert user input to an integer 
                number = Convert.ToInt32(input);
                if (number == 0)//"if" statement followed by "throw exception" if the condition is met
                    throw new EnteredZeroException();//this is an exception that I created + assigned to this file
                if (number < 0)
                    throw new NegativeNumberException();//this is the 2nd exception that I created and assigned to this file
        
                yearOfBirth = dateTime.Year - number;
                Console.WriteLine("You were born in or around the year " + yearOfBirth);//this is worded to account for span of time /difference that can occur between age/calendar year. the homework problem asked for year of birth but this would vary of user's exact age depending on what month they are born. 


            }
            //catch (FormatException)**this was my original code but did not account for "catch-all as the assignment asked for. So instead I commented-out the Format + Overflow exceptions. 
            //{
            //    // Catch block for handling FormatException when non-integer input is entered
            //    Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            //}
            //catch (OverflowException)
            //{
            //    // Catch block for handling OverflowException when the entered value is outside the range of Int32
            //    Console.WriteLine("Error: The value entered is not identified as a valid number in range--enter your age please.");
            //}

            catch (EnteredZeroException)
            {
                Console.WriteLine("You must be a Baby Genius if you are under one year old--hahah.");
            }
            catch (NegativeNumberException)
            { 
                Console.WriteLine("Please enter a positive number, instead of a negative number here.");
            }
            catch(Exception)
            {
                Console.WriteLine("Ope. Error detected--Please try again.");
            }
        }
    }
    //below is the code generated when creating a new specialized Exception(s)
    [Serializable]
    class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
        }

        public NegativeNumberException(string message) : base(message)
        {
        }

        public NegativeNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    class EnteredZeroException : Exception
    {
        public EnteredZeroException()
        {
        }

        public EnteredZeroException(string message) : base(message)
        {
        }

        public EnteredZeroException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EnteredZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}









