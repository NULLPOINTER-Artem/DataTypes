using System;

namespace DataTypes
{
    /* This program describe all acceptable types in C# language 
        also how to  use it correct */

    class Program
    {
        static void Main(string[] args)
        {
            // C# has the following primitive data types:

            /* bool : (A logical variable)
             *      stores the value "true" or "false"
             *      takes from -> System.Boolean */
            bool isWorked = true; // or false

            /* byte : 
             *      stores an integer from 0 to 255 & takes 1 byte
             *      you can find it in System.Byte */
            byte a = 190;

            /* sbyte : 
             *        stores an integer from -128 to 127 & takes 1 byte 
             *        it located in System.SByte */
            sbyte b = 120;

            /* short : 
             *        stores an integer from -32768 to 32767 & takes 2 bytes
             *        you can get it from System.Int16 */
            short c = 32000;

            /* ushort : 
             *         stores an integer from 0 to 65535 & takes 2 bytes
             *         it located in System.UInt16 */
            ushort d = 45000;

            /* int :
             *      stores an integer from -2 147 483 648 to 2 147 483 647 & takes 4 bytes
             *      it located in System.Int32 
             *      All integer literals represent int values by default */
            int e = 2000000000;
            int f = 0b010; // binary system in int is 2;
            int g = 0xA; // hexadecimal system in int is 10;

            /* uint : 
             *       stores an integer from 0 to 4 294 967 295 & takes 4 bytes
             *       it located in System.UInt32 */
            uint h = 3500000000U;

            /* long :
             *       stores an integer from -9 223 372 036 854 775 808 to 9 223 372 036 854 775 807 & takes 8 bytes
             *       it located in System.Int64 */
            long i = -100000000000L;

            /* ulong :
             *        stores an integer from 0 to 18 446 744 073 709 551 615 & takes 8 bytes
             *        it located in System.UInt64 */
            ulong j = 1000000000000UL;

            /* float :
             *       stores a floating-point number from -3.4*10^38 to 3.4*10^38 & takes 4 bytes
             *       (^ is like pow() funtion())
             *       it located in System.Single */
            float k = 8.099F;

            /* double : 
             *         stores a floating-point number from (+/-)5.0*10^-324 to (+/-)1.7*10^308 & takes 8 bytes
             *         it located in System.Double */
            double l = -1000.09999D;

            /* decimal :
             *          stores the decimal fraction number and it ranges (-7.9 x 10^28 to 7.9 x 10^28) / 10^0 to 28 
             *          and takes 16 bytes 
             *          it located in System.Decimal */
            decimal m = -10000000.0222324M;

            /* char :
             *      stores a single character in Unicode encoding & takes 2 bytes
             *      it located in System.Char */
            char n = 'n';

            /* string :
             *         stores the Unicode character set
             *          it located in System.String */
            string word = "word";

            /* object :
             *         can stores the value of any data type and occupies 4 bytes on 32-bit platform and 8 bytes on 64-bit platform
             *         it located in System.Object, which is basic for all other .NET types and classes */
            object someObject = "Gogogo";
            object someNumber = 44422231.1231241M;

            // Using a suffix :

            // When you are assign a float literals it takes double type
            // if you want to use other type you have to add a suffix :
            // float - F/f
            // decimal - M/m
            // example :
            float o = 5.9F; // has float type and if you did not pointed a float variable with F/f it is a mistake
            decimal p = 434.12M;

            // In a similar way all a integer literals takes int type (int32)
            // uint - U/u
            // long - L/l
            // ulong - UL/ul
            uint q = 6U;
            long r = 333L;
            ulong s = 900UL;

            // Implicit typing
            var astringvar = "ff"; // string object
            var achar = 'f'; // char
            var number = 3.4; // double
            var variable = 1; // int32

            // Difference between explicit and implicit types is :

            int t;
            t = 50;
            // the code that represent above is worked!

            /*var u;
            u = 50;*/

            // the code that represent above has mistake with initialization also :

            /*var obj = null;*/

            // but you can :
            object someobj = null;
        }
    }
}