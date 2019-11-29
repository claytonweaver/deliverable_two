using System;
using System.Text;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.Write("Enter your message you would like to be encoded. ");
        var input = Console.ReadLine().ToUpper();
        var checksum = 0;
        var message = "Your encoded message is ";
        var asciiBytes = Encoding.ASCII.GetBytes(input);

        foreach (var b in asciiBytes)
        {
            var c = b - 64;
            var eachNumber = $"{b - 64}- ";
            message += eachNumber;
            checksum += c;
        }
        Console.WriteLine(message);
        Console.WriteLine("Message checksum is " + checksum);
    }
}