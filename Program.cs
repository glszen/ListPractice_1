using System;
using System.Collections.Generic;

List<string> guests = new List<string>(); //Create a new list of string type

guests.Add("1 - Bülent Ersoy"); //Add values into the list
guests.Add("2 - Ajda Pekkan");
guests.Add("3 - Ebru Gündeş");
guests.Add("4 - Hadise");
guests.Add("5- Hande Yener");
guests.Add("6 - Tarkan");
guests.Add("7 - Funda Arar");
guests.Add("8 - Demet Akalın");

Console.WriteLine("** Guests **\n");

foreach (string g in guests) //Values ​​in the list are listed with foreach
{
    Console.WriteLine(g);
}

Console.ReadKey();