using Assi1.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Flyweights
{
    public class FlyweightFactory
    {
        //String list to compare the entry with our available choices
        protected List<string> strategies;

        //Constructor where we populate our string list with our choices
        public FlyweightFactory()
        {
            strategies =
            new List<string> { "bottomWeight", "pyramid", "topple" };
        }

        //Method to return a strategy depending on the user input
        public StackingStrategy GetFlyweight(string strategyType)
        {
            StackingStrategy strategy;

            //Here, we will return a null strategy if the user enter an unkown one
            if (!strategies.Contains(strategyType))
            {
                strategy = null;
            }
            else
            {
                switch (strategyType)
                {
                    case "bottomWeight":
                        strategy = new BottomWeight();
                        break;

                    case "pyramid":
                        strategy = new Pyramid();
                        break;

                    case "topple":
                        strategy = new Topple();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(strategyType), strategyType, "Bad Strategy Type");
                }
            }

            return strategy;
        }
    }
}
