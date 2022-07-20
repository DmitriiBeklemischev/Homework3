// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

string getPal(string number)
{
    if (number[0] == number[4] & number[1] == number[3]) return "-> Да";
    if (number[0] != number[4] & number[1] != number[3]) return "-> Нет";
    return "";
 
}

Console.WriteLine("Введите пятизначное число:");
string num = Console.ReadLine(); 
int length = num.Length;  
if ( length == 5 )
{
  Console.WriteLine(num + getPal(num));  
}
else
{
   Console.WriteLine("Число не является пятизначным!"); 
}    
  

