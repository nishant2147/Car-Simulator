using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Speed += Time.deltaTime * 10f;
        transform.position += new Vector3(0f, (Time.deltaTime * -2f), 0f);

        if(transform.position.y <= -6.70f)
        {
            Destroy(gameObject);
        }
    }
}
