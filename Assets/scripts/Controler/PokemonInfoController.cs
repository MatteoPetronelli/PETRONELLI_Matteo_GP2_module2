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
    [SerializeField] private Text txtPv;
    [SerializeField] private Text txtAtk;
    [SerializeField] private Text txtDef;
    [SerializeField] private Text txtAtkSpe;
    [SerializeField] private Text txtDefSpe;
    [SerializeField] private Text txtSpeed;
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
        txtWeight.text = $"Poids : {data.info.weight.ToString("f1")} kg";
        txtSize.text = $"Taille : {data.info.size.ToString("f1")} m";
        txtCategory.text = $"Catégorie : {data.info.category}";
        txtType.text = $"Type : {data.info.type[0].ToString()}, {data.info.type[1].ToString()}";
        txtCaption.text = $"Description : {data.info.caption}";
        txtPv.text = $"Pv : {data.statsBase.pv}";
        txtAtk.text = $"Atk : {data.statsBase.atk}";
        txtDef.text = $"Def : {data.statsBase.def}";
        txtAtkSpe.text = $"AtkSpe : {data.statsBase.atkSpe}";
        txtDefSpe.text = $"DefSpe : {data.statsBase.defSpe}";
        txtSpeed.text = $"Speed : {data.statsBase.speed}";
    }
}
