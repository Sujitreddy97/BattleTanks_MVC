using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{

    [SerializeField] private List<TankScriptableObject> tankList;

    [SerializeField] private TankView tankView;

    private TankModel tankModel;

    private TankController tankController;

    public void CreateTank(TankType tankType)
    {
        
        if(tankType == TankType.BlueTank)
        {
            tankModel = new TankModel(tankList[0]);
            tankController = new TankController(tankModel, tankView);
        }


        if(tankType == TankType.GreenTank)
        {
            tankModel = new TankModel(tankList[1]);
            tankController = new TankController(tankModel, tankView);
        }

                
        if(tankType == TankType.RedTank)
        {
            tankModel = new TankModel(tankList[2]);
            tankController = new TankController(tankModel, tankView);
        }

    }
}
