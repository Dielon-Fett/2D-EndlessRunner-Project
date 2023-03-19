using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed = 1;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    speed += 1;
        //}

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerMovement>().health -= damage;
            Debug.Log(collision.GetComponent<PlayerMovement>().health);
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Respawn"))
        { 
            Destroy(gameObject);
        }
        
    }
}
