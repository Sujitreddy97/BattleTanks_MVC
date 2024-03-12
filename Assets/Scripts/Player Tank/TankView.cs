using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TankView : MonoBehaviour
{

    private TankController tankController;

    private float movementInput;

    private float rotationInput;

    [SerializeField] private MeshRenderer[] childs;

    [SerializeField] private Transform shootTransform;

    [SerializeField] private List <BulletScriptableObject> bulletTypes;


    private void Start()
    { 
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

        FireBullet();
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

    public void ChangeColor(Material color)
    {
        for(int i = 0; i < childs.Length; i++) 
        {
            childs[i].material = color;
        }
    }

    public List <BulletScriptableObject> BulletScriptableObject 
    { 
        get
        {
            return bulletTypes; 
        } 
    }

   private void FireBullet()
   {
        Vector3 forwardDirection = shootTransform.forward;
        if (Input.GetMouseButtonDown(0))
        {
            tankController.Shoot(shootTransform.position, forwardDirection);
        }
   }
}
