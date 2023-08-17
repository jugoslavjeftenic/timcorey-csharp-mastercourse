

// Create a welcome method, a method to ask for the user's name,
// and another to tell that user "Hello <name>".
// Call this methods from Program.cs.

using T09_08_HomeworkMethods;

UserMessages.Welcome();
Console.WriteLine(UserMessages.HelloUser(UserMessages.GetUserName()));
