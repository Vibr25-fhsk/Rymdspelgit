using UnityEngine;

[CreateAssetMenu(fileName = "PlayerShipweapons", menuName = "Scriptable Objects/PlayerShipweapons")]
public class PlayerShipweapons : ScriptableObject
{
    public float Attackdmg;
    
    public Vector3 WeaponVelocity;
    public float WeaponScuttleTime;
    
}
