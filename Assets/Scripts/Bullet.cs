using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulllet : MonoBehaviour
{
    public float speed;
    //public GameObject pt;

    private void Start()
    {
        Destroy(this.gameObject,4f);
    }

    private void Update()
    {
        transform.Translate(0,speed * Time.deltaTime,0);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DestroyPanel")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Ball")
        {
            Destroy(this.gameObject);
        }
    }

}
