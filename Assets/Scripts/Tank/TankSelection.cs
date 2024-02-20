using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankService tankSpawner;

    public void CreateBlueTank()
    {
        tankSpawner.CreateTank(TankTypes.BlueTank);
        this.gameObject.SetActive(false);
    }

    public void CreateGreenTank()
    {
        tankSpawner.CreateTank(TankTypes.GreenTank);
        this.gameObject.SetActive(false);
    }

    public void CreateRedTank()
    {
        tankSpawner.CreateTank(TankTypes.RedTank);
        this.gameObject.SetActive(false);
    }

}
