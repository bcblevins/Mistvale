using System;

	public abstract class Room
	{
		protected String name;
		protected String description;

		public void Enter()
		{
			Console.WriteLine("=============================================================================================");
			Console.WriteLine(name);
            Console.WriteLine("---------------------------------------------------------------------------------------------");
			Console.WriteLine(description);
		    ProcessCommand();
        }

		public abstract void ProcessCommand();
    }


