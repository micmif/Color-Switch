 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        Debug.Log(collision.tag);
    }

    void setRandomColor()
    {
        int rand = Random.Range(0, 3);

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
