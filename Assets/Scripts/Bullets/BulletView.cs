using System.Collections.Generic;
using UnityEngine;

public class BulletView : MonoBehaviour
{
    private BulletController bulletController;

    private float launchVelocity;

    void Start()
    {
        launchVelocity = bulletController.GetBulletModel().GetLaunchVelocity();
    }

    void Update()
    {
        bulletController.LaunchProjectile(launchVelocity);
    }

    public void SetBulletController(BulletController _bulletController)
    {
        this.bulletController = _bulletController;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Collider collider = collision.collider;

        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }

}