using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class MainMenu : MonoBehaviour
    {
        public void OnClick_Play()
        {
            SceneManager.LoadScene(1);
        }
    
        public void OnClick_Options()
        {
            MenuManager.Instance.OpenMenu(Menu.OPTIONS);
        }
    
        public void OnClick_Credits()
        {
            MenuManager.Instance.OpenMenu(Menu.CREDITS);
        }
    
        public void OnClick_Exit()
        {
            Application.Quit();
        }
    }
}
