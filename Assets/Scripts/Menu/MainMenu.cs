using System.Collections;
using System.Collections.Generic;
using Menu;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnClick_Play()
    {
        SceneManager.LoadScene(1);
    }
    
    public void OnClick_Options()
    {
        //MenuManager.OpenMenu(Menu.Menu.OPTIONS, this.gameObject);
    }
    
    public void OnClick_Credits()
    {
        
    }
    
    public void OnClick_Exit()
    {
        
    }
}
