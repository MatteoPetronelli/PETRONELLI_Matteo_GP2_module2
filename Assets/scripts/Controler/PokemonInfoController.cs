using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonInfoController : MonoBehaviour
{
    [SerializeField] private Image imgIcon;
    [SerializeField] private Text txtName;
    [SerializeField] private Text txtWeight;
    [SerializeField] private Text txtSize;
    [SerializeField] private Text txtCategory;
    [SerializeField] private Text txtType;
    [SerializeField] private Text txtCaption;
    [SerializeField] private int idPoke;

    private DatabaseManager databaseManager;

    private void Awake(){
        databaseManager = FindObjectOfType<DatabaseManager>();
    }

    private void Start(){
        RefreshUI(databaseManager.GetData(idPoke));
    }

    public void OnNext(){
        idPoke++;
        if(idPoke > databaseManager.database.datas.Count - 1){
            idPoke = 0;
        }
        RefreshUI(databaseManager.GetData(idPoke));
    }

    public void OnPrevious(){
        idPoke--;
        if(idPoke < 0){
            idPoke = databaseManager.database.datas.Count - 1;
        }
        RefreshUI(databaseManager.GetData(idPoke));
    }

    public void RefreshUI(PokemonData data){
        imgIcon.sprite = data.icon;
        txtName.text = data.name;
        txtWeight.text = $"Poids : {data.weight.ToString()} kg";
        txtSize.text = $"Taille : {data.size.ToString()} m";
        txtCategory.text = $"Catégorie : {data.category}";
        txtType.text = $"Type : {data.type}";
        txtCaption.text = $"Description : {data.caption}";
    }
}
