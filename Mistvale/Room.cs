using System;

	public abstract class Room
	{
		protected String name;
		protected String description;

		public void Enter(Dictionary<String, int> inventory)
		{
			Console.WriteLine("================================================");
			Console.WriteLine(name);
            Console.WriteLine("------------------------------------------------");
			Console.WriteLine(description);
			Console.WriteLine("------------------------------------------------");
		    ProcessCommand(inventory);
        }

		public abstract void ProcessCommand(Dictionary<String, int> inventory);
    }


