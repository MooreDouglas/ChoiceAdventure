namespace ChoiceAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Begin\nWith Name:");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine(name + "\n\n\n");
            int answer;
            Console.WriteLine("A Tool");
            Console.WriteLine("\n");
            Console.WriteLine("You have traveled to a small country in a generally sandy yet forested land continent." +
                "\nYou have found yourself in a village near the Tool." +
                "\nThe Tool is something you only read about, it was apparently amazing." +
                "\nThe village seems technologically trapped, stuck in an age of old, yet new." +
                "\nThe local people understand you yet speak a language you don't." +
                "\nYou must decide what to do to make your way toward the tool.");
            Console.WriteLine("\n");
            Console.WriteLine("1. Rent a car\n2. Take a bus\n3. Ask around about the Tool");
            answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("The local cars look... strange... you have never driven one of them." +
                    "\nThe salesman expresses no concern and happily sells you their best." +
                    "\nPerhapes the salesman had sold you a terrible car, perhapes it is because you don't know how to drive it." +
                    "\nYou crash." +
                    "\nNo can find you, a forested canyon, you cannot escape.");
                    Console.WriteLine("\n");
                    Console.WriteLine(name + " was trapped in paradise.");
                    break;
                case 2:
                    Console.WriteLine("The bus driver seemed to not care about your safety, you knew this from the beginning." +
                        "\nYour trust of the other passengers was also draining, every minute." +
                        "\nAt some point the driver decided to pass your destination and make you pay extra." +
                        "\nYou wouldn't have any of it and got off" +
                        "\nNow you decide that perhapes walking may be the best choice.");
                    Console.WriteLine("\n");
                    Console.WriteLine("1. Hitchhike\n2. Try for bus again");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        Console.WriteLine("You stood on the side of the road waiting." +
                            "\nIt wasn't before long when you thought it would be better to walk to a nearby village and leave from there." +
                            "\nYou wouldn't come here again, bad bus services.");
                        Console.WriteLine("\n");
                        Console.WriteLine("Congrats " + name + " survived" +
                            "\nEnding - Bus");
                    }
                    else if (answer == 2)
                    {
                        Console.WriteLine("You waited, nothing, not one bus came for you." +
                            "\nThe bus stop provided ample protection from rain that deided that your part of the forest was perfect to rain on." +
                            "\nYou waited." +
                            "\nWaited...");
                        Console.WriteLine("\n");
                        Console.WriteLine("Congrats, " + name + " actually survived, they just waited a long time before leaving." +
                            "\nEnding - Waited");
                    }
                    break;
                case 3:
                    Console.WriteLine("Asking around about the Tool you discover that everyone who knows what it is, they tell you to leave." +
                        "\nYou feel you are the stupid one." +
                        "\nThe mind tells you that you have been tricked." +
                        "\nIt is quite possible that it doesn't exist." +
                        "\nFind a way to get out, away.");
                    Console.WriteLine("\n");
                    Console.WriteLine("1. Rent a car\n2. Take a bus\n3. Hitchhike");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        Console.WriteLine("The car rental was a place of evil, you saw past every illusion." +
                            "\nThe car salesmen wanted money, they used terrible vehicles in place of cars." +
                            "\nThey tricked every tourist wanting a car." +
                            "\nThey wouldn't fool you, " + name + " was not a fool." +
                            "\n\nYou waited until nightfall, then you broke in." +
                            "\nThey hid all the nice things for themselves, as anyone would." +
                            "\nIt wasn't before long, you noticed, the red and blue.");
                        Console.WriteLine("\n");
                        Console.WriteLine("1. Down the highway\n2. Country road\n3. Try for bus again");
                        answer = Convert.ToInt32(Console.ReadLine());
                        if (answer == 1)
                        {
                            Console.WriteLine("The highway proved difficult for you, the car wasn't the fastest piece of machinery." +
                                "\nThey were right behind you after a few minutes of high speed chase." +
                                "\nCould you make it?" +
                                "\nThen, you saw it." +
                                "\nThey were closing the highway gates, you wouldn't be able to stop in time." +
                                "\nYou pulled the emergency brake, however it didn't work as intended." +
                                "\nYou could do nothing but turn the wheel and brace.");
                            Console.WriteLine("\n");
                            Console.WriteLine(name + " sped into the wall of concrete.");
                        }
                        else if (answer == 2)
                        {
                            Console.WriteLine("The country road was twisted in the night, plenty of reds and blues found their ways into ditches." +
                                "\nThis was what this car was meant for." +
                                "\nYou weaved through the forest dodging the occasional road block." +
                                "\nIt wasn't before long before they took to the sky to attempt to find you." +
                                "\nYour speed through the forest was unrivaled." +
                                "\nIt was, for the most part, the car which drove you through the forest." +
                                "\nIt wasn't before long when the border of the small country approached you, you could escape this tourist trap." +
                                "\nAs the border approached you noticed, they had called upon their miltary to dispatch you." +
                                "\nIt was a race against their intended fate for you." +
                                "\nYou raced toward the finish, and failed.");
                            Console.WriteLine("\n");
                            Console.WriteLine(name + " tried to race fate.");
                        }
                        else if (answer == 3)
                        {
                            Console.WriteLine("There it was, the bus, you felt a tinge of hate." +
                                "\nYou drove around it, forcing evasive manuvers upon the bus driver." +
                                "\nThey flipped, forcing the red and blues to stop behind it." +
                                "\nYour driving skills prompted the red and blues to try harder in your capture." +
                                "\nYou had escaped them, for now." +
                                "\nSuddenly the weather turned bad." +
                                "\nYou couldn't see then you could." +
                                "\nThey had a spotlight on you, the criminal." +
                                "\nYou sped up down the rainy highway, it wasn't before long when you saw it." +
                                "\nThe highway gate, they hadn't started closing it until you were a hundred yards away." +
                                "\nYou could make it." +
                                "\nThe car sped up to as fast as it could." +
                                "\nYou could see freedom on the other side, over the border." +
                                "\nThen you made it." +
                                "\nThe gate closed behind you, not that it would matter, they can't do anything to you on the other side of the border." +
                                "\nYou had escaped.");
                            Console.WriteLine("\n");
                            Console.WriteLine("Congrats, " + name + " has survived." +
                                "\nEnding - Freedom");
                        }
                    }
                    else if (answer == 2)
                    {
                        Console.WriteLine("You use a bus, this time, moving away from the Tool." +
                            "\nThe bus ride is quiet, the tiredness overcomes you and forces your sleep." +
                            "\nWhen you awake, it appears the bus driver evicted you from their public transport." +
                            "\nYou are forced to walk along a desert road hoping someone comes to help you." +
                            "\nPerhapes something was learned?");
                        Console.WriteLine("\n");
                        Console.WriteLine(name + " walked until they couldn't.");
                    }
                    else if (answer == 3)
                    {
                        Console.WriteLine("Descretly, you asked others for a ride out." +
                            "\nOne person, she agreed to help you." +
                            "\nShe didn't seem too bad, you found her trying to convince a gentleman that their country was evil." +
                            "\nEvil hidden behind a curtain." +
                            "\nShe led you to her car, these people really do have cars." +
                            "\nIt looked as you remember cars to be." +
                            "\nShe drove you down the highway, talking to you." +
                            "\n\"They look for people at the highway gate ahead." +
                            "\nYou might need to hide in the back.\"" +
                            "\nHiding in the back you discover a metal pipe, self defense." +
                            "\nThe guard walk around the vehicle, checked the trunk." +
                            "\nThen they drove away, she let you out at an airport." +
                            "\nAfter a goodbye, you were left with a plane ticket in your hand." +
                            "\nWas this worth it?" +
                            "\nWhat did you get from this experience.");
                        Console.WriteLine("\n");
                        Console.WriteLine("Congrats, " + name + " survived." +
                            "\nEnding - Planes");
                }
                    break;
            }
        }
    }
}
