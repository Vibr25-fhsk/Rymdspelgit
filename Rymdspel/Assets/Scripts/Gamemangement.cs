using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Gamemangement : MonoBehaviour
{
    public PlayerShips playerShips;
    public GameObject Gunsight;
    public GameObject player;
    public GameObject playershipPrefab;
    public bool EnemyCanSpawn;
    //public GameObject[] EnemyShips;
    public GameObject[] EnemyShips;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //public List<EnemyShipData> enemyShiplist;

    void Awake()
    {
        if(SceneManager.GetActiveScene().name == "GameScene")
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {

        if(SceneManager.GetActiveScene().name == "GameScene")
        {
            
            if(EnemyCanSpawn == true)
            {
                StartCoroutine(EnemySpawner());
            }
            else
            {
                StopCoroutine(EnemySpawner());
            }
            
            player = GameObject.FindWithTag("Player");
            if(player == null)
            {
                GameObject player = Instantiate(playershipPrefab, transform.position, Quaternion.identity);
            }
            Gunsight = GameObject.Find("Gunsight");
            if(Gunsight == null)
            {
                GameObject Gunsight = Instantiate(playerShips.Gunsight, transform.position, Quaternion.identity);
            }
        }


    }
    public IEnumerator RandomEnemy()
    {
        yield return new WaitForSeconds(1f);
        yield return null;
    }
    public IEnumerator EnemySpawner()
    {
        yield return new WaitForSeconds(1f);

        yield return null;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
