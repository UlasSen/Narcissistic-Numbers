internal class Program
{
    private static void Main(string[] args)
    {
        Narcissistic(375);
    }

    public static void Narcissistic(int x)
    {
        int temp = x;
        Double result = 0;
        while (temp > 0)
        {
            result += Math.Pow(temp % 10, 3);
            
            temp = temp / 10;
            

        }
        if (result == x) {
            Console.WriteLine(x + " is a narcissistic number.");
                
        }
        else { Console.WriteLine(x + " is not a narcissistic number."); }
        
    }
}