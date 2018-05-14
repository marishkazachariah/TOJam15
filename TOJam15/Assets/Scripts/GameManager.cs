using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public Transform[] SpawnPoints;
    public GameObject[] Food;
    //public float spawn;
    [SerializeField] 
    private float spawnOverTime = 2;      //as time goes on it spawns 
    public GameObject Sparkle;
    public Transform foodPosition;
    private Vector3 FoodInstantiate;
    void Start () {
        InvokeRepeating("SpawnFood", spawnOverTime, spawnOverTime);
        FoodInstantiate = foodPosition.transform.position;
    }

    void Update()
    {

    }  
	
    public void OnRestart()
    {
        StartCoroutine(EndGame());
    }

    public void SpawnFood()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        int objectIndex = Random.Range(0, Food.Length);
        Instantiate(Food[objectIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
    }
	
    public IEnumerator EndGame()
    {
        Instantiate(Sparkle, FoodInstantiate, Quaternion.identity);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}
