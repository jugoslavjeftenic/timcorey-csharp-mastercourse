

// Build a Console Guest Book.
// Ask the user for their name and how many are in their party.
// Keep track of how many people are at the party.
// At the end, print out the guest list and the total number of guests.

using T10_HomeworkGuestBook;

Dictionary<string, int> guestList = new();

Console.WriteLine("Welcome to Guest Book Application.");

do
{
    var (guestName, numberOfPartyMembers) = HelperMethods.GetGuestNameAndNumberOfPartyMembers();
    guestList.Add(guestName, numberOfPartyMembers);

    if (HelperMethods.AddAnotherGuest() == false)
    {
        break;
    }
} while (true);

Console.WriteLine("--------------------------------------");
HelperMethods.PrintGuestList(guestList);

Console.WriteLine("--------------------------------------");
Console.WriteLine($"Total number of guests: {HelperMethods.TotalNumberOfGuests(guestList)}.");
