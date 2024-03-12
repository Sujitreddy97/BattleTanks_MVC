using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BulletController
{
    private BulletModel bulletModel;
    private BulletView bulletView;
    private GameObject target;
    public BulletController(BulletModel _bulletModel, Vector3 spawnPosition, Vector3 spawnDirection)
    {
        this.bulletModel = _bulletModel;

        this.bulletView = Object.Instantiate(bulletModel.GetBulletPrefab());
        bulletModel.SetDirection(spawnDirection);
        bulletView.SetBulletController(this);

        bulletView.Init(spawnPosition, spawnDirection);
        bulletView.transform.rotation = Quaternion.LookRotation(spawnDirection);
    }


    public void Update() => bulletView.UpdateVelocity(bulletModel.GetDirection() * bulletModel.GetBulletSpeed());


    public void HandleCollision(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            ApplyBulletDamage(collision.gameObject);
        }
        else if (collision.gameObject.layer == 3)
        {
            DestroyGameObject(this.bulletView.gameObject);
        }
    }

    private void DestroyGameObject(GameObject gameObject) => GameObject.Destroy(gameObject);

    private void ApplyBulletDamage(GameObject target)
    {
        switch (bulletModel.GetBulletType())
        {
            case BulletTypes.HighlyExplosiveMissile:

                highlyExplosive(target);
                DestroyGameObject(this.bulletView.gameObject);
                break;

            case BulletTypes.FastMissile:

                FastMissile(target);
                DestroyGameObject(this.bulletView.gameObject);
                break;

            case BulletTypes.SlowMissile:

                SlowMissile(target);
                DestroyGameObject(this.bulletView.gameObject);
                break;
        }

    }


    private void highlyExplosive(GameObject target)
    {
        int layerMask = LayerMask.GetMask("Enemies");

        Collider[] colliders = Physics.OverlapSphere(target.transform.position, 10f, layerMask);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();

            //Need to implement(reduce the enemy health)
            if (rb != null)
            {
                rb.AddExplosionForce(1000f, target.transform.position, 10f);
            }
        }
    }

    private void FastMissile(GameObject target)
    {
        Collider collider = target.GetComponent<Collider>();
        //Need to implement(reduce the enemy health)
        //Fast but less damagable
        if (collider != null)
        {
            GameObject.Destroy(collider.gameObject);
        }
    }

    private void SlowMissile(GameObject target)
    {
        Collider collider = target.GetComponent<Collider>();
        //Need to implement(reduce the enemy health)
        //Slow but highly damagable
        if (collider != null)
        {
            GameObject.Destroy(collider.gameObject);
        }
    }
}
