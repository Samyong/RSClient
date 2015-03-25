using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSClient
{
    class player
    {
        const int DEF_ATK = 1, DEF_DEF = 1, DEF_STR = 1, DEF_RNG = 1, DEF_PRAY = 1, DEF_MAG = 1, DEF_RCING = 1, DEF_CON = 1, DEF_DUNG = 1, DEF_CONS = 1, DEF_AGI = 1, DEF_HERB = 1, DEF_THIEF = 1, DEF_CRAFT = 1, DEF_FLETCH = 1, DEF_SLAY = 1, DEF_HUNT = 1, DEF_DIV = 1, DEF_MINE = 1, DEF_SMITH = 1, DEF_FISH = 1, DEF_COOK = 1, DEF_FIREMAKING = 1, DEF_WOOD = 1, DEF_FARM = 1, DEF_SUMMON = 1;
        private int attack {get; set;}
        private int defence {get; set;}
        private int strength {get; set;}
        private int ranged {get; set;}
        private int prayer {get; set;}
        private int magic {get; set;}
        private int runecrafting {get; set;}
        private int construction {get; set;}
        private int dungeoneering {get; set;}
        private int constitution {get; set;}
        private int agility {get; set;}
        private int herblore {get; set;}
        private int thieving {get; set;}
        private int crafting {get; set;}
        private int fletching {get; set;}
        private int slayer {get; set;}
        private int hunter {get; set;}
        private int divination {get; set;}
        private int mining {get; set;}
        private int smithing {get; set;}
        private int fishing {get; set;}
        private int cooking {get; set;}
        private int firemaking {get; set;}
        private int woodcutting {get; set;}
        private int farming {get; set;}
        private int summoning { get; set; }

        public player()
        {
            this.attack = DEF_ATK;
            this.defence = DEF_DEF;
            this.strength = DEF_STR;
            this.ranged = DEF_RNG;
            this.prayer = DEF_PRAY;
            this.magic = DEF_MAG;
            this.runecrafting = DEF_RCING;
            this.construction = DEF_CON;
            this.dungeoneering = DEF_DUNG;
            this.constitution = DEF_CONS;
            this.construction = DEF_CON;
            this.agility = DEF_AGI;
            this.herblore = DEF_HERB;
            this.thieving = DEF_THIEF;
            this.crafting = DEF_CRAFT;
            this.fletching = DEF_FLETCH;
            this.slayer = DEF_SLAY;
            this.hunter = DEF_HUNT;
            this.divination = DEF_DIV;
            this.mining = DEF_MINE;
            this.smithing = DEF_SMITH;
            this.fishing = DEF_FISH;
            this.cooking = DEF_COOK;
            this.firemaking = DEF_FIREMAKING;
            this.woodcutting = DEF_WOOD;
            this.farming = DEF_FARM;
            this.summoning = DEF_SUMMON;
        }
        public player(int atk, int def, int str, int rng, int pray, int mag, int rcing, int con, int dung, int cons, int agi, int herb, int thief, int craft, int fletch, int slay, int hunt, int div, int mine, int smith, int fish, int cook, int fire, int wood, int farm, int summon)
        {
            this.attack = atk; this.defence = def; this.ranged = rng; this.prayer = pray; this.magic = mag; this.construction = con; this.dungeoneering = dung; this.constitution = cons; this.agility = agi; this.herblore = herb; this.thieving = thief; this.crafting = craft; this.fletching = fletch; this.slayer = slay; this.hunter = hunt; this.divination = div; this.mining = mine; this.smithing = smith; this.fishing = fish; this.cooking = cook; this.firemaking = fire; this.woodcutting = wood; this.summoning = summon;
        }
    }
}
