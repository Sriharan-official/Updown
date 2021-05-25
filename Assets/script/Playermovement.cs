using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Playermovement : MonoBehaviour
{
    
    
    private Vector2 target;
    public float yincrement;
    public float Speed;
    public float max;
    public float min;
    public float health = 3f;
    public GameObject effects;
    public Text hdis;
    public GameObject restart;
    public GameObject sound;


    private void Update()
    {
        
        hdis.text = health.ToString();
        if (health == 0) 
        {
            restart.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, target , Speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y  < max)
        {
            target = new Vector2(transform.position.x, transform.position.y + yincrement);
            Instantiate(effects, transform.position, Quaternion.identity);
            Instantiate(sound, transform.position, Quaternion.identity);
        }        
        
        if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > min)
        {
            target = new Vector2(transform.position.x, transform.position.y - yincrement);
            Instantiate(effects, transform.position, Quaternion.identity);
            Instantiate(sound, transform.position, Quaternion.identity);
        }
    }

    
}
