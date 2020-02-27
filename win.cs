using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject winmenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void retry()
    {

        SceneManager.LoadScene(0);
        winmenu.SetActive(false);

    }
    public void quit()
    {
        Application.Quit();
    }

}
