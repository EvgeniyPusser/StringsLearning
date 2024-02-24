using System.Runtime.InteropServices;

char[,] arrayChar =  {
  {'t', '@', 'p'},
  {'h', '^', 'k'},
  {'q', 'f','z'}
  };


   string NewOne = "";
  foreach(char t in arrayChar){
  NewOne += t + " ";}

 

Console.Write(NewOne);

//Console.Write(string.Join("   ",arrayChar));

