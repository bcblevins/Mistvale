using System;
public class MysticEmporium : Room
{
    Home home = new Home();
    public MysticEmporium()
    {
        this.name = "The Mystic Emporium";
        this.description = @"
    As you enter the Mystic Emporium, you see an old man sitting behind the counter. The shop seems 
almost completely empty, save for a fre rings and amulets on display behind the counter.
    ""Troubled one, you have set in motion a series of events that will change the fate of Mistvale.""
    He reaches under the counter and pulls out 2 silver rings, each with a small purple gemstone 
affixed to its outer surface.
    ""Take these, and give one to your friend. They are ";
    }
}

