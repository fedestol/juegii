using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMov : MonoBehaviour
{
    public GameObject blueCube1;
    public GameObject blueCube2;
    public GameObject blueCube3;
    public GameObject blueCube4;
    public GameObject blueCube5;
    public float speedOfMov;
    public bool toRight;
    
    // Start is called before the first frame update
    void Start()
    {
        blueCube1.GetComponent<Renderer>().enabled = false;
        blueCube2.GetComponent<Renderer>().enabled = false;
        blueCube3.GetComponent<Renderer>().enabled = false;
        blueCube4.GetComponent<Renderer>().enabled = false;
        blueCube5.GetComponent<Renderer>().enabled = false;

        toRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1f)
        {
            if (toRight == true)
            {
                blueCube1.transform.position += new Vector3(0, 0, speedOfMov);
                blueCube3.transform.position += new Vector3(0, 0, speedOfMov);
                blueCube5.transform.position += new Vector3(0, 0, speedOfMov);

                blueCube2.transform.position -= new Vector3(0, 0, speedOfMov);
                blueCube4.transform.position -= new Vector3(0, 0, speedOfMov);
            }
            else
            {
                blueCube1.transform.position -= new Vector3(0, 0, speedOfMov);
                blueCube3.transform.position -= new Vector3(0, 0, speedOfMov);
                blueCube5.transform.position -= new Vector3(0, 0, speedOfMov);

                blueCube2.transform.position += new Vector3(0, 0, speedOfMov);
                blueCube4.transform.position += new Vector3(0, 0, speedOfMov);
            }

            if (blueCube1.transform.position.z < -22.6f && blueCube3.transform.position.z < -22.6f && blueCube5.transform.position.z < -22.6f)
            {
                toRight = false;
            }
            if (blueCube2.transform.position.z > 23.7f && blueCube4.transform.position.z > 23.7f)
            {
                toRight = true;
            }
            if (blueCube1.transform.position.z > 23.7f && blueCube3.transform.position.z > 23.7f && blueCube5.transform.position.z > 23.7f)
            {
                toRight = false;
            }
        }
        else
        {

        }
    }
}
