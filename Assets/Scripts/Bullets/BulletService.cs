using System.Collections.Generic;
using UnityEngine;

public class BulletService : MonoBehaviour
{
    private List <BulletController> activeBullets;
    private BulletScriptableObject bulletSO;

    public BulletService(BulletScriptableObject _bulletSO)
    {
        this.bulletSO = _bulletSO;
        this.activeBullets = new List<BulletController>();
    }

    public void CreateAndFireBullet(Vector3 spawnPosition, Vector3 moveDirection)
    {
        BulletModel bulletModel = new BulletModel(bulletSO);
        activeBullets.Add( new BulletController(bulletModel, spawnPosition, moveDirection));
    }

}

