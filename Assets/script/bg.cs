using UnityEngine;

public class bg : MonoBehaviour
{
    public float speed;
    public float endx;
    public float startx;
    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if(transform.position.x <= endx)
        {
            Vector2 pos = new Vector2(startx, transform.position.y);
            transform.position = pos;
        }
    }
}
