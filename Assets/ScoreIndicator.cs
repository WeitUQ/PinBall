using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreIndicator : MonoBehaviour
{
    private int score;  
    private GameObject scoretext;
    
    // Start is called before the first frame update
    void Start()
    {       
        this.scoretext = GameObject.Find("ScoreText");
        this.scoretext.GetComponent<Text>().text = "score:0";
    }

     public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.score += 30;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 20;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 50;
        } 
         this.scoretext.GetComponent<Text>().text = "score:" + this.score;
        
    }
   void Update()
    {

    } 
}
