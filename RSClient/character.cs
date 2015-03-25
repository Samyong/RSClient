using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSClient.classes
{
    class character
    {
        const int DEF_ATK = 1, DEF_DEF = 1, DEF_STR = 1, DEF_RNG = 1, DEF_PRAY = 1, DEF_MAG = 1, DEF_RCING = 1, DEF_CON = 1, DEF_DUNG = 1, DEF_CONS = 1, DEF_AGI = 1, DEF_HERB = 1, DEF_THIEF = 1, DEF_CRAFT = 1, DEF_FLETCH = 1, DEF_SLAY = 1, DEF_HUNT = 1, DEF_DIV = 1, DEF_MINE = 1, DEF_SMITH = 1, DEF_FISH = 1, DEF_COOK = 1, DEF_FIREMAKING = 1, DEF_WOOD = 1, DEF_FARM = 1, DEF_SUMMON = 1;
        private int attack, defence, strength, ranged, prayer, magic, runecrafting, construction, dungeoneering, constitution, agility, herblore, thieving, crafting, fletching, slayer, hunter, divination, mining, smithing, fishing, cooking, firemaking, woodcutting, farming, summoning;

        public character()
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
            this.construction = DEF_CONS;
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
    }
}
