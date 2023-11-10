using System;  // Import the System namespace for basic C# functionality.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Class
{
    class Mobile
    {
        // Properties to store mobile information.
        public string mobileOwnerName { get; set; }
        public string mobileNumber { get; set; }
        public string mobileBalance { get; set; }
        public string mobileOSName { get; set; }
        bool mobileLock;  // Boolean flag to indicate whether the phone is locked (true) or unlocked (false).

        // Default constructor for the Mobile class.
        public Mobile() { }

        // Parameterized constructor to initialize mobile information.
        public Mobile(string OwnerName, string Number, string Balance, string OS)
        {
            mobileOwnerName = OwnerName;
            mobileNumber = Number;
            mobileBalance = Balance;
            mobileOSName = OS;
            mobileLock = false; // Phone is initially unlocked.
        }

        // Method to display the mobile information.
        public void showInfo()
        {
            Console.WriteLine($"Name: {mobileOwnerName}");
            Console.WriteLine($"Number: {mobileNumber}");
            Console.WriteLine($"Balance: {mobileBalance}");
            Console.WriteLine($"OS Name: {mobileOSName}");
        }

        // Method to recharge the mobile balance with a specified amount.
        public void recharge(int amount)
        {
            if (!mobileLock)
            {
                int currentBalance = Convert.ToInt32(mobileBalance);
                currentBalance += amount;
                mobileBalance = currentBalance.ToString();
                Console.WriteLine($"Recharged {amount} Taka, and now Balance is {mobileBalance}");
            }
        }

        // Method to make a call with a specified time duration.
        public void CallSomeone(int timeDuration)
        {
            if (!mobileLock)
            {
                // Per-minute call cost is 1 Taka.
                int cost = timeDuration;
                if (Convert.ToInt32(mobileBalance) >= cost)
                {
                    mobileBalance = (Convert.ToInt32(mobileBalance) - cost).ToString();
                    Console.WriteLine($"Call duration: {timeDuration} minutes. Balance after the call: {mobileBalance}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance to make the call.");
                }
            }
        }

        // Entry point of the program.
        static void Main(string[] args)
        {
            // Create a Mobile object with initial values.
            Mobile M = new Mobile("Yash", "0178", "100", "MIUI");
            M.showInfo();  // Display mobile information.

            // Unlock the phone and perform actions.
            M.mobileLock = false;

            M.recharge(50);
            M.CallSomeone(10);

            // Lock the phone and attempt actions.
            M.mobileLock = true;

            M.recharge(30);
            M.CallSomeone(5);

            Console.ReadLine();  // Pause the program to view the results.
        }
    }
}
