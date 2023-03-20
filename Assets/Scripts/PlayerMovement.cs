using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float yValue;
    Vector2 movePos;

    public float speed;
    public float maxHeight;
    public float minHeight;
    public Text txtHealth;

    public GameObject gameOver;
    //public GameObject effect;
    private CameraShake cameraShake;
    public ScoreManager score;

    public int health = 4;

    private void Start()
    {
        gameOver.SetActive(false);
        cameraShake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<CameraShake>();
    }


  
    void Update()
    {

        txtHealth.text = health.ToString();
        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
            Destroy(score);
            
        }

        transform.position = Vector2.MoveTowards(transform.position, movePos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            //Instantiate(effect, transform.position, Quaternion.identity);
            cameraShake.camShake();
           // Instantiate(effect, transform.position, Quaternion.identity);
            movePos = new Vector2(transform.position.x, transform.position.y + yValue);
            transform.position = movePos;
            

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            // Instantiate(effect, movePos, Quaternion.identity);
            cameraShake.camShake();
           // Instantiate(effect, transform.position, Quaternion.identity);
            movePos = new Vector2(transform.position.x, transform.position.y - yValue);
            transform.position = movePos;
           

        }
    }
}
