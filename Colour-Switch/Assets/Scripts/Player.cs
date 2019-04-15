 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string currentColor;
    public float jumpforce = 10f;
    public Rigidbody2D circle;
    public SpriteRenderer _sr;
    public Color blue;
    public Color yellow;
    public Color pink;
    public Color purple;
    public static int score = 0;
    public Text scoreText;

    // Update is called once per frame
    void Start()
    {
        setRandomColor();
    }
    void Update()
    {
        // If you press space or left click (0), the player will jump up.
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            circle.velocity = Vector2.up * jumpforce;
        }

        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.tag == "Score")
        {
          score++;
          Destroy(collision.gameObject);
          return;  
        }
        if(collision.tag == "ColorChanger")
        {
            setRandomColor();
            Destroy(collision.gameObject);
            return;
        }
        // if the color of the player doesn't match the segment they passed through
        // game is over.
        if(collision.tag != currentColor)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("You Died!");
            score = 0;
        }
    }

// This will randomise color of the player every time the game starts
    void setRandomColor()
    {
        int rand = Random.Range(0, 4);

        switch (rand)
        {
            case 0:
                currentColor = "Blue";
                _sr.color = blue;
                break;           
            case 1:
                currentColor = "Yellow";
                _sr.color = yellow; 
                break;          
            case 2:
                currentColor = "Pink";
                _sr.color = pink; 
                break;
            case 3:
                currentColor = "Purple";
                _sr.color = purple; 
                break;
        }
    }
}