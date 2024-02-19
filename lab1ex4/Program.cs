/*
 * Ex 4
Scrieti un program care va afisa semnul unui numar citit de la tastatura
• Daca numarul este pozitiv, va afisa “+”
• Daca numarul este negativ, va afisa “-”
• Daca numarul este 0, va afisa “0”
*/

Console.WriteLine("Introduceti un numar intreg, fie pozitiv, fie negativ: ");
int numarTastatura = int.Parse(Console.ReadLine());

if (numarTastatura > 0)
{
    Console.WriteLine("+");
}
else if (numarTastatura < 0)
{
    Console.WriteLine("-");
}
else
{
    Console.WriteLine("0");
}
