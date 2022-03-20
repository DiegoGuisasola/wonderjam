using UnityEngine;

namespace Menu
{
    public class MenuManager : Singleton<MenuManager>
    {
        public GameObject _mainMenuPanel;
        public GameObject _scrollingPanel;
        public GameObject _optionsPanel;
        public GameObject _creditsPanel;
        
        public void Awake()
        {
            OpenMenu(Menu.MAIN_MENU, _mainMenuPanel);
            _scrollingPanel.SetActive(true);
        }

        public void OpenMenu(Menu menu, GameObject callingMenu)
        {
            switch (menu)
            {
                case Menu.MAIN_MENU:
                    HandleMainMenu();
                    
                    break;
                case Menu.OPTIONS:
                    _mainMenuPanel.SetActive(false);
                    _optionsPanel.SetActive(true);
                    _creditsPanel.SetActive(false);
                    
                    break;
                case Menu.CREDITS:
                    _mainMenuPanel.SetActive(false);
                    _optionsPanel.SetActive(false);
                    _creditsPanel.SetActive(true);
                    
                    break;
            }
        }

        private void HandleMainMenu()
        {
            _mainMenuPanel.SetActive(true);
            _optionsPanel.SetActive(false);
            _creditsPanel.SetActive(false);
        }
    }
}
