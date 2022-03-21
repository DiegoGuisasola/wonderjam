using UnityEngine;

namespace Menu
{
    public class MenuManager : SingletonPersistent<MenuManager>
    {
        [SerializeField] private GameObject _mainMenuPanel;
        [SerializeField] private GameObject _scrollingPanel;
        [SerializeField] private GameObject _optionsPanel;
        [SerializeField] private GameObject _creditsPanel;

        protected override void Awake()
        {
            base.Awake();
            OpenMenu(Menu.MAIN_MENU);
            _scrollingPanel.SetActive(true);
        }

        public void OpenMenu(Menu menu)
        {
            switch (menu)
            {
                case Menu.MAIN_MENU:
                    HandleMainMenu();
                    
                    break;
                case Menu.OPTIONS:
                    HandleOptionsMenu();
                    
                    break;
                case Menu.CREDITS:
                    HandleCreditsMenu();
                    
                    break;
                case Menu.DISABLE:
                    HandleDisableMenu();

                    break;
            }
        }

        private void HandleDisableMenu()
        {
            // Deactivate Menu
            _mainMenuPanel.SetActive(false);
            _optionsPanel.SetActive(false);
            _creditsPanel.SetActive(false);
            _scrollingPanel.SetActive(false);
        }

        private void HandleMainMenu()
        {
            _mainMenuPanel.SetActive(true);
            _optionsPanel.SetActive(false);
            _creditsPanel.SetActive(false);
        }

        private void HandleOptionsMenu()
        {
            _mainMenuPanel.SetActive(false);
            _optionsPanel.SetActive(true);
            _creditsPanel.SetActive(false);
        }

        private void HandleCreditsMenu()
        {
            _mainMenuPanel.SetActive(false);
            _optionsPanel.SetActive(false);
            _creditsPanel.SetActive(true);
        }
    }
}
