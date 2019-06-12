using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinusoidal : MonoBehaviour
{
    public float moveSpeed;
    public float frequency;
    public float magnitude;

    public GlobalValues GValueScript;

    public enum Side{LeftSide, RightSide};
    public Side Direction;


    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        GValueScript = GameObject.Find("Global").GetComponent<GlobalValues>();

        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        birdMove();
    }

   public void birdMove()
    {
        //position +=transform.right * moveSpeed * Time.deltaTime;
        if(Direction == Side.LeftSide)
        {
            if (transform.position.x >= 35)
            {
                gameObject.SetActive(false);
                GameObject.FindObjectOfType<GameManager>().Birds.Add(gameObject);
            }

            position += transform.right * GValueScript.MoveSpeed * Time.deltaTime;
            transform.position = position + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
        }else if(Direction == Side.RightSide)
        {
            if (transform.position.x <= -35)
            {
                gameObject.SetActive(false);
                gameObject.transform.localScale = Vector3.one;
                GameObject.FindObjectOfType<GameManager>().Birds.Add(gameObject);
            }

            position += -transform.right * GValueScript.MoveSpeed * Time.deltaTime;
            transform.position = position + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
        }

    }

    public void increaseMoveSpeed()
    {
        moveSpeed += 5;
    }
}
