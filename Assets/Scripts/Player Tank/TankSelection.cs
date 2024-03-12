using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankService tankSpawner;

    public void CreateBlueTank()
    {
        tankSpawner.CreateTank(TankType.BlueTank);
        this.gameObject.SetActive(false);
    }

    public void CreateGreenTank()
    {
        tankSpawner.CreateTank(TankType.GreenTank);
        this.gameObject.SetActive(false);
    }

    public void CreateRedTank()
    {
        tankSpawner.CreateTank(TankType.RedTank);
        this.gameObject.SetActive(false);
    }

}
