// Dawid Sobota 78618
// Prosty kalkulator w C#
// OPIS: Convert.ToDouble(Console.ReadLine()) pobiera dwie liczby od użytkownika (działa zarówno dla liczb całkowitych, jak i ułamków).

Console.Write("Podaj pierwszą liczbę: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj drugą liczbę: ");
double b = Convert.ToDouble(Console.ReadLine());

// Console.ReadLine() pobiera znak wybranego działania.

Console.Write("Wybierz operację (+, -, *, /): ");
string? operacja = Console.ReadLine();

// Instrukcje if / else if sprawdzają, jaki znak został wpisany, wykonują odpowiednie działanie
// Console.WriteLine wyświetla wynik

if (operacja == "+")
{
    Console.WriteLine("Wynik: " + (a + b));
}
else if (operacja == "-")
{
    Console.WriteLine("Wynik: " + (a - b));
}
else if (operacja == "*")
{
    Console.WriteLine("Wynik: " + (a * b));
}
else if (operacja == "/")
{
    if (b == 0)
    {
        Console.WriteLine("Błąd: nie można dzielić przez zero!");
    }
    else
    {
        Console.WriteLine("Wynik: " + (a / b));
    }
}
else
{
    Console.WriteLine("Nieprawidłowa operacja!");
}
