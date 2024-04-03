using System;
using System.Collections;
using System.Linq;
using UnityEngine;

public class PokemonObj : MonoBehaviour
{
    [Serializable]
    public struct PokemonData
    {
        public enum TYPES
        {
            NORMAL,
            FIRE,
            FIGHTING,
            WATER,
            FLYING,
            GRASS,
            POISON,
            ELECTRIC,
            GROUND,
            PSYCHIC,
            ROCK,
            ICE,
            BUG,
            DRAGON,
            GHOST,
            DARK,
            STEEL,
            FAIRY
        }

        public string name;
        public int hp;
        public int atk;
        public int def;
        public float weight;
        public TYPES type;
        public TYPES[] weakness;
        public TYPES[] resistances;
        public int currentHp;
        public int statsPoints;

        public PokemonData(string name, int hp, int atk, int def, float weight, TYPES type, TYPES[] weakness, TYPES[] resistances, int currentHp, int statsPoints)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.def = def;
            this.weight = weight;
            this.type = type;
            this.weakness = weakness;
            this.resistances = resistances;
            this.currentHp = currentHp;
            this.statsPoints = statsPoints;
        }
    }

    public GameObject PokemonOpponent;
    public PokemonData data = new PokemonData();

    private float cooldown = 1.0f;
    private float next_move = 0.15f;

    private void Awake()
    {
        InitCurrentLife();
        InitStatsPoints();
    }

    private void Update()
    {
        if (Time.time >= next_move)
        {
            AttackOpponent(data);
            next_move = Time.time + cooldown;
        }
    }

    public void InitCurrentLife()
    {
        data.currentHp = data.hp;
    }

    public void InitStatsPoints()
    {
        data.statsPoints = data.hp + data.atk + data.def;
    }

    public bool IsPokemonAlive(PokemonData Data)
    {
        if(Data.currentHp >= 0)
        {
            return true;
        }
        return false;
    }

    private int damage;

    public void TakeDamage(PokemonData Data)
    {
        damage = Data.atk;

        if (data.weakness.Contains(Data.type))
        {
            damage *= 2;
        }
        if (data.resistances.Contains(Data.type))
        {
            damage /= 2;
        }
        if (damage <= 0)
        {
            Debug.Log("The attack had no effect");
            return;
        }
        data.currentHp -= damage;
        Debug.Log("The attack did " + damage + " damage, " + data.name + " has " + data.currentHp + " hps");
    }

    public void AttackOpponent(PokemonData Data)
    {
        PokemonData pokemonOpponent = PokemonOpponent.GetComponent<PokemonObj>().data;
        if (IsPokemonAlive(Data) && IsPokemonAlive(pokemonOpponent))
        {
            TakeDamage(pokemonOpponent);
        }
        if (!IsPokemonAlive(Data))
        {
            Debug.Log(Data.name + " can't attack");
        }
    }
}

