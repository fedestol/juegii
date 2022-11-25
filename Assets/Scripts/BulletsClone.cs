using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsClone : MonoBehaviour
{
    public float Timer = 3f;
    public Text txt;
    public GameObject myCube;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;

    public float shortForce = 1500;
    public float shotRate = 0.5f;
    private float shotRateTime = 0;
    public float c = 4f;
    public float ShotForce;
    public bool b;
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        b = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1f)
        {
            ///*spawnPoint1.Rotate(25.0f, 0.0f, 0.0f, Space.Self);

            //if (spawnPoint1.rotation.x < 0f)
            //{
            //    spawnPoint1.Rotate(25.0f, 0.0f, 0.0f, Space.Self);
            //}
            //else if (spawnPoint1.rotation.z > 180f)
            //{
            //    spawnPoint1.Rotate(-25.0f, 0.0f, 0.0f, Space.Self);
            //}*/

            //if (b == true)
            //{
            //    gameObject.transform.Rotate(0.0f, 0.0f, 5.0f, Space.Self);
            //    spawnPoint1.Rotate(5.0f, 0.0f, 0.0f, Space.Self);
            //}
            //else
            //{
            //    gameObject.transform.Rotate(0.0f, 0.0f, -5.0f, Space.Self);
            //    spawnPoint1.Rotate(-5.0f, 0.0f, 0.0f, Space.Self);
            //}
            //if (spawnPoint1.rotation.x > 110f && gameObject.transform.rotation.z > 110f)
            //{
            //    b = true;
            //}
            //if (spawnPoint1.rotation.x < 40f && gameObject.transform.rotation.z < 40f)
            //{
            //    b = false;
            //}
            for (int i = 0; i < 2; i++)
            {
                var distance = Vector3.Distance(BulletPrefab.transform.position, transform.position);
                Timer -= Time.deltaTime;

                if (Timer <= 0f && distance > c)
                {
                    Instantiate(BulletPrefab, spawnPoint1.position, spawnPoint1.rotation);
                    Instantiate(BulletPrefab, spawnPoint2.position, spawnPoint2.rotation);

                    //transform.Rotate(0.0f, 0.0f, 25.0f);
                    Timer = 4f;
                }

                //newBullet = Instantiate(BulletPrefab, spawnPoint.position, spawnPoint.rotation);
                //newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shortForce);
                //shotRateTime = Time.time + shotRate;
                //Destroy(newBullet, 2);
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == BulletPrefab)
        {
            int txtint = int.Parse(txt.text);
            txtint--;


            if (txtint <= 0)
            {
                SceneManagerScript o = new SceneManagerScript();
                o.SceneDeath();
            }
            else
            {
                txt.text = txtint.ToString();
            }
        }
    }
}
