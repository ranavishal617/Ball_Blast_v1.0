//using System;
using System.Collections.Generic;
using UnityEngine;

public class Spon : MonoBehaviour
{
    public static Spon _spon;
    public float timespon = 5;
    public Vector3 savepos;
    public List<Vector3> Siez = new List<Vector3>();
    private void Start()
    {
        if (_spon == null) _spon = this;
        else _spon = this;
        savepos.y = 8f;
    }
    // Update is called once per frame
    void Update()
    {
        if(timespon >= 0) 
        {
            timespon -= Time.deltaTime;
        }
        else
        {   
            savepos.x = Random.Range(-4.5f,4.5f);
            timespon = Random.Range(1,3);
            AllTimeSpon(Methods._methods._gameobject("Ball"));
        }
    }

    public void AllTimeSpon(GameObject obj)
    {
        obj.transform.localScale = Siez[Random.Range(0,Siez.Count)];
        Instantiate(obj, savepos, Quaternion.identity);
    }

}
