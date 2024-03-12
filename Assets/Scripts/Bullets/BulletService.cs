using System.Collections.Generic;
using UnityEngine;

public class BulletService
{
    private List <BulletController> activeBullets;
    private List <BulletScriptableObject> bulletList;

    public BulletService(List<BulletScriptableObject> _bulletSO)
    {
        this.bulletList = _bulletSO;
        this.activeBullets = new List<BulletController>();
    }

    public void CreateAndFireBullet(Vector3 spawnPosition, Vector3 moveDirection, BulletTypes bulletType)
    {
        if(bulletList != null)
        {
            if(bulletType == BulletTypes.HighlyExplosiveMissile)
            {
                BulletModel bulletModel = new BulletModel(bulletList[0]);
                activeBullets.Add(new BulletController(bulletModel, spawnPosition, moveDirection));
            }
            
            if(bulletType == BulletTypes.FastMissile)
            {
                BulletModel bulletModel = new BulletModel(bulletList[1]);
                activeBullets.Add(new BulletController(bulletModel, spawnPosition, moveDirection));
            }

            if(bulletType == BulletTypes.SlowMissile)
            {
                BulletModel bulletModel = new BulletModel(bulletList[2]);
                activeBullets.Add(new BulletController(bulletModel, spawnPosition, moveDirection));
            }
        }
        
    }

}

