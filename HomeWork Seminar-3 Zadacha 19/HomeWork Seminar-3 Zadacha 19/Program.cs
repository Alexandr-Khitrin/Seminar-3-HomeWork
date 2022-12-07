Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string palindrome = number.ToString();

if(palindrome[0] == palindrome[4] && palindrome[1] == palindrome[3])
{
    Console.WriteLine($"Число {number} является полиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является полиндромом");
}