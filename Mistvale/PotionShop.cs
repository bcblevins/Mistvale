using System;
using System.Transactions;

public class PotionShop : Room
{
    Home home = new Home();
    public PotionShop()
    {
        this.name = "The Potion Shop";
        this.description = @"
    As you enter the Potion Shop, a strong herbacious scent overwhelms your senses. Every shelf, 
table and counter is covered in a crowded mess of glass bottles of varying sizes and colors. A 
woman dressed in a thoroughly stained gown emerges from the back room and approaches you uncomfortably 
quickly.
    ""Yes! And what does this one need hmm? Let me guess, a philter of unseeing to forget some painful 
memories?""
    Shes not wrong, but that's not why you are here.
    ""No thank you, I am looking for something to help me conceal mys-""
    Before the words finish escaping your lips, the woman thrusts a dark blue bottle into your hands.
    ""That's 60 gold, and then I don't want to see you in my shop again.""
    You hand the woman the gold she requested, then she promptly shoos you out of her shop. Something 
tells you she has gotten into trouble for helping thieves before. In times like these, it is hard to 
justify turning any business away.

    // +1 Potion of Refraction
    // -60 Gold

    It's about time to meet Bolli, so you begin the walk back to your home.";
    }
    public override void ProcessCommand()
    {
        Player.inventory["Potion of Refraction"] = 1;
        Player.inventory["Gold"] = Player.inventory["Gold"] - 70;
        IOSystem.WaitForInput();
        home.Enter();
    }
}

