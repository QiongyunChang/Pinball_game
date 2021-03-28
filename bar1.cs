using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class bar1 : MonoBehaviour
{
    private int flag = 0;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow) )
        {
             
            if (flag == 0)
            {         
                GetComponent<Transform>().RotateAround(Vector3.up, -120f);              
                flag = 1;
            }               
        }
        else flag = 0;


        if (Input.GetKey(KeyCode.RightArrow))
        {

            if (flag == 0)
            {
                GetComponent<Transform>().RotateAround(Vector3.down, -120f);
                flag = 1;
            }
        }
        else flag = 0;


    }
}
