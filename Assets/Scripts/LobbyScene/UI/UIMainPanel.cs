using LobbyScene.Lobby;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace LobbyScene.UI
{
    public class UIMainPanel : MonoBehaviour
    {
        [SerializeField] private TMP_InputField nicknameInputField;
        [SerializeField] private Button connectRoomButton;
        [SerializeField] private Button connectToRandomRoomButton;
        [SerializeField] private Button quitButton;
        [SerializeField] private LobbyManager lobbyManager;

        private void Awake()
        {
            connectRoomButton.onClick.AddListener(lobbyManager.CreateRoom);
            connectToRandomRoomButton.onClick.AddListener(lobbyManager.ConnectToRandomRoom);
            quitButton.onClick.AddListener(Application.Quit);

            nicknameInputField.text = "Player - " + Random.Range(1000, 9999);
            nicknameInputField.onEndEdit.Invoke(nicknameInputField.text);
        }

        public void AddNicknameChangesListener(UnityAction<string> function)
        {
            nicknameInputField.onEndEdit.AddListener(function);
        }
        
        public string GetNickname()
        {
            return nicknameInputField.text;
        }
    }
}