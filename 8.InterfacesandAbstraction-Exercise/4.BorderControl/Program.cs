using _4.BorderControl;

string cmd;
List<Citizen> citizens = new List<Citizen>();
List<Robot> robots = new List<Robot>();
while ((cmd = Console.ReadLine()) != "End")
{
    List<string> input = cmd.Split().ToList();
    if (input.Count() == 3)
    {
        citizens.Add(new Citizen(input[0], int.Parse(input[1]), input[2]));
    }
    else
    {
        robots.Add(new Robot(input[0], input[1]));
    }
}
string fakeId = Console.ReadLine();

citizens.ForEach(x => x.PrintFakeIDs(fakeId));
robots.ForEach(x => x.PrintFakeIDs(fakeId));