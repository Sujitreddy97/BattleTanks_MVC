using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        this.tankModel = _tankModel;
        this.tankView = GameObject.Instantiate<TankView>(_tankView);

        rb = tankView.GetComponent<Rigidbody>();
        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        tankView.ChangeColor(tankModel.GetColor());
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
}
