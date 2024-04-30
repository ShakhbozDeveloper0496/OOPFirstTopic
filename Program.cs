using System;
using OOPFirstTopic;
using OOPFirstTopic.Classes;

System.Console.WriteLine("Kitob nomini kiriting: ");
System.Console.WriteLine("1. Merosxo'r! "); //robert luis
System.Console.WriteLine("2. Nigoh "); //Xurshid do'stmatov
System.Console.WriteLine("3. Somon yo'li "); //Chiniz Aytmatov
string name = Console.ReadLine();
int bookyear;
string bookauthor;

Books books= new Books(bookName: name, year: bookyear= 2020);

books.FirstBook();
