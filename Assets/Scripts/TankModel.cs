using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel{
    private TankController _tankController;

    public float movementSpeed;
    public float rotationSpeed;
    public TankModel(float _movement, float _rotationSpeed){
        movementSpeed = _movement;
        this.rotationSpeed = _rotationSpeed;
    }

    public void SetTankController(TankController tankController){
        this._tankController = tankController;
    }
}
