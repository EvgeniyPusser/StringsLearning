﻿void Main()
{
    string ForTransform = "Hi my heart baby I love you";
string[] array = ForTransform.Split(" ");
for(int i = 1; i < 3; i++){
   

    Console.Write($"{array[i]} _-");
}
Console.Write("   ");
string [] newArray = new string[array.Length];
for(int i =0; i < array.Length; i++){
    newArray[i] = array[array.Length -i -1];
}
Console.Write(string.Join("", newArray));
Console.Write("\n");

string Mama = string.Join("-MAMA-", array);
Console.Write(Mama);
}

Main();

