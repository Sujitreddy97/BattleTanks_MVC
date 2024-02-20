using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TankScriptableObject", menuName = "ScriptableObjects/TankScriptableObject")]
public class TankScriptableObject : ScriptableObject
{
    public float movementSpeed;

    public float rotationSpeed;

    public TankTypes tankType;

    public Material color;
}
