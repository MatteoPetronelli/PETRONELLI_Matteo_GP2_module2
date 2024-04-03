using System.Data.Common;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public PokemonDatabase database;
    private int etape;

    private void Start(){
        database.createData();
        PokemonData.Stats newStats;
        for (int i = 0; i < 8; i++)
        {
            if (i == 2 || i == 5)
            {
                i++;
            }
            if (i%2  == 1)
            {
                etape = 2;
            }
            if (i % 2 == 0)
            {
                etape = 3;
            }
            if (i == 0)
            {
                etape = 2;
            }
            newStats = database.datas[i+0].statsBase;
            LoadStatsTo(database.datas[i+1], newStats.GetStatsBy(newStats, 25, etape));
        }
    }

    public PokemonData GetData(int id) => database.datas[id];

    public void LoadStatsTo(PokemonData data, PokemonData.Stats stats)
    {
        data.statsBase = stats;
    }
}
