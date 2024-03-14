using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Methods : MonoBehaviour
{
    [SerializeField]
    float for_velovity;

    public static Methods _methods;

    [SerializeField]
    private List<GameObject> gameObjects;
    

    public List<Vector3> Vector_list = new List<Vector3>();
    public List<Color> Color_list = new List<Color>();
    public List<int> _count = new List<int>();
    public int _index_count_color = 0;
    private int indexstor;

    // Start is called before the first frame update
    private void Awake()
    {
        if (_methods == null) _methods = this;
        else _methods = this;
    }

    // ----------------------------------------------------------------- Update -------------------------------------------------------------------

    private void Update()
    {
        if (_index_count_color <= 0)
        {
            _index_count_color = indexstor;
        }
    }

    // ----------------------------------------------------------------- Vector -------------------------------------------------------------------


    public void Velocity_Set(ref Rigidbody2D rb,float _velocity)
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity,_velocity);
    }



    // return random ball siez this method
    public Vector3 Vector_Set_Random()
    {
        Vector3 pos = Vector_list[Random.Range(0, Vector_list.Count)];
        return pos;

    }


    // return ball siez this method
    public Vector3 Vector_Set(int num)
    {
        Vector3 vector_set = Vector_list[num];

        return vector_set;

    }

    public Vector3 _RandomPos()
    {
        // left or right spon

        int count;
        Vector3 F1;
        Vector3 F2;
        F1 = new Vector3(-2.5f, Random.Range(1, 3), 0);
        F2 = new Vector3( 2.5f, Random.Range(1, 3), 0);
        count = Random.Range(1, 2);
       
        if(count == 1) 
        {
            return F1;
        } 
        if(count == 2) 
        {
            return F2;
        }
        else
        {
            return Vector3.zero;
        }
    }



    public void _Decrement()
    {
        _index_count_color--;
    }

    // ----------------------------------------------------------------- GameObjects ---------------------------------------------------------------



    public GameObject _gameobject(string _name)
    {
        foreach (GameObject itemname in gameObjects)
        {
            if (itemname.name == _name)
            {
                return itemname;
            }
        }
        return null;
    }

    // ----------------------------------------------------------------- Rigidbody2D ---------------------------------------------------------------

    public Rigidbody2D Move_velocity(ref Rigidbody2D rb,bool velocity_bool)
    {
        if(velocity_bool == true)
        {
            rb.velocity = new Vector2(for_velovity,rb.velocity.y);
            return rb;
        }

        if (velocity_bool == false)
        {
            rb.velocity = new Vector2(-for_velovity, rb.velocity.y);
            return rb;
        }

        return rb;
    }

    // ----------------------------------------------------------------- Color ---------------------------------------------------------------------
    public void at_count(int num)
    {
        _index_count_color = num / 5;
        indexstor = _index_count_color;
    }

    public void runtime(int runtimeindex)
    {
        //_index_count_color = runtimeindex;
        if(_index_count_color <= 0)
        {
            _index_count_color = indexstor;
        }
    }

    public Color _GetColor(int num)
    {
        switch (num)
        {
            case 1:
                return Color_list[0];
                break;

            case 2:
                return Color_list[1];
                break;

            case 3:
                return Color_list[2];
                break;

            case 4:
                return Color_list[3];
                break;

            case 5:
                return Color_list[4];
                break;

            default:
                return Color.red;
               
        }
    }

}
