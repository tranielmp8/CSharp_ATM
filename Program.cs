
using ATM;

void printOptions()
{
    Console.WriteLine(@"Please choose from the following options:
1.) Deposit
2.) Withdraw
3.) Show Balance
4.) Exit

");

}
void deposit(CardHolder currentUser)
{
    Console.WriteLine("How much $$ wold you like to deposit?  ");
    double deposit = Double.Parse(Console.ReadLine());
    currentUser.Balance += deposit;
    Console.WriteLine("Thank you for your $$. your new balance is:  $" + currentUser.Balance);
    Console.WriteLine("");

}

void withdraw(CardHolder currentUser)
{
    Console.WriteLine("How much $$ would you like to withdraw: ");
    double withdrawal = Double.Parse(Console.ReadLine());
    // check if the user has enough money
    if(currentUser.Balance < withdrawal)
    {
        Console.WriteLine("Insufficient $balance$ :(");
        Console.WriteLine("");

    }
    else
    {
        currentUser.Balance = currentUser.Balance - withdrawal;
        Console.WriteLine("you have completed the withdrawal! THANK YOU! Current balance: $" + currentUser.Balance);
        Console.WriteLine("");

    }

}

void balance(CardHolder currentUser)
{
    Console.WriteLine("Current balance is:  $" + currentUser.Balance);
    Console.WriteLine("");
}

List<CardHolder> cardHolders = new List<CardHolder>();
cardHolders.Add(new CardHolder("4141111122223333", 1234, "Happy", "Guy", 1000.00));
cardHolders.Add(new CardHolder("5522999988887777", 5678, "Sad", "Guy", 10.00));
cardHolders.Add(new CardHolder("5432565623237878", 9009, "Cool", "Girl", 500.00));
cardHolders.Add(new CardHolder("6012989865653232", 8765, "Hot", "Girl", 700.00));
cardHolders.Add(new CardHolder("4020556633221144", 4321, "That", "Dude", 32.00));

//prompt user
Console.WriteLine("Welcome to the SimpleATM");
Console.WriteLine("please insert your debit card: ");
string debitCardNum = "";
CardHolder currentUser;

while (true)
{
    try
    {
        debitCardNum = Console.ReadLine();
        // check against our db
        currentUser = cardHolders.FirstOrDefault(a => a.CardNum == debitCardNum);
        if (currentUser != null) break;
        else Console.WriteLine("Card not recognied. Please try again");
    }
    catch
    {
        Console.WriteLine("Error. Please try again");
    }
}

while (true)
{
    Console.WriteLine("Please Enter your pin: ");
    int userPin = 0;

    try
    {
        userPin = int.Parse(Console.ReadLine());
        // check against our db
        if (currentUser.Pin == userPin) break;
        else Console.WriteLine("Incorrect Pin. Please try again");
    }
    catch
    {
        Console.WriteLine("Pin number incorrect. Please try again");
    }
}

Console.WriteLine("Welcome " + currentUser.FirstName + ":)");
int option = 0;

do
{
    printOptions();
    try
    {
        option= int.Parse(Console.ReadLine());
    }
    catch 
    {

    }
    if (option == 1) deposit(currentUser);
    else if(option == 2) withdraw(currentUser);
    else if(option == 3) balance(currentUser);
    else if(option == 4) break;
    else { option = 0; }
}
while (option != 4);
Console.WriteLine("Thank you! Have a nice day :)");


