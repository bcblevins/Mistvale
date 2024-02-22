using System;


public class FortressHalls : Room
{
    public FortressHalls()
    {
        this.name = "The Fortress Halls";
        this.description = @"
    You and Bolli begin your exploration of the fortress, threading through 
its labyrinth of corridors and cavernous halls. It is a wonder that the 
walls, bearing the intricate network of weathered cracks, still stand. You 
are relieved to find the fortress to be surprisingly empty, but finding 
the artifact will still prove to be a difficult task.
    As you turn a corner, you see light pouring through a doorway at the 
end of the hall. You and Bolli approach the doorway and peer inside. You 
see a cook busy at work over a fire, his back turned to the doorway. At the 
far side of the room, a staircase descends into the earth, leading to a 
cellar below.
    You begin to hear a collection of faint whispers coming from somewhere
down the stairs. You can't quite make out the words. Are they even words?
A desire begins to grow to follow the whispers until your thoughts are 
consumed by it. You must find it. You must keep it safe.
    ""We need to go down the stairs."" You say.
    ""Yes, I think we do."" Bolli responds.";
        IOSystem.WaitForInput();
    }

    public override void ProcessCommand()
    {
        if (Player.inventory.ContainsKey("Ring of Muffling"))
        {
            Console.WriteLine(@"
    ""I think it's time to see if these rings were worth the trouble"" Bolli
says as he begins to quietly move across the room, you follow closely 
behind. Your path leads you right behind the cook, but the rings appear to 
be doing their job. Your footsteps are eerily quiet.
    The cook never turns around, and you and Bolli successfully cross the 
room without alerting the cook.");
        } else
        {
            Console.WriteLine(@"
    ""There is no way we can get past him, we would need to walk right 
next to him to get by."" you say.
    ""I'll talk to him, I bet a little gold will keep him quiet.""
    Before you can object, Bolli confidently strides up to the cook and says
    ""Hello fine sir, how are you doing this evening?""
    The cook turns around surprised to see a man not in uniform.
    ""What do you think you're doing? How did you even get in here?""
    ""That is none of your concern, but I believe this might be...""
    Bolli pulls out a handful of coin from his satchel and presents it to
the cook.
    ""You think any amount of money would be enough to risk being caught 
assisting thieves?""
    The cook opens his mouth to shout for help, but before any sound can
escape his lips Bolli grabs one of the chef's knives and plunges it into 
the cook's throat. The cook collapses to the floor.
    You run past Bolli to aid the cook, whose face begins to lose it's color. 
There is nothing you can do.
    ""Bolli... what have you done?"" you look up to see Bolli trembling, 
staring at the havoc he had wrought. He releases the knife, and it clatters 
loudly upon the floor.
    ""I... I had to " + Player.name + @", he was going to give us up.""
    ""So you killed him?!"" you exclaim. ""We don't kill people! Who even are 
you?""
    ""I suggest you lower your voice" + Player.name + @", you're going to 
attract unwanted attention.""
    Bolli's face changes, the once-trembling features now hardening into a 
mask of cold resolve. The vulnerability fades, replaced by a steely gaze.
    This has all been too much. You begin to question your years of friendship
with Bolli, a man who has led you into every wrong turn in your life, but 
someone you once thought had his heart in the right place. Who really was the
man standing before you?
    The insistent whispers surge with renewed intensity, compelling you to 
press on. Yielding to their persistent call, you find yourself descending the 
stairs, each step heavy with the weight of doubt and betrayal.
");
        }
        Console.WriteLine(@"
    The whispers resurge with ferocity, beckoning you to continue down the
stairs.
");

    }
}

