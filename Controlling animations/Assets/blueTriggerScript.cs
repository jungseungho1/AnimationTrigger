using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueTriggerScript : MonoBehaviour {

    public GameObject cube;
    Animator anim;
    public ParticleSystem Particlez;

    void Start()
    {
        anim = cube.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Blue")
        {
            anim.SetTrigger("makeBlue");
            Particlez.Play();
        }
        if(other.gameObject.tag == "Cube")
        {
            anim.SetTrigger("makeShrink");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Blue")
        {
            anim.SetTrigger("stopBlue");
            Particlez.Stop();
        }
        if (other.gameObject.tag == "Cube")
        {
            anim.SetTrigger("stopShrink");
        }
    }
}
