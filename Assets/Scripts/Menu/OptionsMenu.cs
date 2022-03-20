using UnityEngine;

namespace Menu
{
    public class OptionsMenu : MonoBehaviour
    {
        public void OnClick_Back()
        {
            MenuManager.Instance.OpenMenu(Menu.MAIN_MENU);
        }
    }
}
