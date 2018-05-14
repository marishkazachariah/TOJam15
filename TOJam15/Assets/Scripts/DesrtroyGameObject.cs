using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesrtroyGameObject : MonoBehaviour {

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "destroyObjects")
            Destroy(gameObject);
    }
}
