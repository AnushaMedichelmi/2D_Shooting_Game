using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    public int score;

    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, bulletSpeed, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroy(collision.gameObject);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            GameObject.Find("Player").SendMessage("Score");
        }
    }
}