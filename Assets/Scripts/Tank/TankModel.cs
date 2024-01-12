using UnityEngine;

public class TankModel
{
    private TankController tankController;

    private float movementSpeed;

    private float rotationSpeed;

    private TankTypes tankType;

    private Material color;


    public TankModel(float _movementSpeed, float _rotationSpeed, TankTypes _tankType, Material _color)
    {
        this.movementSpeed = _movementSpeed;

        this.rotationSpeed = _rotationSpeed;

        this.tankType = _tankType;

        this.color = _color;

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

    public Material GetColor() 
    {
        return color;
    }
}



