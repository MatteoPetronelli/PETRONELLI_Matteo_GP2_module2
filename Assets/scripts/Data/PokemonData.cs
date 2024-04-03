using System;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]
public class PokemonData
{
    public string name;
    public Sprite icon;

    [Serializable]
    public struct Infos
    {
        public enum types
        {
            None,
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
        public float size;
        public float weight;
        public string caption;
        public string category;
        public types[] type;
        public types[] weakness;
        public types[] resistances;

        public Infos(float size, float weight, string caption, string category, types[] type, types[] weakness, types[] resistances)
        {
            this.size = size;
            this.weight = weight;
            this.caption = caption;
            this.category = category;
            this.type = type;
            this.weakness = weakness;
            this.resistances = resistances;
        }
    }

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

    public Infos info;
    public Stats statsBase;
    public Stats statsSpe;
    public PokemonData(string name, Sprite icon, Infos info)
    {
        this.name = name;
        this.icon = icon;
        this.info = info;
    }
}


