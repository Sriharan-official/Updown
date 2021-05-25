using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public float multipler = 2f;
    public float duration = 2f;
    

    public GameObject pickupeffect;
    public float speed = 5f;
    public void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine (Pickup(other));
            Debug.Log("powerup");
        }
    }
    
    IEnumerator Pickup(Collider2D player)
    {
        Instantiate(pickupeffect, transform.position, transform.rotation);

        Playermovement stats = player.GetComponent<Playermovement>();
        
        stats.health += multipler;

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        

        yield return new WaitForSeconds(duration);
        stats.health -= multipler;
        

        Destroy(gameObject);
        Debug.Log("destroyed");


    }

}
