using UnityEngine;

public class TankModel
{
    private TankController tankController;

    private float movementSpeed;

    private float rotationSpeed;

    private TankTypes tankType;

    private Material color;

    private TankScriptableObject tankScriptableObject; 

    public TankModel(TankScriptableObject _tankScriptableObject)
    {
        this.tankScriptableObject = _tankScriptableObject;

        this.movementSpeed = _tankScriptableObject.movementSpeed;

        this.rotationSpeed = _tankScriptableObject.rotationSpeed;

        this.tankType = _tankScriptableObject.tankType;

        this.color = _tankScriptableObject.color;
        
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



