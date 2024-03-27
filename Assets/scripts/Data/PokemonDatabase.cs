using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPokemonDatabase", menuName = "Database/Pokemon", order = 0)]
public class PokemonDatabase : ScriptableObject
{
    public List<PokemonData> datas = new();
    public void createData()
    {
        if(datas.Exists(datas => datas.name == "Zygarde")){
            return;
        }
        PokemonData newPoke = new(
            name : "Zygarde",
            icon : null,
            size : 5,
            weight : 305.0f,
            caption : "La forme que Zygarde prend lorsqu’il rassemble 50 % de ses Cellules. Sa mission est de surveiller l’écosystème.",
            category : "Equilibre",
            type : "Dragon Sol"
            //type : [PokemonData.types.Dragon, PokemonData.types.Sol]
        );
        datas.Add(newPoke);
    }
}
