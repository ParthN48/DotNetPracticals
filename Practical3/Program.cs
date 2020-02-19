using System;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimalToBinary();
            decimalToHex();
            decimalToOctal();
            binaryToDecimal();
            Console.Read();
        }
        static void decimalToBinary()
        {
            int x = 16;
            int reminder,i=0;
            int[] binary = new int[100];
            Console.Write("Decimal To Binary Conversion:");
            while(x>0)
            {
                reminder = x % 2;
                binary[i] = reminder;
                x /= 2;
                i++;
            }
            for(int j = i-1; j>=0; j--)
            {
                Console.WriteLine(binary[j]);
            }

        }
        static void decimalToOctal()
        {
            int x = 16;
            Console.Write("Decimal To Octal Conversion:");
            int[] octalNum = new int[100];
            int i = 0;
            while (x != 0)
            {

                octalNum[i] = x % 8;
                x = x / 8;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.WriteLine(octalNum[j]);
            }
        }
        static void decimalToHex()
        {
            int x = 50;
            Console.Write("Decimal To Hex Conversion:");
            int reminder, i = 0;
            char[] hex = new char[100];
            while (x > 0)
            {
                reminder = x % 16;
                if(reminder > 9)
                {
                    hex[i] = (char)(reminder + 55);
                }
                else
                {
                    hex[i] = (char)(reminder + 48);
                }
                x /= 16;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.WriteLine(hex[j]);
            }


        }
        static void binaryToDecimal()
        {
            int binaryNumber = 10101;
            int  base1 = 1;
            int decimalValue = 0;
            Console.Write("Binary To Decimal Conversion:");
            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.WriteLine(decimalValue);
            Console.Read();
        }
    }
}
