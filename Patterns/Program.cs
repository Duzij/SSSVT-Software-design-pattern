using Patterns.Builder;
using Patterns.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //COMMAND
            //Jde o to, že receiver a invoker o sobě neví a nijak nekoledují.
            //To nám dává možnost skladovat nebo přehazovat commandy
            //Příklad je zapínání a vypínání světla

            //Dá se to implementovat jak přes interface, tak i před abstraktní klasu, kde budeme taktéž mít náš reciver (každý command ve fináli ví, kde se spustí)

            LightReceiver R = new LightReceiver();
            SwitchInvoker I = new SwitchInvoker();

            SwitchOnCommand on1 = new SwitchOnCommand(R);
            SwitchOffCommand off = new SwitchOffCommand(R);
            SwitchOnCommand on2 = new SwitchOnCommand(R);

            I.StoreAndExecute(on1);
            I.StoreAndExecute(off);
            I.StoreAndExecute(on2);

            Console.ReadKey();

            //BUILDER
            //Jde o to, že mam nějaký objekt Director, který řídí výrobu. Mam taky interface IBuilder, který v našem případě vyrádí pizzu ze 3 dílů
            //Pak akorat director musi mít možnost vyrobit pizzu a do parametru vezme jenom Interface.
            //Takže v závislosti na tom, builder které pizzy to je, budu mít různé druhy pizzy

            Director Director = new Director();

            SunkaSyrPizzaBuilder a = new SunkaSyrPizzaBuilder();
            FereronkyPizzaBuilder b = new FereronkyPizzaBuilder();

            Director.Construct(a);
            Director.Construct(b);


        }
    }
}
