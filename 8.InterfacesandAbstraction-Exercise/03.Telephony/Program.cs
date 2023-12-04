using _03.Telephony;


List<string> phoneNums = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
List<string> urlLinks = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

List<IBrowsable> smartphones = new List<IBrowsable>();
foreach (string phoneNum in phoneNums)
{
    if (phoneNum.Length == 10)
    {
        var currentPhone = new Smartphone(phoneNum, urlLinks.First());
        currentPhone.Call();
        smartphones.Add(currentPhone);
        urlLinks.RemoveAt(0);
    }
    else if (phoneNum.Length == 7)
    {
        var currentPhone = new Stationary(phoneNum);
        currentPhone.Call();
    }
    else
    {
        Console.WriteLine("Invalid number!");
    }

}
foreach (var smartphone in smartphones)
{
    smartphone.Browse();
}
