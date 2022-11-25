using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    AudioSource source1;
    AudioSource source2;
    AudioSource source3;
    public AudioClip jumpSound;
    public AudioClip walkSound;
    public AudioClip Win;

    public float movementSpeed, rotationSpeed, jumpForce;
    public int maxJumps;
    int hasJump;

    public Quaternion originalRotation;
    public float rotationResetSpeed;
    Rigidbody rb;

    void Start()
    {
        originalRotation = transform.rotation;
        hasJump = maxJumps;

        gameObject.GetComponent<Renderer>().enabled = false;
        source1 = GetComponent<AudioSource>();
        source2 = GetComponent<AudioSource>();
        source3 = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (Time.timeScale == 1f)
        {
            if (Input.GetKey(KeyCode.W))
            {
                if (!source1.isPlaying) 
                {
                    source1.clip = walkSound;
                    source1.Play(); 
                }

                transform.Translate(-movementSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                if (!source1.isPlaying) 
                {
                    source1.clip = walkSound;
                    source1.Play(); 
                }
                transform.Translate(movementSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, -rotationSpeed, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, rotationSpeed, 0);
            }
            if (Input.GetKeyDown(KeyCode.Space) && hasJump > 0)
            {
                source2.clip = jumpSound;
                source2.Play();
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                hasJump--;
            }
            if (transform.rotation.x != originalRotation.x || transform.rotation.z != originalRotation.z || transform.rotation.w != originalRotation.w)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, originalRotation, Time.deltaTime * rotationResetSpeed);
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Plane" || col.gameObject.name == "WhiteJump" || col.gameObject.name == "Cube (1)")
        {
            hasJump = maxJumps;
        }

        if (col.gameObject.name == "Goal1")
        {        
            source3.clip = Win;
            source3.Play();
            SceneManagerScript scene = new SceneManagerScript();
            scene.WinNivel1MorirEnNivel2();
        }
    }  
}