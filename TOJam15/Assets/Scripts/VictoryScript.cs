using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryScript : MonoBehaviour
   
{
    private ParticleSystem victoryParticle;
    public RandomTextGenerator textGenerator;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "food")
        {
            victoryParticle =col.transform.Find("stars").gameObject.GetComponent<ParticleSystem>();
            victoryParticle.Play();
            textGenerator.SetVictoryText();
        }
    }       
}