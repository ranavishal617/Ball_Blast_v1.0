using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimePlay : MonoBehaviour
{
    public ParticleSystem pt;
    public static DestroyTimePlay dp;
    // Start is called before the first frame update
    void Start()
    {
        if(dp == null)
        {
            dp = this;
        }
        else
        {
            dp = this;
        }
        pt = GetComponent<ParticleSystem>();
        pt.Play();   
    }  
    public void pos(GameObject _pos)
    {
        if(dp != null)
        transform.position = _pos.transform.position;    
    }
    private void Update()
    { 
        
    }
}
