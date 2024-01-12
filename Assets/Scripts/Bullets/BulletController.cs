using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController
{
    private BulletModel bulletModel;
    private BulletView bulletView;
    private Rigidbody rb;

    public BulletController(BulletModel _bulletModel, BulletView _bulletView)
    {
        this.bulletModel = _bulletModel;
        this.bulletView = GameObject.Instantiate<BulletView>(_bulletView);

        bulletModel.SetBulletController(this);
        bulletView.SetBulletController(this);

        rb = this.bulletView.GetComponent<Rigidbody>();
    }

    public BulletModel GetBulletModel()
    {
        return this.bulletModel;
    }

    public void LaunchProjectile(float velocity)
    {
        rb.AddRelativeForce(new Vector3(0, velocity,0));
    }

    public void Destroy(BulletView bullet)
    {
        GameObject.Destroy(bullet);
    }
    
}
