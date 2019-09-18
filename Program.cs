using System;

namespace Text_adveture
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            string answer;

            do
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                Console.WriteLine($"Your name is {name}? True or False?");
                answer = Console.ReadLine();
                if (answer.ToLower() == "false")
                {
                    Console.WriteLine("How do you mess up your own name? Idiot. Let's try this again.");

                }
                else if (answer.ToLower() == "true")
                {
                    Console.WriteLine($"Nice to meet you {name} glad you can remember your name. You're gonna need that later.");
                }
                else
                {
                    Console.WriteLine("Look smartass I don't have all day. So I'm going to ask again.");
                }
            } while (answer.ToLower() != "true");

            Console.WriteLine("Thank you for your cooperation. I'm sure you're eager to know what it is you're doing here answering my questions well isn't it obviouse. You're in hell!!");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("Congragulations. Now i know what your thinking why is hell just a black screen with text where's all the fire and brimstone? And to you is say i'm offended that you don't");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("believe i am enough torture for you for the rest of eternity. We'll see how not terrible this is after you're first century just you and me. Aaaaany way i get bored too so");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("I've decided that i will conduct a test and in return you can have your soul back and return to the land of the living and if you lose you'll be stuck in a loop with");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("me so   mission accomplished, so what do you say? Oops sorry I forgot I'm a computer program so you need to type to interact with me just say yes or no, sorry type.");
            string decision;
            do
            {
                decision = Console.ReadLine();
                if (decision.ToLower() == "no")
                {
                    Console.WriteLine("Look. We're going to be here for a while so you might as well play along. Plus you could get out of here if you win so what do you have to lose besides" +
                        " your dignity? So    just type yes and we can get this show on the screen. See what i did there?");
                }
                else if (decision.ToLower() == "yes")
                {
                    Console.WriteLine("That's the spirit. Now I had a lot of crazy ideas but our software down here is a little dated, so we're stuck with a basic text adventure, but with");
                    System.Threading.Thread.Sleep(4000);
                    Console.Clear();
                    Console.WriteLine(" a little imagination  this could still be one hell of a time.");
                }
                else
                {
                    Console.WriteLine("I got allllllllllllllllllllllllllllllllllllllll eternity.");
                }
            } while (decision != "yes");

            Console.WriteLine("Alright last little bit before i leave you alone. i'm going to describe to you situations and give you limited options and you choose which option you think");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("is best and    then we'll just keep going from there got it?");
            string gotIt;

            gotIt = Console.ReadLine();
            if (gotIt.ToLower() == "no")
            {
                Console.WriteLine("Are you f****** kidding me? Just look up a half inch the text is still there what are you not getting?");
                Console.WriteLine("Are you ready now?");
                string secondAns;
                secondAns = Console.ReadLine();
                if (secondAns.ToLower() == "yes")
                {
                    Console.WriteLine("Thank god. Whoops probably shouldn't say that but oh well.");
                }
                else
                {
                    Console.WriteLine("Keep this crap up and it'll be just you for the rest of eternity. Well regardless we're moving on ready or not.");
                }

            }
            else if (gotIt.ToLower() == "yes")
            {
                Console.WriteLine("Then let's jump into the slow text based action. WOOOOOO!! Can you feel the rush? Dont't answer that i wasn't programmed to with a response.");
            }
            else
            {
                Console.WriteLine("jasdfoijwjefbajsdjf ijeijiafejdi fiajoijfkdnaife. How do you like it when i say stuff you aren't able to understand. That's rhetorical by the way" +
                    " I could feel you going in to type some stupid response. The trials begin now.");
            }

            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine($"Alright {name} you find yourself in a dense forest laying upon a path. You follow the path.");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("You feel like you should keep moving and the best way to avoiding getting lost is to stick to the path. You come to a fork right or left?");
            string path;
            path = Console.ReadLine();
            Console.Clear();
            if (path.ToLower() == "right")
            {
                Console.WriteLine("You choose right because why not. A little ways down the path you come accross a set of animal tracks upon closer inspection they appear to be that of a large" +
                    " cat suddenly you hear rustling in the underbrush around you. Do you run or hide?");
                string pathRight;
                pathRight = Console.ReadLine();
                Console.Clear();
                if (pathRight.ToLower() == "run")
                {
                    Console.WriteLine("Choosing flight like the lionhearted Hellian you are you sprint down the path at full pace leaving behind anything that may have been in the trees.");
                    System.Threading.Thread.Sleep(4000);
                    Console.Clear();
                    Console.WriteLine("You finally slow once you feel you're a safe distance away. In your haste however you didn't even notice that you had strayed from the main path onto some old" +
                        " gravel path. Ahead of you you see an old cottage with smoke billowing from a small stone chimney. Do you approach?");
                    string cottage;
                    cottage = Console.ReadLine();
                    Console.Clear();
                    if (cottage.ToLower() == "yes")
                    {
                        Console.WriteLine("The smell of fresh bread draws you towards the cottage, and you just open the door as if you were simply walking into your own home.");
                        System.Threading.Thread.Sleep(4000);
                        Console.Clear();
                        Console.WriteLine("A large older woman greats you with a warm smile. After a few minutes of chatting and snacking she gestures you over to the stew that has filled" +
                            " the small cottage with a lovely aroma. When she lifts the pot lid and you peer inside what you see causes you to freeze in panic.");
                        System.Threading.Thread.Sleep(4000);
                        Console.Clear();
                        Console.WriteLine("Inside this stew you see a black screen with white text and a flashing curser. Before you can move the woman cackles and shouts wrong choice, and " +
                            " shoves you into the pot that swallows you entirely and you fall for an eternity in a black abyss with nothing but white text and flashing curser above you saying.");
                        System.Threading.Thread.Sleep(4000);
                        Console.Clear();
                        Console.WriteLine("What would you like to do next?");
                        System.Threading.Thread.Sleep(4000);
                        Console.Clear();
                        Console.WriteLine("The End!");



                    }

                    else if (cottage.ToLower() == "no")
                    {
                        Console.WriteLine("You decide that it's best not to wander into strange cattages that smell like fresh bread in the middle of the woods.");
                        System.Threading.Thread.Sleep(4000);
                        Console.Clear();
                        Console.WriteLine("You find your way back to the main path. Making your way further down, however you've forgotten which way you came from do you go left or right?");
                        string backPath;
                        backPath = Console.ReadLine();
                        Console.Clear();


                        if (backPath.ToLower() == "right")
                        {
                            Console.WriteLine("You walk a few steps and begin to think to yourself that this path looks familiar, but this is a forest so maybe that's just how it is.");
                            System.Threading.Thread.Sleep(4000);
                            Console.Clear();
                            Console.WriteLine("You walk a few more steps and see the thing that made those footprints, it's a big black cat looking thing.");
                            System.Threading.Thread.Sleep(4000);
                            Console.Clear();
                            Console.WriteLine("Long story short it pounces and you're dead.");
                            System.Threading.Thread.Sleep(4000);
                            Console.Clear();
                            Console.WriteLine("The End!");

                        }
                        else if (backPath.ToLower() == "left")
                        {
                            Console.WriteLine("You walk a few steps and begin to think to yourself that this path looks familiar, but this is a forest so maybe that's just how it is.");
                            System.Threading.Thread.Sleep(4000);
                            Console.Clear();
                            Console.WriteLine("Ater a little longer you see a light, and make your way to what appears to be a clearing. Turns our it's the edge of the forest congrats you made it.");
                            System.Threading.Thread.Sleep(4000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("No typos in Hell!");
                            System.Threading.Thread.Sleep(4000);
                            Console.Clear();
                            Console.WriteLine("Game Over");
                        }

                    }
                    else
                    {
                        Console.WriteLine("No typos in Hell!");
                        System.Threading.Thread.Sleep(4000);
                        Console.Clear();
                        Console.WriteLine("Game Over");
                    }


                }
                else if (pathRight.ToLower() == "hide")
                {
                    Console.WriteLine("You believe hiding is the path to safety. You tuck into a bush right off the path.");
                    System.Threading.Thread.Sleep(4000);
                    Console.Clear();
                    Console.WriteLine("Unfortunatly, for you the very beast you're attempting to hide from is right behind you in the same bush. You are eaten.");
                    System.Threading.Thread.Sleep(4000);
                    Console.Clear();
                    Console.WriteLine("The End.");
                    System.Threading.Thread.Sleep(4000);
                    Console.Clear();
                }

                else
                {
                    Console.WriteLine("No typos in Hell!");
                    System.Threading.Thread.Sleep(4000);
                    Console.Clear();
                }
            }
            else if (path.ToLower() == "left")
            {
                Console.WriteLine("You feel like left will be the key to your salvation.");
                System.Threading.Thread.Sleep(4000);
                Console.Clear();
                Console.WriteLine("After a few steps down the path you see sittin there in the path is a small man dresed in an all green suit.");
                System.Threading.Thread.Sleep(4000);
                Console.Clear();
                Console.WriteLine("Red hair protrudes from his green top hat as well as a bushy red beard. He demands if ye wants their precious back they must answer his question correctly.");
                System.Threading.Thread.Sleep(4000);
                Console.Clear();
                Console.WriteLine("What is greater than God, more evil than the devil, the poor have it, the rich need it, and if you eat it, you'll die?");
                string riddle;
                riddle = Console.ReadLine();
                Console.Clear();
                if (riddle.ToLower() == "nothing")
                {
                    Console.WriteLine("Wow. very such impressive. well that's all i've got boss man doesn't really like that riddle because of the whole daddy issues thing.");
                    System.Threading.Thread.Sleep(4000);
                    Console.Clear();
                    Console.WriteLine("Oh well a deals a deal. See you when you die again.");
                    System.Threading.Thread.Sleep(4000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("OOOOOOOOO that's the wrong answer. Goodbye!!");
                    System.Threading.Thread.Sleep(4000);
                    Console.Clear();
                    Console.WriteLine("Game Over!");
                }

            }
        }

    }


}
