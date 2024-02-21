using System;

public class Cart : Room
{
	public Cart()
	{
		this.name = "Supply Cart";
		this.description = @"
	It is a long bumpy ride to the castle. You and Bolli have hidden yourselves
underneath some boxes and it is starting to get very uncomfortable, this is much
more physical contact with Bolli than you would ever want.";


    }
    public override void ProcessCommand()
	{
		if (Player.inventory.ContainsKey("Potion of Refraction"))
		{
			Console.WriteLine(@"
	You begin to notice that you can't see Bolli very well, almost as if you can
see through him. It seems like the potion wasn't a total waste of money, you just
hope it lasts long enough to be useful.");
		}
		Console.WriteLine(@"
	You feel the cart come to a stop.
	""Hey Mark how's it going?"" says an unfamiliar voice.
	""Oh y-y'know just a normal haul from town. I'm in a bit of a rush so if you
don't mind I'll just head in."" The quartmaster's shaky voice betrays his
nervousness.
	""Let me take a look at the goods you bought Mark, you're acting strange.""
	Your heart begins to race. What was Bolli thinking having your way in
dependant on a stranger? If you are found, the guard will surely have you arrested,
if not killed.");
	}

}


