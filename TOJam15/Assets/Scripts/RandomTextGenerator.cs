using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RandomTextGenerator : MonoBehaviour
{
    public Text VictoryText;
    string[] randomText = new string[10] {"Now You're Flappin!", "You're Flappin' Real Good", "Heckin' Cool", "Heavenly", "AW YEAH", "We Should Be Roomates", "This Gives Me Life", "Effervescent", "Goat Bleeting", "I love you"};
    public float timer = 0f;
    public float secondaryTimer = 0f;
    bool hasTextRun = false;
    string myText = " ";
    // Use this for initialization
    void Start()
    {
        timer += Time.deltaTime;
    }


    void Update()
    {
        //timer += Time.deltaTime;

        //if (timer >= 30)
        //{
        //    myText = randomText[Random.Range(0, randomText.Length)];
        //    hasTextRun = true;
        //    timer = 0;
        //}

        //if (hasTextRun == true)
        //{
        //    secondaryTimer += Time.deltaTime;
        //    if (secondaryTimer >= 15)
        //    {

        //        myText = " ";
        //        secondaryTimer = 0;
        //        hasTextRun = false;
        //    }
        //}
    }
 
    public void SetVictoryText()
    {
        StartCoroutine(StartText());
    }

    public IEnumerator StartText()
    {
        myText = randomText[Random.Range(0, randomText.Length)];
        yield return new WaitForSeconds(3);
        myText = "";
    }
    void UpdateGUI()
    {
        VictoryText.text = myText;
    }
}