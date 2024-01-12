using UnityEngine;

public class BulletModel
{
    private float launchVelocity;
    private BulletController bulletController;

    public BulletModel(float _launchVelocity)
    {
       this.launchVelocity = _launchVelocity;
    }

    public void SetBulletController(BulletController _bulletController)
    {
        this.bulletController = _bulletController;
    }


    public float GetLaunchVelocity()
    {
        return launchVelocity;
    }
}
