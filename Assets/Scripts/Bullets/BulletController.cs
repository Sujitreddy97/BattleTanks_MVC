using UnityEngine;

public class BulletController
{
    private BulletModel bulletModel;
    private BulletView bulletView;

    public BulletController(BulletModel _bulletModel, Vector3 spawnPosition, Vector3 spawnDirection)
    {
        this.bulletModel = _bulletModel;

        this.bulletView = Object.Instantiate(bulletModel.GetBulletPrefab());
        bulletModel.SetDirection(spawnDirection);
        bulletView.SetBulletController(this);
      
        bulletView.Init(spawnPosition, spawnDirection);
        bulletView.transform.rotation = Quaternion.LookRotation(spawnDirection);
    }
    

    public void Update()
    {
        bulletView.UpdateVelocity(bulletModel.GetDirection() * bulletModel.GetBulletSpeed());
    }

    public void HandleCollision(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject.Destroy(collision.gameObject);
        } 
        else if(collision.gameObject.layer == 3)
        {
            DestroyBullet();
        }
    }

    private void DestroyBullet()
    {
        GameObject.Destroy(this.bulletView.gameObject);
    }
}
