using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinusoidal : MonoBehaviour
{
    public float moveSpeed;
    public float frequency;
    public float magnitude;

    public GlobalValues GValueScript;

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
        position += transform.right * GValueScript.MoveSpeed * Time.deltaTime;
        transform.position = position + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
    }

    public void increaseMoveSpeed()
    {
        moveSpeed += 5;
    }
}
