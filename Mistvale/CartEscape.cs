using System;

public class CartEscape : Room
{
	public CartEscape()
	{
        this.name = "Outside the Fortress";
        this.description = @"
    You make your way back through the corridors the way you came in, passing
by men running in all directions, too preoccupied to care that you don't belong.
When you find the exit you see the Quartermaster hiding behind some rubble.
    When he sees you he yells ""Get in the cart!"" The three of you jump into
the cart and begin your escape.
    A volley strikes the main tower of the fortress and giant chunks of stone
rain down all around you. You pass under the arch to exit the fortress, but not
before a piece of the tower strikes it. Hundreds of pounds of stone land
directly on the Quartermaster sending you and Bolli flying through the air. You
close your eyes and brace for an impact that never comes. When you open your
eyes you find that you are still in the air, and time has slowed almost to a
halt. The box containing the artifact has opened, revealing an impossibly dark,
circular object. You would think it is made of some kind of glass, yet it doesn't
reflect any light. Inside, you can see a million twinkling lights.
    The whispers from the object return and you feel an undeniable urge to grab
the artifact.";
	}
    public override void ProcessCommand()
    {
        String choice = IOSystem.CreateMenuTwo("Grab the artifact", "Continue to brace for impact");
        if (choice == "1")
        {
            Console.WriteLine(@"
    As you reach for the artifact, the whispers become defeaning. Your fingers
are mere inches away from touching the surface, and you begin to feel an
unpleasant tingling sensation that travels up your arm and down your back. It
becomes more unpleasant the closer your fingers get to the artifact.");
            choice = IOSystem.PromptForInput("Are you sure you want to grab the artifact? (y/n)");
            if (choice == "y" || choice == "Y")
            {
                Console.WriteLine(@"
    Your fingertips brush the surface of the artifact. It is cold and smooth, the
tingling sensation you felt is replaced by a comforting warmth that fills your
chest. As your fingers close around the artifact, what you can only describe as
a tear rips open in the space in front of you, revealing a dark void. That tear
grows larger and larger, beginning to surround you and Bolli until it is all
that you can see.");
            }
        }
    }
}


