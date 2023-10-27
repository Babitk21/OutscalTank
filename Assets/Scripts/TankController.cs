using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController{
    private TankModel _tankModel;
    private TankView _tankView;

    private Rigidbody rb;

    public TankController(TankModel tankModel, TankView tankView){
        _tankModel = tankModel;
        _tankView = GameObject.Instantiate<TankView>(tankView);
        rb = tankView.GetRigidBody();
        _tankModel.SetTankController(this);
        _tankView.SetTankController(this);
    }

    public void Move(float movement, float movementSpeed){
        rb.velocity = _tankView.transform.forward * movement * movementSpeed;
        Debug.Log("he");
    }

    public void Rotate(float rotate, float rotateSpeed){
        var vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel(){
        return _tankModel;
    }
}
