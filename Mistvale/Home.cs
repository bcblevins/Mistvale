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
	""Ther you are! Come meet this fine gentleman. He has agreed to be a huge
help to us. He is the quartermaster of the fortress, and he is going to sneak us
in underneath some boxes in the back of his cart! No one should suspect a thing.""
	""Hello, sir."" You say as you offer to shake the quartermaster's hand.
	The quartermaster looks at your hand, then looks at Bolli and says:
	""If we wait any longer people will start to get suspicious. Let's just get
this over with.""";
	}
	public override void ProcessCommand()
	{
		if (Player.inventory.ContainsKey("Potion of Refraction"))
		{
			Console.WriteLine(@"
	""Hang on Bolli,"" You say as you pull out the potion you purchased earlier
and take a swig from it. It is intensly bitter, for a moment you wonder if you
will be able to keep it down but it passes as the flavor changes pleasantly floral.
You hand the bottle to Bolli and he takes a swig as well, but almost spits it out
before swallowing.
	""That is  by far the worst wine I have ever tasted. Is that what you spent
the money I gave you on?""
	""Bolli, that was a potion of refraction. Did you really think my plan was
for us to get drunk before doing the biggest job we've ever done?""
	Bolli smiled and shrugged his shoulders.
	""I thought maybe to calm our nerves!""");
			Player.inventory["Potion of Refraction"] = 0;
		}
		else if (Player.inventory.ContainsKey("Ring of Muffling"))
		{
			Console.WriteLine(@"
	""Hang on Bolli,"" You say as you pull out the rings you acquired at the
market. You put one on your finger and hand Bolli the other.
	""...I'm not really a jewlry type of guy, " + Player.name + @"."" Bolli says
while inspecting the ring.
	""I think it's some sort of enchanted ring, the guy at the store seemed to
think we would need it. I think it'll make our footsteps quieter."" You respond.
	""If you say so."" Bolli says as he puts on the ring. You decide not to tell
Bolli about the weird cryptic nature of your interaction with the shop owner.");
			Player.inventory["Ring of Muffling"] = 0;
		}

		Console.WriteLine(@"
	With all the necessary preparation complete, you and Bolli climb into the back
of the cart.");
		cart.Enter();

	}
}


