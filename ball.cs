using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball : MonoBehaviour
{   
    static public int score = 0;
    public AudioSource waterm_audio, bar_audio, fruit_audio, score_audio;
    float SpeedUp = 2f;
    bool Automatic = true;
    Vector3 Goal = new Vector3(2.68f, 0.94f, 0.02f);

    // Start is called before the first frame update
    void Start()
    {

    }

   
    void Update()
    {
        if (Automatic)
        {
            transform.position = Vector3.MoveTowards(transform.position, Goal, Time.deltaTime * SpeedUp);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "bar")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-200, 0, 0));
            bar_audio.Play();
        }
        if (collision.gameObject.tag == "fruit")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-100, 0, -80));
            fruit_audio.Play();
        }
        if (collision.gameObject.tag == "waterm")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-80, 0, 50));
            waterm_audio.Play();
        }
        if (collision.gameObject.tag == "waterm")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-80, 0, 50));
            waterm_audio.Play();
        }
        if (collision.gameObject.tag == "one")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-35, 0, 40));
            score++;
            score_audio.Play();
        }
        if (collision.gameObject.tag == "two")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-30, 0, -20));
            score = score + 2 ;
            score_audio.Play();
        }
        if (collision.gameObject.tag == "three")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-40, 0, -50));
            score = score + 3;
            score_audio.Play();
        }
    }

}


