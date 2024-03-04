// Login Scripts For Trevor Smith. 
// The login scripts should use what we have learnt from the week beginning 26th Feb to 1st March.


using System;
using System.Collections.Generic;

class Program
{
        // This code is a dictionary to store username-password pairs for members.
    static Dictionary<string, string> members = new Dictionary<string, string>();

        // This states the main entry point of the program.
    static void Main()
    {
        // Displays a welcome message.
        Console.WriteLine("Welcome to the Simple Login System!");

        // Performs user login.
        Login();

        // Displays the main menu.
        DisplayMenu();
    }

        // This is a function to handle user login.
    static void Login()
    {
        string username, password;

        // Keep prompting the user until valid username and password are provided.
        
        do
        {
            Console.Write("Enter username: ");
            username = Console.ReadLine();

            Console.Write("Enter password: ");
            password = Console.ReadLine();

        // Check if either username or password is empty, and prompt the user to try again.
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Username and password cannot be empty. Please try again.");
            }

        } while (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password));

        // Simulate authentication by storing the credentials in the 'members' dictionary.

        members[username] = password;
        Console.WriteLine("Login successful!\n");
    }

        // This function is used to display the main menu and handle user choices.
    static void DisplayMenu()
    {
        while (true)
        {
            // Displays the menu options.

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new member");
            Console.WriteLine("2. View members");
            Console.WriteLine("3. Output the menu");
            Console.WriteLine("4. Exit");

            // Prompts the user to choose an option.

            Console.Write("Choose an option (1-4): ");
            string option = Console.ReadLine();

            // Switch statement to handle different menu options
            switch (option)
            {
                case "1":
                    // Call function to create a new member.
                    CreateNewMember();
                    break;

                case "2":
                    // Call function to view members.
                    ViewMembers();
                    break;

                case "3":
                    // Output the menu.
                    break;

                case "4":
                    // Exit the program.
                    Environment.Exit(0);
                    break;

                default:
                    // Display an error message for invalid options.
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

            // Function to create a new member.
    static void CreateNewMember()
    {
        Console.Write("Enter new username: ");
        string newUsername = Console.ReadLine();

        Console.Write("Enter new password: ");
        string newPassword = Console.ReadLine();

        // Simulate adding the new member, by storing the credentials in the 'members' dictionary.
        members[newUsername] = newPassword;
        Console.WriteLine($"Member '{newUsername}' created successfully!\n");
    }

            // Function to view existing members.
    static void ViewMembers()
    {
            // Display a list of existing members along with their usernames and passwords.
        Console.WriteLine("Members:");

        foreach (var member in members)
        {
            Console.WriteLine($"Username: {member.Key}, Password: {member.Value}");
        }

        Console.WriteLine();
    }
}

// I could not work out the part above so I left it but the option is there which returns no outputted value. 
