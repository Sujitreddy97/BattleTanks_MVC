using UnityEngine;

public class BulletModel
{
    private float bulletSpeed;
    private float damageRate;
    private BulletController bulletController;
    private Vector3 direction;
    private BulletScriptableObject bulletScriptableObject;

    private BulletView bulletPrefab;

    public BulletModel(BulletScriptableObject _bulletScriptableObject)
    {
        bulletScriptableObject = _bulletScriptableObject;
        bulletSpeed = bulletScriptableObject.bulletSpeed;
        damageRate = bulletScriptableObject.damageRate;
        bulletPrefab = bulletScriptableObject.bulletObject;
    }

    public BulletView GetBulletPrefab()
    {
        return bulletPrefab;
    }

    public float GetBulletSpeed()
    {
        return bulletSpeed;
    }

    public float GetDamageRate() 
    {
        return damageRate;
    }

    public void SetDirection(Vector3 direction)
    {
        this.direction = direction;
    }

    public Vector3 GetDirection()
    {
        return this.direction;
    }
}
