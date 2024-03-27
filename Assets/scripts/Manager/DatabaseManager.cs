using System.Data.Common;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public PokemonDatabase database;

    private void Start(){
        database.createData();

        PokemonData.Stats newStats = database.datas[0].statsBase;
        LoadStatsTo(database.datas[1], newStats.GetStatsBy(newStats, 25, 2));
    }

    public PokemonData GetData(int id) => database.datas[id];

    public void LoadStatsTo(PokemonData data, PokemonData.Stats stats)
    {
        data.statsBase = stats;
    }
}
