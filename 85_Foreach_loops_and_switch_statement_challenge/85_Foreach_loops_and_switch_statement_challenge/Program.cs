/*
 * Foreach Loops and Switch Statement challenge
Create an application that takes 2 input values.

Any input value (1st input)

Asks the data type of the input value. (2nd input)

It will print to the console the options like below to take input for the 2nd input value:

Press 1 for String

Press 2 for integer

Press 3 for Boolean

If the input value for the 2nd input is 1 then the application should check that if the entered 1st input is a valid string or not. Hereby we even want to check, if it is a complete alphabetic entry (so no numbers accepted)

If the input value for the 2nd input is 2 then the application should check if the entered 1st input is a valid integer or not.

Based on the input the 1st value and the selection of data type using the 2nd input, the application should return whether the entered 1st value is of data type selected by the user or not.

Please make sure to use a switch statement. To check the valid string you can write your custom logic.

For example:

Enter a value: {here you can enter any value}

Select the Data type to validate the input you have entered.

Press 1 for String

Press 2 for Integer

Press 3 for Boolean

Here, if you enter 1 it should return below message

You have entered a value: Denis Panjuta

It is a valid: String

Here, if you enter 2 it should return below message

You have entered a value: Denis Panjuta

It is an invalid: Integer



PS: You may want to check what is isLetter method in c# 🤫
 */

using System;

namespace _85_Foreach_loops_and_switch_statement_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            string inputValueType = String.Empty;

            Console.WriteLine("Enter a value: ");
            string input = Console.ReadLine();  
            Console.WriteLine("Select the Data type of the input value: \nPress1 for String\nPress2 for Integer\nPress3 for Boolean\n");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    valid = IsAllAlpha(input);
                    inputValueType = "String";
                    break;

                case 2:
                    int retValue = 0;
                    valid = int.TryParse(input, out retValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool retFlag = false;
                    valid = bool.TryParse(input, out retFlag);
                    inputValueType= "Boolean";
                    break;

                default:
                  
                    Console.WriteLine("Something is wrong.");
                    break;
            }
            Console.WriteLine("You have entered a value: {0}", inputType);
            if (valid)
            {
                Console.WriteLine("Its valid:{0}", inputValueType);
            }
            else
            {
                Console.WriteLine("Its invalid:{0}", inputValueType);
            }
            Console.ReadKey();
        }
        static bool IsAllAlpha(string value)
        {
            foreach (char c in value)
            { 
                if(!char.IsLetter(c))
                    return false;
            }
            return true;
        }
    }
}
