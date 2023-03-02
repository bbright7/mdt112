

Console.Write(string.Format("Enter Agency: "));
string agency = Console.ReadLine();
Console.Write(string.Format("Enter password: "));
int password = Int32.Parse(Console.ReadLine()); // Replace with user input

if (agency == "CIA")
{

    int thousandsDigit = password / 1000;
    int tensDigit = (password / 10) % 10;
    int onesDigit = password % 10;

    if (onesDigit % 3 == 0 && tensDigit != 1 && tensDigit != 3 && tensDigit != 5
        && thousandsDigit >= 6 && thousandsDigit != 8)
    {
        Console.WriteLine(true);
    }
    else
    {
        Console.WriteLine(false);
    }
}
else if (agency == "FBI")
{
    int hurThousandsDigit = (password / 100000) % 10;
    int tenThousandsDigit = (password / 10000) % 10;
    int thousandsDigit = password / 1000;
    int hurDigit = (password / 100) % 10;
    int tensDigit = (password / 10) % 10;

    if (hurThousandsDigit >= 4 && hurThousandsDigit <= 7 && hurDigit % 2 == 0 && hurDigit != 6 && tenThousandsDigit % 2 != 0)
    {
        Console.WriteLine(true);
    }
    else
    {
        Console.WriteLine(false);
    }

} else if (agency == "NSA")
{
    bool isoneDigit = false;
    bool hasDigitSeven = false;
    bool ishun = false;
    int onesDigit = password % 10;
    for (int i = 0; i < 6; i++)
    {
        int digit = (password / (int)Math.Pow(10, i)) % 10;
        if (digit == 7)
        {
            hasDigitSeven = true;
        }
        if (digit == 0)
        {

        }
        if (30 % digit != 0)
        {

        } else
        {
            isoneDigit = true;
        }
    }

    int hundredsDigit = (password / 100) % 10;

    if (hundredsDigit % 3 == 0 && hundredsDigit % 2 != 0)
    {
        ishun = true;
    }

    if (isoneDigit && hasDigitSeven && ishun)
    {
        Console.WriteLine(true);
    } else
    {
        Console.WriteLine(false);
    }



} else
{
    Console.WriteLine("ไม่พบหน่วยงานดังกล่าว.");
}
Console.ReadKey();