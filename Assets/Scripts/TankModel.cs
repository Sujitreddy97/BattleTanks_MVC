using UnityEngine;

public class TankModel
{
    private TankController tankController;
    private float movementSpeed;
    private float rotationSpeed;

    public TankModel(float _movementSpeed, float _rotationSpeed)
    {
        this.movementSpeed = _movementSpeed;

        this.rotationSpeed = _rotationSpeed;

    }

    public void SetTankController(TankController _tankController)
    {
        this.tankController = _tankController;
    }

    public float GetMovementSpeed()
    {
        return movementSpeed;
    }

    public float GetRotationSpeed()
    {
        return rotationSpeed;
    }
}



