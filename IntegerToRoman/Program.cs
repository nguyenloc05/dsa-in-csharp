

class IntegerToRoman
{
    static void Main()
    {
        int x = 16;
        string result = "";
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] romans = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };



        for (int i = 0; i < values.Length; i++)
        {
           while(x>=values[i])
            {
                result += romans[i];
                x -= values[i];
            }

        }
        Console.WriteLine(result);
    }
}