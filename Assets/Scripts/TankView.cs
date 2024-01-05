using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{

    private TankController tankController;
    
    public TankView()
    {
      
    }

    public void SetTankController(TankController _tankController)
    {
        this.tankController = _tankController;
    }

}
