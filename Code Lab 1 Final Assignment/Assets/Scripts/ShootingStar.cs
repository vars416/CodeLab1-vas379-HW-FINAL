using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStar : MonoBehaviour
{
    public float speedforce = 1f; //speed of shooting star
    public float time = 1f; //time in game's world at which the star will "shoot"
    private Rigidbody rb; //rigidbody of the gameobject

    private ParticleSystem ps; //particle system of the gameobject
    public bool emissionenabled; //bool to control the emission

    float position;

    /*private void Awake()
    {
        
    }*/
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>(); //get the particle system
        emissionenabled = false; //set bool to false
        /*gameObject.GetComponent<ParticleSystem>().Play();
        ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
        em.enabled = false;*/
        rb = GetComponent<Rigidbody>(); //get rigidbody of the gameobject
        gameObject.GetComponent<MeshRenderer>().enabled = false; //turn off this gameobject's mesh renderer
    }

    // Update is called once per frame
    void Update()
    {
        var emission = ps.emission; //emission is equal to ps.emission
        emission.enabled = emissionenabled; //ps.emmission's enabling is equal to the bool's value
        Invoke("MovingStar", time); //invoke MovingStar based on the time given above
    }

    /*private void FixedUpdate()
    {
        Invoke("MovingStar", time); //not using FixedUpdate because it was slowing the speed of stars for some reason

    }*/

    void MovingStar()
    {
        /*gameObject.GetComponent<ParticleSystem>().Play();
        ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
        em.enabled = true;*/
        emissionenabled = true; //turn on emission
        gameObject.GetComponent<MeshRenderer>().enabled = true; //turn on mesh renderer
        rb.AddForce((transform.forward * -1) * speedforce); //use addforce to move (shoot) stars
    }
}
