using System;
namespace Mistvale
{
	public abstract class Room
	{
		private String name;
		private String description;

		public void Enter()
		{
			Console.WriteLine("================================================");
			Console.WriteLine(name);
            Console.WriteLine("------------------------------------------------");
			Console.WriteLine(description);
            Console.WriteLine("------------------------------------------------");
        }

		public abstract void ProcessCommand();
    }
}

