using System;
using UnityEngine;

namespace Menu
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        [SerializeField] private GameObject player;

        private void Awake()
        {
            Instance = this;
        }

        public void UpdateGameState(GameState newState)
        {
            switch (newState)
            {
                case GameState.Menu:
                    MenuManager.Instance.OpenMenu(Menu.MAIN_MENU);
                    break;
                case GameState.Play:
                    MenuManager.Instance.OpenMenu(Menu.DISABLE);
                    player.SetActive(true);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
            }
        }
    }

    public enum GameState
    {
        Menu,
        Play,
    }
}