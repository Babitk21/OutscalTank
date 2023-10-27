using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour{
    private TankController _tankController;

    private float _movement;
    private float _rotation;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start(){
        var cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }

    // Update is called once per frame
    void Update(){
        Movement();
        if (_movement != 0){
            _tankController.Move(_movement, _tankController.GetTankModel().movementSpeed);
        }

        if (_rotation != 0){
            _tankController.Rotate(_rotation, _tankController.GetTankModel().rotationSpeed);
        }
    }

    private void Movement(){
        _movement = Input.GetAxis("Vertical");
        _rotation = Input.GetAxis("Horizontal");
    }
    
    public void SetTankController(TankController tankController){
        this._tankController = tankController;
    }

    public Rigidbody GetRigidBody(){
        return rb;
    }
}
