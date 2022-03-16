using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float yValue;
    Vector2 movePos;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public GameObject effect;
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, movePos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            movePos = new Vector2(transform.position.x, transform.position.y + yValue);
            transform.position = movePos;
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            Instantiate(effect, movePos, Quaternion.identity);
            movePos = new Vector2(transform.position.x, transform.position.y - yValue);
            transform.position = movePos;
           
        }
    }
}
