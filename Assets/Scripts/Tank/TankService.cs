using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{

    [SerializeField] private List<TankScriptableObject> tankList;

    [SerializeField] private TankView tankView;

    private TankModel tankModel;

    private TankController tankController;

    public void CreateTank(TankTypes tankType)
    {
        
        if(tankType == TankTypes.BlueTank)
        {
            tankModel = new TankModel(tankList[0]);
            tankController = new TankController(tankModel, tankView);
        }


        if(tankType == TankTypes.GreenTank)
        {
            tankModel = new TankModel(tankList[1]);
            tankController = new TankController(tankModel, tankView);
        }

                
        if(tankType == TankTypes.RedTank)
        {
            tankModel = new TankModel(tankList[2]);
            tankController = new TankController(tankModel, tankView);
        }

    }
}
