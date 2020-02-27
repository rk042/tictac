using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class box : MonoBehaviour
{
    public GameObject winmenu;
    public GameObject level;
    public Text win;
    private int zo = 0;
    private string one1=null;
    private string two2=null;
    private string three3=null;
    private string four4=null;
    private string five5=null;
    private string six6=null;
    private string seven7=null;
    private string eight8=null;
    private string nine9=null;
    public GameObject o1;
    public GameObject o2;
    public GameObject o3;
    public GameObject o4;
    public GameObject o5;
    public GameObject o6;
    public GameObject o7;
    public GameObject o8;
    public GameObject o9;
    public GameObject x1;
    public GameObject x2;
    public GameObject x3;
    public GameObject x4;
    public GameObject x5;
    public GameObject x6;
    public GameObject x7;
    public GameObject x8;
    public GameObject x9;
    public GameObject carunt1;
    public GameObject carunt2;
    public GameObject carunt3;
    public GameObject carunt4;
    public GameObject carunt5;
    public GameObject carunt6;
    public GameObject carunt7;
    public GameObject carunt8;
    public GameObject carunt9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("runging");
      //  ott();
    }

    public void one()
    {
        
        if (zo == 0)
        {
            Debug.Log("o");
            carunt1.SetActive(false);
            o1.SetActive(true);
            one1 = 0.ToString() ;
            ott();
            zo = 1;
        }
        else if(zo ==1)
        {
            
            Debug.Log("1");
            carunt1.SetActive(false);
            x1.SetActive(true);
            one1 = 1.ToString() ;
            ott();
            zo = 0;

        }
        
        //Debug.Log(one1);
    }
    public void two()
    {
        
        if (zo == 0)
        {
            Debug.Log("o");
            carunt2.SetActive(false);
            o2.SetActive(true);
            two2 = 0.ToString() ;
            ott();
            zo = 1;
        }
        else if(zo ==1)
        {
            Debug.Log("1");
            carunt2.SetActive(false);
            x2.SetActive(true);
            two2 = 1.ToString();
            ott();
            zo = 0;

        }
        
    }
    public void three()
    {
        
        if (zo == 0)
        {
            Debug.Log("o");
            carunt3.SetActive(false);
            o3.SetActive(true);
            three3 = 0.ToString();
            ott();
            zo = 1;
        }
        else if(zo ==1)
        {
            Debug.Log("1");
            carunt3.SetActive(false);
            x3.SetActive(true);
            three3 = 1.ToString();
            ott();
            zo = 0;

        }
        
    }
    public void four()
    {
        
        if (zo == 0)
        {
            Debug.Log("o");
            carunt4.SetActive(false);
            o4.SetActive(true);
            four4 = 0.ToString();
            ott();
            //  carunt2.SetActive(false);
            zo = 1;
        }
        else if(zo ==1)
        {
            Debug.Log("1");
            carunt4.SetActive(false);
            x4.SetActive(true);
            four4 = 1.ToString();
            ott();
            zo = 0;

        }
        
    }
    public void five()
    {
        
        if (zo == 0)
        {
            Debug.Log("o");
            carunt5.SetActive(false);
            o5.SetActive(true);
            five5 = 0.ToString();
            ott();
            zo = 1;
        }
        else if(zo ==1)
        {
            Debug.Log("1");
            carunt5.SetActive(false);
            x5.SetActive(true);
            five5 = 1.ToString();
            ott();
            zo = 0;

        }
        
    }
    public void six()
    {
        
        if (zo == 0)
        {
            Debug.Log("o");
            carunt6.SetActive(false);
            o6.SetActive(true);
            six6 = 0.ToString();
            ott();
            zo = 1;
        }
        else if(zo==1)
        {
            Debug.Log("1");
            carunt6.SetActive(false);
            x6.SetActive(true);
            six6 = 1.ToString();
            ott();
            zo = 0;

        }
        
    }
    public void seven()
    {
        
        if (zo == 0)
        {
            Debug.Log("o");
            carunt7.SetActive(false);
            o7.SetActive(true);
            seven7 = 0.ToString();
            ott();
            zo = 1;
        }
        else if(zo ==1)
        {
            Debug.Log("1");
            carunt7.SetActive(false);
            x7.SetActive(true);
            seven7 = 1.ToString();
            ott();
            zo = 0;

        }
        
    }
    public void eight()
    {
        
        if (zo == 0)
        {
            Debug.Log("o");
            carunt8.SetActive(false);
            o8.SetActive(true);
            eight8 = 0.ToString();
            ott();
            zo = 1;
        }
        else if(zo==1)
        {
            Debug.Log("1");
            carunt8.SetActive(false);
            x8.SetActive(true);
            eight8 = 1.ToString();
            ott();
            zo = 0;

        }
        
    }
    public void nine()
    {
       
        if (zo == 0)
        {
            Debug.Log("o");
            carunt9.SetActive(false);
            o9.SetActive(true);
            nine9 = 0.ToString();
            ott();
            zo = 1;
        }
        else if(zo ==1)
        {
            Debug.Log("1");
            carunt9.SetActive(false);
            x9.SetActive(true);
            nine9 = 1.ToString();
            ott();
            zo = 0;

        }
        
    }
    private void ott()
    {
        if (one1 == 0.ToString() && two2 == 0.ToString() && three3 == 0.ToString())
        {
            Debug.Log("you win1230");
            win.text = "0 is win";
            level.SetActive(false);
            winmenu.SetActive(true); 
        }
        else if(one1==1.ToString() && two2 ==1.ToString() && three3 ==1.ToString())
        {
            Debug.Log("win1231");
            win.text = "X is win";
            level.SetActive(false);
            winmenu.SetActive(true);
        }
        else if(one1==0.ToString() && five5==0.ToString() && nine9==0.ToString())
        {
            Debug.Log("win1590");
            win.text = "0 is win";
            level.SetActive(false);
            winmenu.SetActive(true);
        }
        else if (one1 == 1.ToString() && five5 == 1.ToString() && nine9 == 1.ToString())
        {
            Debug.Log("win1591");
            win.text = "X is win";
            level.SetActive(false);
            winmenu.SetActive(true);
        }
        else if(one1 ==0.ToString() && six6==0.ToString() && seven7==0.ToString())
        {
            Debug.Log("win1670");
            win.text = "0 is win";
            level.SetActive(false);
            winmenu.SetActive(true);
        }
        else if (one1 == 1.ToString() && six6 == 1.ToString() && seven7 == 1.ToString())
        {
            Debug.Log("win1671");
            win.text = "X is win";
            level.SetActive(false);
            winmenu.SetActive(true);
        }

        else if (two2 == 0.ToString() && five5 == 0.ToString() && eight8 == 0.ToString())
        {
            Debug.Log("win2580");
            win.text = "0 is win";
            level.SetActive(false);
            winmenu.SetActive(true);
        }
        else if (two2 == 1.ToString() && five5 == 1.ToString() && eight8 == 1.ToString())
        {
            Debug.Log("win2581");
            win.text = "X is win";
            level.SetActive(false);
            winmenu.SetActive(true);
        }
        else if (six6 == 0.ToString() && five5 == 0.ToString() && four4 == 0.ToString())
        {
            Debug.Log("win6540");
            win.text = "0 is win";
            level.SetActive(false);
            winmenu.SetActive(true);
        }
        else if (six6 == 1.ToString() && five5 == 1.ToString() && four4 == 1.ToString())
        {
            Debug.Log("win6541");
            win.text = "X is win";
            level.SetActive(false);
            winmenu.SetActive(true);
        }

        else if (three3 == 0.ToString() && five5 == 0.ToString() && seven7 == 0.ToString())
        {
            Debug.Log("win3570");
            win.text = "0 is win";
            level.SetActive(false);
            winmenu.SetActive(true);
        }

        else if (three3 == 1.ToString() && five5 == 1.ToString() && seven7 == 1.ToString())
        {
            Debug.Log("win3571");
            win.text = "X is win";
            level.SetActive(false);
            winmenu.SetActive(true);
        }
    }
    public void retry()
    {
        //level.SetActive(true);
        SceneManager.LoadScene(0);
        Debug.Log("retry");
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("quit game");
    }
}
