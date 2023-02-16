using static System.Console;
using static System.Net.WebRequestMethods;

string str1 = "Hello world";
char[] chaArr = { 'H', 'e', 'l', 'l', 'o', ' ', 'w','o','r','l','d' };
string str2=new string(chaArr);
string str3 =new string(chaArr,5,6);
string str4 = new string('$',10);
WriteLine("str1:"+str1);
WriteLine("str2:"+str2);
WriteLine("str3:"+str3);
WriteLine("str4:"+str4);

string strPath1 = "C:\\Users\\User\\Pictures\\Camera Roll";
string strPath2 = @"C:\Users\User\Pictures\Camera Roll";
WriteLine(strPath1);
WriteLine(strPath2);

string str5 = "I ";
string str6 = "Learn ";
string str7 = "C#";
string str8=str5+ str6+str7;

WriteLine("{0}+{1}+{2}={3}",str5,str6,str7,str8);

str8 = str8.Replace("learn", "like");
WriteLine(str8.ToUpper());// Все буквы большие

str8 = str8.PadLeft(25, '*');//Заполняет звездочками до 25символа
str8=str8.PadRight(32, '*');//Заполняет после 32
WriteLine(str8);
str8=str8.TrimStart("*".ToCharArray());//уБИРАЕТ ОПРЕДЕЛЕННЫЙ СИМВОЛ
WriteLine(str8);

int number1 = 56, number2 = 78;

WriteLine("Число 1 равно{0}.Число 2 равно {1}",number1,number2);
WriteLine($"Число 1 равно{number1}.Число 2 равно{number2}");