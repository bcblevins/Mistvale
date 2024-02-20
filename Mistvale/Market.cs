using System;

public class Market : Room
{
	PotionShop potionShop = new PotionShop();
	public Market()
	{
		this.name = "The Market";
		this.description = @"
    You arrive at the market, an array of shops and stalls surround you, from butchers to 
carpenters to clothiers. Two in particular stand out to you: the Potion Shop and the 
Mystic Emporium, whatever that is.";
	}

	public void ProcessCommands()
	{
		String choice = iOSystem.CreateMenuTwo("Go to the Potion Shop", "Visit the Mystic Emporium");
		if (choice == "1")
		{
			potionShop.Enter();
		}
		else
		{

		}
	}
}


