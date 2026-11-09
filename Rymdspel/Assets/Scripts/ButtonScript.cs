using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{
    [SerializeField] private PlayerShips intercepter;
    [SerializeField] private PlayerShips fighter;
    GameObject player;
    PlayerScript player_script;
    GameObject gameManager;
    public Gamemangement gamemanegement;
    
    protected bool isIntercepter;
    protected bool isFighter;
    void Awake()
    {
        gameManager = GameObject.Find("GameManeger");
        gamemanegement = gameManager.GetComponent<Gamemangement>();
        player = GameObject.FindWithTag("Player");
        player_script = player.GetComponent<PlayerScript>();
    }


    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ShipSelect_Intercepter()
    {
        //player_script.playerShip = intercepter;
        gamemanegement.playerShips = intercepter;
        player_script.ShipUppdate();
    }
    public void ShipSelect_Fighter()
    {
        //player_script.playerShip = fighter;
        gamemanegement.playerShips = fighter;
        
        player_script.ShipUppdate();
    }
}
