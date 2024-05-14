using Photon.Realtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LobbyScene.Lobby
{
    public class RoomListEntry : MonoBehaviour
    {
        private static readonly string PlayersCountPatters = "{0} / {1}";
        
        [SerializeField] private Button joinButton;
        [SerializeField] private TextMeshProUGUI roomName;
        [SerializeField] private TextMeshProUGUI playersCount;
        [SerializeField] private TextMeshProUGUI closedText;
        
        private LobbyManager _lobbyManager = LobbyManager.Instance;
        private RoomInfo _roomInfo;
        
        #region UNITY

        private void Awake()
        {
            joinButton.onClick.AddListener(Join);
        }

        #endregion

        private void Join()
        {
            _lobbyManager.JoinRoom(_roomInfo.Name);
        }
        
        public void Initialize(RoomInfo roomInfo)
        {
            _roomInfo = roomInfo;
            roomName.SetText(roomInfo.Name);
            playersCount.SetText(string.Format(PlayersCountPatters, _roomInfo.PlayerCount, _roomInfo.MaxPlayers));
            closedText.gameObject.SetActive(!roomInfo.IsOpen);
        }
        
    }
}