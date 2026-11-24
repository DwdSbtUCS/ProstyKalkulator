# Dawid Sobota 78618
# Prosty kalkulator w Pyhon 
# OPIS: float(input(...)) pobiera dwie liczby od użytkownika (działa zarówno dla liczb całkowitych, jak i ułamków).

a = float(input("Podaj pierwszą liczbę: "))
b = float(input("Podaj drugą liczbę: "))

# input(...) pobiera znak wybranego działania.

operacja = input("Wybierz operację (+, -, *, /): ")

# Instrukcje if / elif sprawdzają, jaki znak został wpisany, wykonują odpowiednie działanie
# Print wyświetla wynik

if operacja == "+":
    print("Wynik:", a + b)
elif operacja == "-":
    print("Wynik:", a - b)
elif operacja == "*":
    print("Wynik:", a * b)
elif operacja == "/":
    if b == 0:
        print("Błąd: nie można dzielić przez zero!")
    else:
        print("Wynik:", a / b)
else:
    print("Nieprawidłowa operacja!")
