using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float thrust;
    public float rotateThrust;
    public Fuel fuel2;
    public float scoreValue;
    //public float score = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Flying();
        RocketRotate();
        Score score = FindObjectOfType<Score>();
        score.Scorer(scoreValue);


    }
    void Flying()
    {
        
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddRelativeForce(Vector3.up * thrust);
            //score += Time.deltaTime;
            Score score = FindObjectOfType<Score>();
            score.Scorer(scoreValue);
        }
        
        
    }
    void RocketRotate()
    {
        rb.freezeRotation = true;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotateThrust * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward * rotateThrust * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
