using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float Timerr = 3f;
    public Text txtnivel;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {        
        Time.timeScale = 0f;
        Timerr -= Time.unscaledDeltaTime;
        txtnivel.enabled = true;

        if (Timerr <= 0f)
        {
            Time.timeScale = 1f;
            txtnivel.enabled = false;
        }
    }

    /*IEnumerator time()
    {

        txtnivel1.enabled = true;
        yield return new WaitForSeconds(1);
        txtnivel1.enabled = false;  
    }*/
}
