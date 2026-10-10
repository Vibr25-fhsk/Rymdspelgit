using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "PlayerShips", menuName = "Scriptable Objects/PlayerShips")]
public class PlayerShips : ScriptableObject
{
    public string PlayerShipName;
    public int PlayerShipHealth;
    public float PlayerShipSpeed;
    public Sprite PlayerShipSprite;
    public Vector3 RightPylon;
    public Vector3 LeftPylon;
    public Vector3 MiddlePylon;
    public PlayerShipweapons PlayerShipWeapon;
    public float PlayerShipWeaponCooldown;
    public bool ShiphasWeapon;
    public bool hasWeaponOnLeftPylon;
    public bool hasWeaponOnRightPylon;
    public bool hasWeaponOnMiddlePylon;
    public bool ShiphasSecondaryWeapon;
    
}
