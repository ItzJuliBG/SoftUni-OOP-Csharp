using _03.Telephony;
using System.Reflection.Metadata.Ecma335;

try
{


List<string> phoneNums = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
List<string> urlLinks = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));


ICallable phone;
foreach (string phoneNum in phoneNums)
{
    if(phoneNum.Length == 10)
    {
        phone = new Smartphone();
        phone.Call(phoneNum);
    }
    else if (phoneNum.Length == 7) 
    {
        phone = new Stationary();
        phone.Call(phoneNum);
    }
    else
    {
            Console.WriteLine("Invalid number!");
    }
    
}
IBrowsable browsable = new Smartphone();
foreach  (string urlLink in urlLinks)
{
    browsable.Browse(urlLink);
}
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}
