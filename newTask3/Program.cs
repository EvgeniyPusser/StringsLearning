string ForTransform = "Hi my heart baby I love you";
string[] array = ForTransform.Split(" ");
string [] newArray = new string[array.Length];
for(int i =0; i < array.Length; i++){
    newArray[i] = array[array.Length -i -1];
}
Console.Write(string.Join(" ", newArray));
Console.Write("\n");