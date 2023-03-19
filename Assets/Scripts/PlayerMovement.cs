using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float yValue;
    Vector2 movePos;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 4;

   // public GameObject effect;
    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        transform.position = Vector2.MoveTowards(transform.position, movePos, speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            //Instantiate(effect, transform.position, Quaternion.identity);
            movePos = new Vector2(transform.position.x, transform.position.y + yValue);
            transform.position = movePos;
            
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
           // Instantiate(effect, movePos, Quaternion.identity);
            movePos = new Vector2(transform.position.x, transform.position.y - yValue);
            transform.position = movePos;
           
        }
    }
}
