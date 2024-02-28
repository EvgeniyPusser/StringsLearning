// string s5 = "Printing backwards";
// //for(int i = 0; i < s5.Length; i++){

//     //Console.Write(s5[s5.Length - i -1]);}

//     Console.Write(s5[3]);


// char[] ch_array = {'j', 's', '4', 'u', 'q'};
// string str2 = new String (ch_array);
//Console.Write(str2.Contains('4'));
//Console.Write(str2.EndsWith("uq"));
// Console.Write(str2.IndexOf('4'));
// Console.Write(str2.Insert(3, "yuyu"));
//Console.Write(str2.Replace("js", "OOO"));
// Console.Write(str2);

// string GetLettersFromString(string s)
// {

//     string Letters = "";
//     foreach (char e in s)
//     {

//         if (char.IsAsciiLetter(e))
//         {

//             Letters = Letters + e;
//         }
//     }
//     return Letters;
// }


// Console.Write("Write something");
// string str = Console.ReadLine();
// string result = GetLettersFromString(str);
// Console.Write(result);


using System.Xml.Serialization;

string GetDigitsFromString(string s)
{
    
    string Digits = "";
    //int count = 0;
    foreach (char e in s)
    {

        if (char.IsAsciiDigit(e))
        {

            Digits = Digits + e;
            //count++;
        }
    }
    return Digits;
    
}

int[] GenerateArray(int result, int count){

    int[] array = new int [count];
    for(int i =0; i < count; i++) {
       array[i] = result % 10;
       result = result /10;
    }return array;
}

void PrintArray(int[] array){
     for(int i =0; i < array.Length; i++){
    Console.Write(array[i] + ",");
 }

}


Console.Write("Write something");
string str = Console.ReadLine();

string result = GetDigitsFromString(str);
int count = result.Length;
Console.Write(count);
int dig_result = Convert.ToInt32(result);
Console.Write(result);
//Console.Write(count);

// Console.Write(result + 11);
 int[]array = GenerateArray(dig_result, count);
Console.Write("\n");
PrintArray(array);