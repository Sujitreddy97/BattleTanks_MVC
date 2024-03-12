using System.Collections.Generic;
using UnityEngine;

public class BulletView : MonoBehaviour
{
    private BulletController bulletController;

    private Rigidbody rb;

  
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Init(Vector3 spawnPosition, Vector3 spawnDirection)
    {
        this.transform.position = spawnPosition;
        this.transform.rotation = Quaternion.Euler(spawnDirection);
    }

    void Update()
    {
        if (bulletController != null)
        {
            bulletController.Update();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (bulletController != null)
        {
            bulletController.HandleCollision(collision);
        }
    }

    public void SetBulletController(BulletController _bulletController)
    {
        this.bulletController = _bulletController;
    }

    public void UpdateVelocity(Vector3 velocity)
    {
        rb.velocity = velocity;
    }
}