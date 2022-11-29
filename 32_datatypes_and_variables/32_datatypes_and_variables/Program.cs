/*
 Challenge - Datatypes And Variables
Now that you know how to declare and initialize Variables, please go ahead and create a variable for each of the primitive datatypes (you can find the list here). Leave the Object datatype out.
And also please initialize each variable with a working value.
Then create two values of type string. 
The first one should say "I control text"

The second one should be a whole number. Then use the Parse method in order to convert that string to an integer.

Add each an output for each of the variables and write it onto the console. (WriteLine)
Feel free to name your variables as you like, but keep in mind, that my result's variable names will differ to yours.
Have fun :)
 */


using System;

namespace _32_datatypes_and_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte myByte;
            sbyte mySByte;
            int myInt;
            uint myUInt;
            short myInt16;
            ushort myUInt16;
            long myInt64;
            ulong myUInt64;
            float myFloat;
            double myDouble;
            char myChar;
            bool myBool;
            object myObj;
            string myStr;
            decimal myDecimal;

            myByte = 255;
            mySByte = -128;
            myInt = -2147483648;
            myUInt = 4294967295;
            myInt16 = -32768;
            myUInt16 = 65535;
            myInt64 = -9223372036854775808;
            myUInt64 = 18446744073709551615;
            myFloat = -3.402823e38f;
            myDouble = -0.79769313486232e308;
            myChar = 'A';
            myBool = false;
            myObj = new object();
            myStr = "I control my text";
            myDecimal = 0.4564654654654645654m;


            Console.WriteLine(myByte);
            Console.WriteLine(mySByte);
            Console.WriteLine(myInt);
            Console.WriteLine(myUInt);
            Console.WriteLine(myInt16);
            Console.WriteLine(myUInt16);
            Console.WriteLine(myInt64);
            Console.WriteLine(myUInt64);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myChar);
            Console.WriteLine(myBool);
            Console.WriteLine(myObj);
            Console.WriteLine(myStr);
            Console.WriteLine(myDecimal);
            Console.Read();





        }
    }
}
