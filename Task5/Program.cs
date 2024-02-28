//  void Main()
//  {
//  Console.WriteLine("Введите любое целое число и нажмите Enter");
//     int a = int.Parse(Console.ReadLine());
//     Console.WriteLine($"Результат выполнения метода: {Addition(a)}. Значение переменной после выполнения метода: {a}");
//     Console.WriteLine($"Результат выполнения метода: {Addition1(ref a)}. Значение переменной после выполнения метода: {a}");

 


 
//  }


// static int Addition(int a)
// {
   
//    a++; 
//    return a;
// }
// static int Addition1(ref int a)
// {
//    a++; 
//    return a;
// }

// static int Addition(out int a)
// {
//     a = 67;//присвоили начальное значение
//     a++; //нарастил на 1
//     return a;
// }
//  void Main()
// {
//   int b;
//  // Console.WriteLine($"Результат выполнения метода: {Addition(out b)}. Значение переменной после выполнения метода: {b}");
//   Addition(out b);
//   Console.Write(b);
// }

//  Main();

static int Addition(out int a, int d = 1)
{
    a = 0;
    a += d;
    return a;
}
//В вызове метода мы можем не указывать параметр d и при его использовании в теле метода он будет равен 1:

void Main()
{
    Console.WriteLine($"Результат выполнения метода: {Addition(out int b, 7)}. Значение переменной после выполнения метода: {b}");
}
Main();

