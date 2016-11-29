using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harambe_MUD_Game
{
    public class Worldgeneration
    {
        List<Room> rooms;
        public Worldgeneration()
        {
            rooms = new List<Room>();
            Room r1 = new Room("Mors kælder", "hyggelig lille kælder hjemme ved mor.");
            Room r2 = new Room("Storebrors musik garage", "");
            Room r3 = new Room("", "");
            Room r4 = new Room("", "");
            Room r5 = new Room("", "");
            Room r6 = new Room("", "");
            Room r7 = new Room("", "");
            Room r8 = new Room("", "");
            Room r9 = new Room("", "");
            Room r10 = new Room("Randers regnskov", "varm fugtig skov fyldt med mokai.");
            Room r11 = new Room("Det hvide hus", "tilfædigt lille sommerhus i udkanten af regnskoven.");
            Room r12 = new Room("Det rigtige hvide hus", "stort hus hvor supreme leader of USA bor.");
            Room r13 = new Room("", "");
            Room r14 = new Room("", "");
            Room r15 = new Room("", "");
            Room r16 = new Room("", "");
            Room r17 = new Room("Gammelt slot", "stort slot fyldt med gamle ting.");

            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);

            r1.AddEast(r2);
            r2.AddWest(r1);
            r2.AddNorth(r3);
            r3.AddSouth(r2);
            r3.AddEast(r4);

        }

        public void PrintWorld()
        {
            foreach (Room r in rooms)
            {
                Console.WriteLine(r.ToString());
            }
        }
    }
}
