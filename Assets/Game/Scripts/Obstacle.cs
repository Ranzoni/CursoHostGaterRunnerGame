using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Rigidbody2D objRB;

    public GameConfiguration config;

    // Start is called before the first frame update
    void Start()
    {
        objRB = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        objRB.velocity = new Vector2(-config.speed, 0f);
    }
}
