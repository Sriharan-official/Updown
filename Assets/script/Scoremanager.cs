using UnityEngine;
using UnityEngine.UI;

public class Scoremanager : MonoBehaviour
{

    
    public float score;
    public Text scoredis;
    public Playermovement mov;
    public Text highscore;

    private void Start()
    {
        highscore.text = "Highscore:" + PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
    public void Update()
    {
        if(mov.health >= 1)
        {
            
            int scr = (int)score;
            //int scr = Convert.ToInt32(score);
            scoredis.text = scr.ToString();
            if(scr > PlayerPrefs.GetInt("Highscore",0))
            {
                PlayerPrefs.SetInt("Highscore", scr);
                highscore.text = "Highscore:" + PlayerPrefs.GetInt("Highscore", 0).ToString();
                // or "Highscore:" + scr;
            
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Obstacle"))
        {
            
            score += 0.5f;
            


        }
    }
}

   

