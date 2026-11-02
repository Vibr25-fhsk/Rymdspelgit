using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerScript : MonoBehaviour
{

    public PlayerShips playerShip;
    public SpriteRenderer playerShipSR;
    public float playerMoveSpeed;
    public Vector2 moveInput;
    private Rigidbody2D playerRb;
    public PlayerShipweapons playerShipWeapon;
    public GameObject Gunsight;
    public Transform GunsightPos;
    Vector2 LastSightdirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerShipWeapon = playerShip.PlayerShipWeapon;
        playerMoveSpeed = playerShip.PlayerShipSpeed;
        playerShipSR = GetComponent<SpriteRenderer>();
        playerShipSR.sprite = playerShip.PlayerShipSprite;
        playerRb = GetComponent<Rigidbody2D>();
    }
    void Awake()
    {
        Gunsight = GameObject.Find("Gunsight");
        
        //Transform GunsightPos = Gunsight.transform;
        

    }

    // Update is called once per frame·
    void Update()
    {
        if(Gunsight != null)
        {
            GunsightPos = Gunsight.GetComponent<Transform>();
            Vector2 Sightdirection = GunsightPos.position - transform.position;
            if(LastSightdirection != Sightdirection)
            {
                transform.rotation = Quaternion.FromToRotation(Vector3.up, Sightdirection);
            }
            LastSightdirection = Sightdirection;
        }
        playerRb.linearVelocity = moveInput * playerMoveSpeed;
    }
    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
    public void PrimaryFire(InputAction.CallbackContext context)
    {

        if(playerShip.ShiphasWeapon == true)
        {
            if (context.started)
            {
                foreach (Vector3 offset in playerShip.PylonOffset)
                {
                    GameObject weapon = Instantiate(playerShipWeapon.WeaponPrefab, transform.position + offset, transform.rotation);
                    weapon.GetComponent<Rigidbody2D>().linearVelocity = this.transform.up * playerShipWeapon.WeaponVelocity;
                    weapon.GetComponent<SpriteRenderer>().sprite = playerShipWeapon.WeaponSprite;
                    Destroy(weapon, playerShipWeapon.ScuttleTime);
                }


            }
        }   
    }
    public void SecondaryFire(InputAction.CallbackContext context)
    {
        if(playerShip.ShiphasSecondaryWeapon == true)
        {
            if (context.started)
            {
                if (playerShip.hasWeaponOnLeftPylon == true)
                {
                    Debug.Log("Firing Left Pylon Weapon");
                    
                }
                if (playerShip.hasWeaponOnRightPylon == true)
                {
                    Debug.Log("Firing Right Pylon Weapon");
                    
                }
            }
        }
    }
}
