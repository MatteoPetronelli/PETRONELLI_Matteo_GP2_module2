using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]
public class PokemonData
{
    public string name;
    public Sprite icon;
    public float size;
    public float weight;
    public string caption;
    public string category;
    public string type;
    //public types[] type;

    public enum types
    {
        Normal,
        Feu,
        Combat,
        Eau,
        Vol,
        Plante,
        Poison,
        Electrik,
        Sol,
        Psy,
        Roche,
        Glace,
        Insecte,
        Dragon,
        Spectre,
        Ténèbres,
        Acier,
        Fée
    }

    public types[] weakness = new types[2];
    public types[] resistances = new types[2];

    [Serializable]
    public struct Stats
    {
        public int pv;
        public int atk;
        public int def;
        public int atkSpe;
        public int defSpe;
        public int speed;

        public  Stats (int pv, int atk, int def, int atkSpe, int defSpe, int speed){
            this.pv = pv;
            this.atk = atk;
            this.def = def;
            this.atkSpe = atkSpe;
            this.defSpe = defSpe;
            this.speed = speed;
        }

        public Stats(Stats statsBase, int coeff){
            pv = statsBase.pv * coeff;
            atk = statsBase.atk * coeff;
            def = statsBase.def * coeff;
            atkSpe = statsBase.atkSpe * coeff;
            defSpe = statsBase.defSpe * coeff;
            speed = statsBase.speed * coeff;
        }

        public Stats GetStatsBy(Stats statsBase, int level, int evolutionStep){
            var coeff = level * evolutionStep / 10;        
            return new Stats(statsBase, coeff);
        }
    }

    public Stats statsBase;
    public Stats statsSpe;
    public PokemonData(string name, Sprite icon, float size, float weight, string caption, string category, string type)
    {
        this.name = name;
        this.icon = icon;
        this.size = size;
        this.weight = weight;
        this.caption = caption;
        this.category = category;
        this.type = type;
    }
}


