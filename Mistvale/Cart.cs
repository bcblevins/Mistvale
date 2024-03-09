using System;
using System.Diagnostics.Metrics;

public class Cart : Room
{
	FortressHalls fortressHalls = new();
	public Cart()
	{
		this.name = "Supply Cart";
		this.description = @"
	It is a long bumpy ride to the fortress. You and Bolli have hidden yourselves
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
	""Let me take a look at the goods you brought Mark, you're acting strange.""
	The guard and the quartermaster begin to argue. Your heart begins to race. 
What was Bolli thinking having your way in dependant on a stranger? If you are 
found, the guard will surely have you arrested, if not killed.
	The boxes you were hiding under are suddenly moved. You recognise that you are
just inside the fortress.");

		if (Player.inventory.ContainsKey("Potion of Refraction"))
		{
            Console.WriteLine(@"
	You don't dare take even a breath, hoping the potion you 
took will be worth the money you spent. The guard looks right at you, then looks 
over the rest of the cart.
	""Alright everything seems to be in order, you should really get some rest Mark.
I know things are difficult with your daughter being sick but you need to take care
of yourself.""
	The guard replaces the boxes and you feel the cart begin to move again.");
            IOSystem.WaitForInput();
            Console.WriteLine(@"
	The cart comes to a halt. The quartermaster removes the boxes covering you and
helps you up. As you exit the cart you begin to notice the potion's effect wearing
off. It saved you once, you suppose that will have to be enough.");

			fortressHalls.Enter();
        }
        else
		{
            Console.WriteLine(@"
	""Who the hell are you two? Mark! What are you doing?!""
	Your heart drops, you can't think of anything to say.
	""These two wanted in to the fortress to take something, we don't have anything
of value so I assumed they would just look around and leave, or even better get 
caught after I dropped them off. You know Lilith is sick, and these two paid me 70 
gold to sneak them in, which would buy enough medicine to make her well again. 
Please just forget you saw them.""
	The guard's face hardens, as if a switch had been flipped revealing an 
unsettling coldness.
	""Give me the 70 gold and you can go.""
	""I... I need this gold Mark, please don't do this."" says the quartermaster.
	""I won't say it again. Pay, or I tell the Warden.""
	The quartermaster's shoulders slump as his hard exterior melts away. His eyes
betray a gentle spirit crushed under the weight of lost hope.
	""So be it."" the quartermaster says, before tossing a sack of gold to the guard.
	The guard replaces the boxes and you feel the cart move again.");
			IOSystem.WaitForInput();

            Console.WriteLine(@"
	The cart comes to a halt. The quartermaster removes the boxes covering you and
helps you up. He is almost unrecognizable from his complete change in stature after
his confrontation with the guard. Your heart sinks at the idea of him not being able
to care for his daughter and begin considering giving him the gold you are carrying,
he certainly seems more deserving of it than you.");
			String choice = IOSystem.CreateMenuTwo("Give the quartermaster your gold (cost: " + Player.inventory["Gold"] + " Gold)", "Say nothing to the quartermaster and carry on");
			if (choice == "1")
			{
				String subchoice = IOSystem.CreateMenuTwo("Give the gold to the quartermaster with no conditions", "Give the gold to the quartermaster if he waits and assists you and Bolli with an escape");
				if (subchoice == "1")
				{
                    Console.WriteLine(@"
	You hand the quartermaster the gold you are carrying. 
	// -" + Player.inventory["Gold"] + @" Gold
	The quartermaster opens his mouth but nothing comes out. A subtle shimmer 
glistened in the corners of his eyes. He is barely able to force out the words:
	""Thank you.""
	You whisper to him ""If something goes wrong, get out of here.""
	He nods and walks to the front of the cart.
	""We should move on " + Player.name + ".");
					Player.isQuartermasterWaiting = false;
                } else if (subchoice == "2")
				{
                    Console.WriteLine(@"
	""If you wait here for us to return and help us escape should anything go wrong,
I will give you " + Player.inventory["Gold"] + @" Gold."" you say as you show the 
quartermaster the gold you are carrying.
	The quartermaster nods, and returns to the front of the cart.");
					Player.isQuartermasterWaiting = true;
                }
			} else
			{
                Console.WriteLine(@"
	The quartermaster returns to the front of the cart.");
				Player.isQuartermasterWaiting = false;
            }
            Console.WriteLine("    Bolli motions for you to enter a doorway into the keep.") ;
			IOSystem.WaitForInput();
            fortressHalls.Enter();
        }
        
    }


}


