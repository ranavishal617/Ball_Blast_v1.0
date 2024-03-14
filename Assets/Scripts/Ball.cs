using UnityEngine;
using UnityEngine.UI;
public class Ball : MonoBehaviour
{
    // Ball Force
    [Header("Ball_Force")]
    [SerializeField]
    float Big07;
    [SerializeField]
    float Midl53;
    [SerializeField]
    float Small23;

    [Header("Main")]
    #region Main Var

    [Header("General")]
    public Vector2 Velocity;
    public Rigidbody2D rb;
    private int _count = 0;
    public Text ShowHp = null;
    //public float velocity;
    public bool _right_left;
    [SerializeField]
    public float Show_Velocity;
    public float force;
    private SpriteRenderer _sprite;
    #endregion



    private void Start()
    {
        Physics2D.IgnoreLayerCollision(6, 6);
        _count = Random.Range(1, 50);
        rb = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
        Methods._methods.at_count(_count);
    }
    private void Update()
    {
        Methods._methods.runtime(_count);
        Systeminput();
        Show_Velocity = rb.velocity.y;
        Methods._methods.Velocity_Set(ref rb, Big07);
    }

    private void Systeminput()
    {
        ShowHp.text = _count.ToString();
        if(_count <= 0)
        {
            if(this.transform.localScale == Methods._methods.Vector_list[2])
            {
                Instantiate(Methods._methods._gameobject("pop"),new Vector3(transform.position.x, transform.position.y, transform.position.z -10), Quaternion.identity);
            }
            Destroy(this.gameObject);
            if(transform.localScale == Methods._methods.Vector_list[0])
            {
                for (int i = 0; i < 2; i++)
                {
                    GameObject ins = Methods._methods._gameobject("Ball");

                    ins.transform.localScale = Methods._methods.Vector_list[1];

                    Instantiate(ins,transform.position, Quaternion.identity);
                }
            }
        }

        Methods._methods.Move_velocity(ref rb,_right_left);

    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {     

        if (collision.gameObject.tag == "Right")
        {
            _right_left = false;
        }

        if (collision.gameObject.tag == "Left")
        {
            _right_left = true;
        }

        if (collision.gameObject.tag == "Ground")
        {
            rb.AddForceAtPosition(Vector2.up * force, transform.position, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            _count--;
            Methods._methods._Decrement();
            Destroy(collision.gameObject);
        }
    }


}
