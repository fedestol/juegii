using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
    }
    public void SceneMenú()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menú");
    }
    public void SceneDeath()
    {
        SceneManager.LoadScene("Death");
    }
    public void SceneNivel1()
    {
        Time.timeScale = 1f;    
        SceneManager.LoadScene("Nivel1");
    }
    public void WinNivel1MorirEnNivel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel2");
    }
    public void WinNivel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Win");
    }
}
