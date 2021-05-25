using UnityEngine;

public class Obstacle : MonoBehaviour

{
    public float damage = 1f;
    public float speed;
    public GameObject effects;
    public GameObject sound;
    private Shake shake;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("screenshake").GetComponent<Shake>();
        Destroy(gameObject, 10f);
    }


    public void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    
    public void OnTriggerEnter2D(Collider2D Collidingwith)
    {
        if (Collidingwith.CompareTag("Player"))
        {
            Instantiate(effects, transform.position, Quaternion.identity);
            Instantiate(sound, transform.position, Quaternion.identity);
            shake.CamShake();
            Collidingwith.GetComponent<Playermovement>().health -= damage;
            Debug.Log(Collidingwith.GetComponent<Playermovement>().health);
            Destroy(gameObject);
        }
    }
}
