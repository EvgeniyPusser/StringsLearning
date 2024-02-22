// string? gaga = "Gegoal";
// string? vowels = "aeuioy";
// foreach(char t in vowels){
// if(gaga.Contains(t)){
//     Console.Write("yes\t");
// }}

string news = " To&get&to know smth you need to come";
var array = news.Split("&");
// foreach(string y in array)
// Console.Write(y + "\t");
// Console.Write(string.Join("**", array));
Console.Write(news.IndexOf("smth"));
Console.Write(news[7]);
Console.Write(array.GetType());