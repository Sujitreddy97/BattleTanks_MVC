using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{

    public TankView tankView;

   
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(20f,20f);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
