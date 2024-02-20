using System;

	public abstract class Room
	{
		protected IOSystem iOSystem = new IOSystem();
		protected String name;
		protected String description;

		public void Enter()
		{
			Console.WriteLine("================================================");
			Console.WriteLine(name);
            Console.WriteLine("------------------------------------------------");
			Console.WriteLine(description);
			Console.WriteLine("------------------------------------------------");
		    ProcessCommand();
        }

		public abstract void ProcessCommand();
    }


