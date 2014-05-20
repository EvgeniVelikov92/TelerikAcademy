// Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

using System;

namespace CreateTriangle
{
    class CreateTriangle
    {
        static void Main()
        {
            string triangle;
            triangle = @"
                                             ©
                                            ©©©
                                           ©© ©©
                                          ©©   ©©
                                         ©©     ©©
                                        ©©       ©©
                                       ©©         ©©
                                      ©©           ©©
                                     ©©             ©©
                                    ©©               ©©
                                   ©©                 ©©
                                  ©©                   ©©
                                 ©©                     ©©
                                ©©                       ©©
                               ©©                         ©©
                              ©©                           ©©
                             ©©                             ©©
                            ©©                               ©©
                           ©©©©©©©©©©©©©©©©©©©©©©©©©©©©©©©©©©©©©
";
            Console.WriteLine(triangle);
        }
    }
}
