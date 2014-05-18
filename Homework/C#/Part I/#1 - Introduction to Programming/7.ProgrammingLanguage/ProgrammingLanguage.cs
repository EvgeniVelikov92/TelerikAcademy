// Provide a short list with information about the most popular programming languages. How do they differ from C#?

using System;

namespace ProgrammingLanguage
{
    class ProgrammingLanguage
    {
        static void Main(string[] args)
        {
            int langualge;

            Console.WriteLine("Моля изберете език от менюто. ");
            Console.WriteLine();
            Console.WriteLine("   ----1. JavaScript --------");
            Console.WriteLine("   ----2. Java --------------");
            Console.WriteLine("   ----3. C# ----------------");
            Console.WriteLine("   ----4. C++ ---------------");
            Console.WriteLine();
            Console.Write("Please enter a number 1-4: ");

            langualge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (langualge)
            {
                case 1:
                    {
                        Console.WriteLine("JavaScript (JS) is a dynamic computer programming language. It is most commonly used as part of web browsers, whose implementations allow client-side scripts to interact with the user, control the browser, communicate asynchronously, and alter the document content that is displayed. It has also become common in server-side programming, game development and the creation of desktop applications.");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Java is a computer programming language that is concurrent, class-based, object-oriented, and specifically designed to have as few implementation dependencies as possible. It is intended to let application developers write once, run anywhere (WORA), meaning that code that runs on one platform does not need to be recompiled to run on another. Java applications are typically compiled to bytecode (class file) that can run on any Java virtual machine (JVM) regardless of computer architecture.");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("C# (pronounced see sharp) is a multi-paradigm programming language encompassing strong typing, imperative, declarative, functional, procedural, generic, object-oriented (class-based), and component-oriented programming disciplines. It was developed by Microsoft within its .NET initiative and later approved as a standard by Ecma (ECMA-334) and ISO (ISO/IEC 23270:2006). C♯ is one of the programming languages designed for the Common Language Infrastructure.");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("C++ is one of the most popular programming languages and is implemented on a wide variety of hardware and operating system platforms. As an efficient performance driven programming language it is used in systems software, application software, device drivers, embedded software, high-performance server and client applications, and entertainment software such as video games. Several groups provide both free and proprietary C++ compiler software, including the GNU Project, LLVM, Microsoft and Intel. C++ has greatly influenced many other popular programming languages, most notably C# and Java.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error!");
                        break;
                    }
            }
        }
    }
}
