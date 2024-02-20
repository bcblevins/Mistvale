//TODO: Learn how to reference other classes - use CreateMenuTwo method in IOSystem


//Vars
IOSystem iOSystem = new IOSystem();
String command;
String name;
Dictionary<String, int> inventory = new Dictionary<string, int>();



//Greet user, take name


Console.WriteLine("Please enter your name:");
name = Console.ReadLine();
Console.WriteLine(@"
===============================================
\        / r---- |      /``` /```\ |\  /| r----
 \  /\  /  |____ |     |     |   | | \/ | |____
  \/  \/   |____ |____  \,,, \___/ |    | |____

  ,.--.,          ----- /```\          ,.--.,
-`      `-._.-      |   |   |    -._.-`      `-
                    |   \___/

|\  /| ``|`` /``\ ----- \    /  /\   |     r----
| \/ |   |   `--,   |    \  /  /--\  |     |____
|    | __|__ \__/   |     \/  /    \ |____ |____
================================================");
waitForInput();

//Set up story
Console.WriteLine(@"
     You wake up to banging on your door. This is it, the bounty hunters have tracked you across
the Misty Plains and are here to collect. You knew that Bolli wasn't prepared for the last job and now
you're going to pay for it. Your heart begins to pound as your eyes dart around the room, looking for 
an exit. It's a small hut with no windows and one door, but it's starting to feel like a grave.

     The door swings open and a large, burly man walks in. As your eyes begin to adjust, you recognise 
your old friend Bolli and you breathe a sigh of relief.

     ""The entire town is awake and " + name + @" is still asleep. Don't you know theres money to
be made?"" Bolli said with a familiar smile.

     ""I know that look Bolli, what is it?"" you say, not sure if you want to hear the answer.

     ""Well, while you were getting your beauty sleep I was in town getting us a job. I know what you're
thinking but this guy is the real deal. He gave me half upfront and everything. You know the old fortress
nearby? Apparently there is some artifact there and the guards stationed there don't even know what they 
have. All we have to do is sneak in and steal it.""");

waitForInput();
Console.WriteLine(@"

     ""...you want us to steal an artifact ...from a military fortress. Did I miss something? We haven't
done more than steal some jewelry from a noble, unsuccessfully I might add, and you expect us to pull
this off?""

     ""That's the best part: we don't even need to actually complete the job. The money he gave me is more
than enough to set up this heist AND set ourselves up nicely. If things go south, we can just skip town
and move on with our lives!""

     ""Bolli this is an incredibly awful idea. We are not doing this.""

     ""I can't do this alone " + name + @", and don't forget: you still owe me.""

     How could you forget? If not for Bolli you wouldn't still be around to hear his terrible ideas. You
have a strong feeling that a terrible fate awaits you if you accept, but the guilt of letting Bolli down
might be worse.
");
command = iOSystem.CreateMenuTwo("Agree to the heist", "Tell Bolli he is off his rocker and you hope his inevitable stay in jail allows him the time to grow a brain");

while (true)
{
    if (command == "1")
    {
        break;
    }
    else if (command == "2")
    {
        Console.WriteLine("QUITTER ENDING"); //TODO: write a quitter ending
        return;
    }
    else
    {
        Console.WriteLine("Looks like you didn't choose a valid option. Please select the NUMBER option you would like.");
        command = Console.ReadLine();
    }
}

Console.WriteLine(@"
     ""I knew I could count on you! I have a lead I'd like to follow up on for a possible way into the
fortress. In the meantime you may want to head into town to see if you can buy something to help us out.
Here is a little bit of the money he gave us. Let's meet back here at sundown for final preparations.""
                
//+72 Gold
                
     And just like that Bolli was gone. Heading into town doesn't seem like such a bad idea. Then again,
neither does getting some sleep since it seems you won't be getting any tonight.");

inventory["Gold"] = 72;


//Start gameplay loop


static void waitForInput()
{
    Console.WriteLine();
    Console.WriteLine("Press enter to continue...");
    Console.ReadLine();
}

//To make the console stay up after running
Console.ReadLine();