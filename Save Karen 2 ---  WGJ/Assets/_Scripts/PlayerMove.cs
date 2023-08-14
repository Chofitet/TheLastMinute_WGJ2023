using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    SpriteRenderer sprite;
    Vector2 vectorPosition;
    float LastPosition;
    bool moving;
    [SerializeField] float speed;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            vectorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float Side = LastPosition - vectorPosition.x;
            LastPosition = vectorPosition.x;
          
            moving = true;

            if (Side < LastPosition)
            {
                // mira a la izquierda
                sprite.flipX = true;
            }
            else sprite.flipX = false;
        }

        if (moving && transform.position.x != LastPosition)
        {
            float step = speed * Time.deltaTime;
            transform.position= Vector2.MoveTowards(transform.position, new Vector2 (LastPosition, transform.position.y), step);
        }
        else moving = false;

       
    }
}
