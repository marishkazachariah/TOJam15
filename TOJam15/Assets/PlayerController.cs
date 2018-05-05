using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject Pancake;
    public Transform foodPosition;
    private Vector3 FoodInstantiate;

    // Use this for initialization
    void Start () {
        FoodInstantiate = foodPosition.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Pancake, FoodInstantiate, Quaternion.identity);
        }
		
	}
}
