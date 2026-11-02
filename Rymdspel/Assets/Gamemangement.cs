using UnityEngine;

public class Gamemangement : MonoBehaviour
{
    public PlayerShips playerShip;
    public GameObject Gunsight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Gunsight = GameObject.Find("Gunsight");
        if(Gunsight == null)
        {
            GameObject Gunsight = Instantiate(playerShip.Gunsight, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
