using UnityEngine;

[CreateAssetMenu(fileName = "PlayerShipweapons", menuName = "Scriptable Objects/PlayerShipweapons")]
public class PlayerShipweapons : ScriptableObject
{
    public float Attackdmg;
    //public Sprite WeaponSprite;
    public GameObject WeaponPrefab;
    public Sprite WeaponSprite;
    public float WeaponVelocity;
    public float ScuttleTime;

    
    
}
