﻿using System;
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

        
        List<Challenge> challenge;
        public Challenge()
        {
            challenges = new List<Challenge>();
            Challenge c1 = new Challenge("");
            Challenge c2 = new Challenge("");
            Challenge c3 = new Challenge("");
            Challenge c4 = new Challenge("");
            Challenge c5 = new Challenge("");
        }
    }
    }
}
