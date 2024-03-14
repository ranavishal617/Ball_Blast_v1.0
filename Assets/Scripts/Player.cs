using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Player : MonoBehaviour
{
    //public Rigidbody2D rb;
    public static Player _player;
    public float Speed;
    public GameObject Bulat;
    public float time = 1f;
    public float playtime = 0f;
    Touch touch;
    public Vector3 touchpos;
    public Vector3 offset;
    float Speedup = 100f;
    public bool _for_all_Balls;

    // Start is called before the first frame update
    void Start()
    {
        if(_player == null)
        {
            _player = this;
        }
        else
        {               
            _player = this;
        }
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input();
    }

    void input()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (Input.touchCount > 0 && time >= 2)
            {
                Instantiate(Bulat, new Vector2(transform.position.x, transform.position.y + 1.5f), Quaternion.identity);
                time = 0f;
                playtime = 0.06f;
            }

            if (touch.phase == TouchPhase.Moved)
            {
                touchpos = Camera.main.ScreenToWorldPoint(touch.position);
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(touchpos.x, transform.position.y), Speedup * Time.deltaTime);
                //transform.position = Vector2.Lerp(transform.position, new Vector2(touchpos.x,transform.position.y) , Speedup * Time.deltaTime);
            }
            _for_all_Balls = true;
        }
        if (playtime >= 0)
        {
            playtime -= Time.deltaTime;
            if (playtime <= 0f)
            {
                time = 2f;
                playtime = 0f;
            }
        }
        else
        {
            _for_all_Balls = false;
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Speed * Time.fixedDeltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(-Speed * Time.fixedDeltaTime, 0, 0);

        }

        if (Input.GetKey("s"))
        {
            //rb.velocity = Vector2.up * 7;
        }
        if (Input.GetKey("x") && time >= 2f)
        {
            Instantiate(Bulat, new Vector2(transform.position.x, transform.position.y + 0.6f), Quaternion.identity);
            time = 0f;
            playtime = 0.06f;
        }
    }
}
