using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        
        public float rotationSpeed;

        public TankTypes tankType;

        public Material color;
    }

    public List<Tank> tankList;

    public TankView tankView;

    private TankModel tankModel;

    private TankController tankController;

    public void CreateTank(TankTypes tankType)
    {
        
        if(tankType == TankTypes.BlueTank)
        {
            tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
            tankController = new TankController(tankModel, tankView);
        }


        if(tankType == TankTypes.GreenTank)
        {
            tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankType, tankList[1].color);
            tankController = new TankController(tankModel, tankView);
        }

                
        if(tankType == TankTypes.RedTank)
        {
            tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankType, tankList[2].color);
            tankController = new TankController(tankModel, tankView);
        }

                
                
        

        /*switch (tankType)
        {
            case TankTypes.BlueTank:

                tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
                tankController = new TankController(tankModel, tankView);
                break;

            case TankTypes.GreenTank:

                tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankType, tankList[1].color);
                tankController = new TankController(tankModel, tankView);
                break;

            case TankTypes.RedTank:

                tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankType, tankList[1].color);
                tankController = new TankController(tankModel, tankView);
                break;
        }*/

    }
}
