using System;
public class MysticEmporium : Room
{
    Home home = new Home();
    public MysticEmporium()
    {
        this.name = "The Mystic Emporium";
        this.description = @"
    As you enter the Mystic Emporium, you see an old man sitting behind the counter. The shop seems 
almost completely empty, save for a few rings and amulets on display behind the counter.
    ""Troubled one, you have set in motion a series of events that will change the fate of Mistvale.""
    He reaches under the counter and pulls out 2 silver rings, each with a small purple gemstone 
affixed to its outer surface.
    ""Take these, and give one to your friend. Now it is time for you to leave, it is getting dark.""
    Before you can respond, he puts the rings in your hand and pushes you out the door.

    // +2 Rings of Muffling

    That's odd, he didn't even try to ask for payment. Oh well I guess, its time to make the walk
back home to meet Bolli.";
    }
    public override void ProcessCommand(Dictionary<string, int> inventory)
    {
        inventory["Ring of Muffling"] = 2;
        IOSystem.WaitForInput();
        home.Enter(inventory);
    }
}
