// string LatinUpper = "New things Get Better";
// Console.Write(LatinUpper.ToLower());

string IsPalindrom = "ootreatiaertoo";
bool verify = true;
for( int i = 0; i < IsPalindrom.Length / 2; i++)
{
    if(IsPalindrom[i]== IsPalindrom[IsPalindrom.Length - i -1])
    {
        verify = verify && true;
       
    }
    else
    {
         verify = verify && false;   
    }

        
} 
    if(verify)
{Console.Write("It's palindrom");
}
else
{
    Console.Write("No");}


