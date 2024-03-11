using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[]args)
    {
    
      int decimalNumber = 56;
    Console.WriteLine("Decimal Integer literal:" +decimalNumber);
    
      int binaryNumber = 0b111000;
    Console.WriteLine("Binary Integer literal:" +binaryNumber);
    
      int octalNumber = 056;
    Console.WriteLine("Octal Integer literal:" +octalNumber);
    
      int hexadecimalNumber = 0x38;
    Console.WriteLine("Hexadecimal Integer literal:" +hexadecimalNumber);
    
      int bigNumber = 56;
    Console.WriteLine("Integer with Underscore:" +bigNumber);
    
      uint unsignedNumber = 56u;
      long longValue = 56L;
      ulong unsignedLong = 56UL;
      
     Console.WriteLine("Unsigned Int Integer literal:" +unsignedNumber);
     Console.WriteLine("Long literal:" +longValue);
     Console.WriteLine("Unsigned Long Integer literal:" +unsignedLong);
      
if (decimalNumber == 56 &&
                binaryNumber == 56 &&
                octalNumber == 56 &&
                hexadecimalNumber == 56 &&
                unsignedNumber == 56 &&
                longValue == 56 &&
                unsignedLong == 56 &&
                bigNumber == 56)
                {
                    Console.WriteLine("All representatives are correct");
                }

        else if (decimalNumber < 56 ||
                    binaryNumber < 56 ||
                    octalNumber < 56 ||
                    hexadecimalNumber < 56 ||
                    unsignedNumber < 56 ||
                    longValue < 56 ||
                    unsignedLong < 56 ||
                    bigNumber < 56)
                {
                    Console.WriteLine("All representatives are correct");
                }
                
        else
        {
            Console.WriteLine("All representatives are incorrect");
        }
    
    }
  }
}