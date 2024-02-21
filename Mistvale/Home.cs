using System;

public class Home : Room
{
	Cart cart = new();
	public Home()
	{
		this.name = "Home";
		this.description = @"
    It is getting dark, and Bolli and a strange man are talking outside your home,
waiting outside next to a cart. As you approach, Bolli's face lights up.
	""" + Player.name + @"! Come meet this fine gentleman. He has agreed to be
a huge help to us. He is the quartermaster of the fortress, and he is going to
sneak us in underneath some boxes in the back of his cart! No one should suspect
a thing.""
	""Hello, sir."" You say as you offer to shake the quartermaster's hand.
	The quartermaster looks at your hand, then looks at Bolli and says:
	""If we wait any longer people will start to get suspicious. Let's just get
this over with.""";
	}
	public override void ProcessCommand(Dictionary<string, int> inventory)
	{
		if (inventory.ContainsKey("Potion of Refraction"))
		{
			Console.WriteLine(@"
	""Hang on Bolli,"" You say as you pull out the potion you purchased earlier
and take a swig from it. It is intensly bitter, for a moment you wonder if you
will be able to keep it down but it passes as the flavor changes pleasantly floral.
You hand the bottle to Bolli and he takes a swig as well. You both climb into the
back of cart.");
			inventory["Potion of Refraction"] = 0;
		}
		else if (inventory.ContainsKey("Ring of Muffling"))
		{

		}
		cart.Enter(inventory);

	}
}


