using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;
    private BulletService bulletService;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        this.tankModel = _tankModel;
        this.tankView = GameObject.Instantiate<TankView>(_tankView);

        rb = tankView.GetComponent<Rigidbody>();
        tankView.SetTankController(this);

        tankView.ChangeColor(tankModel.GetColor());
        bulletService = new BulletService(tankView.BulletScriptableObject);
    }

    public void Move(float movement, float movementSpeed)
    {
        rb.velocity = tankView.transform.forward * movement * movementSpeed;
    }

    public void Rotate(float rotate, float rotationSpeed) 
    {
        Quaternion deltaAngle = Quaternion.Euler(Vector3.up * rotate * rotationSpeed * Time.deltaTime);
        rb.MoveRotation(rb.rotation*deltaAngle);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }

    public void Shoot(Vector3 spwanPos, Vector3 moveDirection)
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            bulletService.CreateAndFireBullet(spwanPos, moveDirection);
        }
    }

}
