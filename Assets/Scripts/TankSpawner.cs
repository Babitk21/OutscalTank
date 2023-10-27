using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TankSpawner : MonoBehaviour{
    [FormerlySerializedAs("tankPrefab")] [SerializeField] private TankView tankView;

    private void Start(){
        CreateTank();
    }

    private void CreateTank(){
        TankModel tankModel = new TankModel(30, 20);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
