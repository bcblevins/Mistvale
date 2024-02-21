using System;

public class Market : Room
{
	PotionShop potionShop = new();
	MysticEmporium mysticEmporium = new();
	public Market()
	{
		this.name = "The Market";
		this.description = @"
    You arrive at the market, an array of shops and stalls surround you, from butchers to 
carpenters to clothiers. Two in particular stand out to you: the Potion Shop and the 
Mystic Emporium, whatever that is.";
	}

	public override void ProcessCommand(Dictionary<String, int> inventory)
	{
		String choice = IOSystem.CreateMenuTwo("Go to the Potion Shop", "Visit the Mystic Emporium");
		if (choice == "1")
		{
			potionShop.Enter(inventory);
		}
		else
		{
			potionShop.Enter(inventory);
		}
	}
}


