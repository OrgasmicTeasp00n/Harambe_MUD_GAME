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
            Room r2 = new Room("Storebrors musik garage", "Hyggelig jazz garage med en masse weed");
            Room r3 = new Room("Knuds varevogn", "Hvid varevogn med 'FREE CANDY' på siden");
            Room r4 = new Room("Mette's dungeon", "Sort rum med satanistiske symboler skrevet i blod med en masse i skrig i baggrunden");
            Room r5 = new Room("Tina's kontor", "Hyggeligt lille rum med en sød og kærlig ældre kvinde");
            Room r6 = new Room("Knud's loge", "Små håndlanger som siger øhh til du løber skrigende væk");
            Room r7 = new Room("Jeppe's regnerum", "mystisk talrum med tal og brøker på alle vægge");
            Room r8 = new Room("Bedstemors madstue", "gammel klam og lugtende stue med en masse fedende mad");
            Room r9 = new Room("Laursen's kemilokale", "diamanter lavet af damptryk, med en masse malerier med vejen over stofmængde");
            Room r10 = new Room("Randers regnskov", "varm fugtig skov fyldt med mokaifugle.");
            Room r11 = new Room("Det hvide hus", "tilfædigt lille sommerhus i udkanten af regnskoven.");
            Room r12 = new Room("Det rigtige hvide hus", "stort hus hvor supreme leader of USA bor.");
            Room r13 = new Room("Ahmed's drømmerum", "Drømmerummet med 69 våde jomfruer der fodrer dig med vindruer");
            Room r14 = new Room("CIA's afhøringslokale", "Skræmmende afhøringslokale med en masse toturerings våben");
            Room r15 = new Room("The faggot room", "Rummet med alle autister der suger på deres slush-ice til du besvimer");
            Room r16 = new Room("Sultan's helvede", "Standard rum hvor du skal finde alt selv via google");
            Room r17 = new Room("Gammelt slot", "stort slot fyldt med gamle ting.");

            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);

            r1.AddNorth(r2);
            r1.AddSouth(r15);
            r1.AddEast(r6);
            r2.AddSouth(r1);
            r2.AddWest(r3);
            r3.AddEast(r2);
            r3.AddWest(r4);
            r4.AddEast(r3);
            r4.AddNorth(r5);
            r5.AddSouth(r4);
            r5.AddEast(r16);
            r16.AddSouth(r3);
            r6.AddWest(r1);
            r6.AddEast(r7);
            r7.AddWest(r6);
            r7.AddNorth(r8);
            r7.AddSouth(r9);
            r8.AddSouth(r7);
            r9.AddSouth(r14);
            r9.AddEast(r10);
            r10.AddEast(r11);
            r10.AddWest(r9);
            r11.AddWest(r10);
            r11.AddNorth(r12);
            r12.AddSouth(r11);
            r12.AddNorth(r13);
            r13.AddSouth(r12);
            r13.AddNorth(r17);
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
