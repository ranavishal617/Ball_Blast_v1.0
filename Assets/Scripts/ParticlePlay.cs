using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlay : MonoBehaviour
{
    ParticleSystem pt;
    // Start is called before the first frame update
    void Start()
    {
        pt = GetComponent<ParticleSystem>();
        pt.Play();
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        
        if (pt.isPlaying == false)
        {
            Destroy(this.gameObject);
        }
    }
}
