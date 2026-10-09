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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerShipWeapon = playerShip.PlayerShipWeapon;
        playerMoveSpeed = playerShip.PlayerShipSpeed;
        playerShipSR = GetComponent<SpriteRenderer>();
        playerShipSR.sprite = playerShip.PlayerShipSprite;
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame·
    void Update()
    {
        playerRb.linearVelocity = moveInput * playerMoveSpeed;
    }
    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
    public void Fire(InputAction.CallbackContext context)
    {

        if(playerShip.ShiphasWeapon == true)
        {
            if (context.performed)
            {
                if (playerShip.hasWeaponOnLeftPylon == true)
                {
                    
                    Debug.Log("Firing Left Pylon Weapon");
                }
                if (playerShip.hasWeaponOnRightPylon == true)
                {
                    Debug.Log("Firing Right Pylon Weapon");
                }
                if (playerShip.hasWeaponOnMiddlePylon == true)
                {
                    Debug.Log("Firing Middle Pylon Weapon");
                }
            }
        }
        
    }
}
