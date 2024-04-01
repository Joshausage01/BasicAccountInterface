/*
    NAME: CRISOSTOMO, JOSHUA B.
    COURSE/SECTION: BSCPE 1-1
*/
using System;
public class BasicAccountInterface
{
    static void Main(String[] args)
    {
        string realUsername = "Admin", realPassword = "Admin1234!";
        int totalLogIns = 4;
        
        while (totalLogIns > 0)
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (username == realUsername && password == realPassword)
            {
                Console.WriteLine("\nAccount log-in successful.");
                break;
            }
            else
            {
                totalLogIns--;
                if (totalLogIns > 0)
                {
                    Console.WriteLine("Incorrect credentials. Please try again!");
                    Console.WriteLine("\nNumber of Log-in attempt/s left: " + totalLogIns);
                }
                else
                {
                    Console.WriteLine("The username or the password is incorrect.");
                    Console.WriteLine("\nToo many unsuccessful Log-in attempts. Account Locked.");
                    break;
                }
            }
        }
    }
}
