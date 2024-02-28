// string? gaga = "Gegoal";
// string? vowels = "aeuioy";
// foreach(char t in vowels){
// if(gaga.Contains(t)){
//     Console.Write("yes\t");
// }}

using System.Runtime.InteropServices;

string news = " To&get&to know smth you need to come";
var array = news.Split("&");
// foreach(string y in array)
// Console.Write(y + "\t");
Console.Write(string.Join("**", array));
