﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo9p7 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Entrer le message à crypter: ");

      string message = Console.ReadLine();
      char[] msgChars = new char[message.Length];
 
      Console.Write("entrer le decalage: ");
      UInt16 decalage = Convert.ToUInt16(Console.ReadLine());



      char Monchar;
      for(int i = 0; i < message.Length; i++) {
        Monchar = message[i];
        msgChars[i] = (char)(Monchar + decalage);
      }

      Console.WriteLine("-------------------------------");
      Console.WriteLine(message);
      
      Console.WriteLine(msgChars);
 
    }
  }
}
