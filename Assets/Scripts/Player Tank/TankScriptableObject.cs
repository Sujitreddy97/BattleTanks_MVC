using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TankScriptableObject", menuName = "ScriptableObjects/TankScriptableObject")]
public class TankScriptableObject : ScriptableObject
{
    public float movementSpeed;

    public float rotationSpeed;

    public TankType tankType;

    public Material color;

    public BulletTypes bulletType;

    public float attackRate;
}
