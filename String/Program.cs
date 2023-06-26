// See https://aka.ms/new-conso,le-template for more information
string str1 = "Hello";
Console.WriteLine(str1);
Console.WriteLine(str1.GetHashCode());

str1="Hello to  all";
string str2 = "good evening";
Console.WriteLine(str1);
Console.WriteLine(str1.GetHashCode());

Console.WriteLine(str1.Length);
string str3 =String.Concat(str1,str2);
Console.WriteLine(str3);
Console.WriteLine(str3.IndexOf('o'));
Console.WriteLine(str3.LastIndexOf('o'));

string str4 = str3.Substring(9, 3);
Console.WriteLine(str4);
Console.WriteLine(string.IsNullOrEmpty(str4));

Console.WriteLine("Enter name");
string s=Console.ReadLine();
Console.WriteLine(string.IsNullOrEmpty(s));

char[]ch=str1.ToCharArray();
for(int i = 0; i < ch.Length; i++)
{
    Console.WriteLine(ch[i]);
}
