using UnityEngine;

public class TankModel
{
    private TankController tankController;

    private float movementSpeed;

    private float rotationSpeed;

    private TankType tankType;

    private Material color;

    private TankScriptableObject tankScriptableObject;

    private BulletTypes bulletType;

    private float attackRate;

    public TankModel(TankScriptableObject _tankScriptableObject)
    {
        this.tankScriptableObject = _tankScriptableObject;

        this.movementSpeed = _tankScriptableObject.movementSpeed;

        this.rotationSpeed = _tankScriptableObject.rotationSpeed;

        this.tankType = _tankScriptableObject.tankType;

        this.color = _tankScriptableObject.color;
        
        this.bulletType = _tankScriptableObject.bulletType;

        this.attackRate = _tankScriptableObject.attackRate;
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

    public BulletTypes GetBulletType()
    {
        return bulletType;
    }

    public float GetAttackRate()
    {
        return attackRate;
    }
}



