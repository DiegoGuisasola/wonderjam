using UnityEngine;

namespace Menu
{
    public class CreditsMenu : MonoBehaviour
    {
        public void OnClick_Back()
        {
            MenuManager.Instance.OpenMenu(Menu.MAIN_MENU);
        }
    }
}
