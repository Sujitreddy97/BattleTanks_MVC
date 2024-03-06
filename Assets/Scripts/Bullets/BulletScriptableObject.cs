using UnityEngine;

[CreateAssetMenu(fileName = "BulletScriptableObject", menuName = "ScriptableObjects/BulletScriptableObject")]
public class BulletScriptableObject : ScriptableObject
{
    public BulletTypes bulletType;
    public float bulletSpeed;
    public float damageRate;
    public BulletView bulletObject;
}
