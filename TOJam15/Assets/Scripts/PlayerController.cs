using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject Food;
    public Transform foodPosition;
    private Vector3 FoodInstantiate;
    public Collider DestroyFood;
    // Use this for initialization
    void Start () {
        FoodInstantiate = foodPosition.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Food, FoodInstantiate, Quaternion.identity);
        }		
	}  
}
