using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{

    private TankController tankController;

    private float movementInput;

    private float rotationInput;

    private Rigidbody rb;

    public MeshRenderer[] childs;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(this.transform);
        cam.transform.position = new Vector3(0f, 3.5f, -6.5f);
    }

    private void Update()
    {
        Movement();

        if(movementInput !=0)
            tankController.Move(movementInput,tankController.GetTankModel().GetMovementSpeed());

        if(rotationInput !=0)
            tankController.Rotate(rotationInput, tankController.GetTankModel().GetRotationSpeed());
    }

    public void SetTankController(TankController _tankController)
    {
        this.tankController = _tankController;
    }

    private void Movement()
    {
        movementInput = Input.GetAxis("Vertical");
        rotationInput = Input.GetAxis("Horizontal");
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }

    public void ChangeColor(Material color)
    {
        for(int i = 0; i < childs.Length; i++) 
        {
            childs[i].material = color;
        }
    }

}
