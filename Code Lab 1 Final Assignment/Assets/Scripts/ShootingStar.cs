using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStar : MonoBehaviour
{
    public float speedforce = 1f;
    public float time = 1f;
    private Rigidbody rb;

    float position;

    /*private void Awake()
    {
        
    }*/
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ParticleSystem>().Play();
        ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
        em.enabled = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("MovingStar", time);
    }

    void MovingStar()
    {
        GetComponent<ParticleSystem>().Play();
        ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
        em.enabled = true; 
        rb.AddForce((transform.forward * -1) * speedforce);
    }
}
