using UnityEngine;

[CreateAssetMenu(fileName = "EnemyShips", menuName = "Scriptable Objects/EnemyShips")]
public class EnemyShips : ScriptableObject
{
    public string EnemyShipName;
    public int EnemyShipHealth;
    public float EnemyShipSpeed;
    public Sprite EnemyShipSprite;
    public float EnemyShipWeaponCooldown;
    public bool ShiphasWeapon;
    public Vector3[] PylonOffset;
}
