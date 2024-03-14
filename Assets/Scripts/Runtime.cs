using System.Collections.Generic;
using UnityEngine;

public class Runtime : MonoBehaviour
{
    public static Runtime _runtime;
    public List<Vector3> Siez = new List<Vector3>();
    public GameObject obj;
    private void Start()
    {
        if (_runtime == null) _runtime = this;
        else _runtime = this;
    }
 
}
