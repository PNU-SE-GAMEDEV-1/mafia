using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace LobbyScene.Lobby
{
    public class RoomList : MonoBehaviourPunCallbacks
    {
        [SerializeField] private GameObject roomEntryPrefab;

        private Dictionary<string, GameObject> _roomEntryList;

        #region UNITY

        private void Awake()
        {
            _roomEntryList = new ();
        }

        #endregion


        #region PHOTON

        public override void OnRoomListUpdate(List<RoomInfo> roomList)
        {
            ClearRoomListView();
            foreach (RoomInfo roomInfo in roomList)
            {
                AddRoomEntry(roomInfo);
            }
        }

        #endregion

        private void AddRoomEntry(RoomInfo roomInfo)
        {
            if (roomInfo.MaxPlayers == 0) return;
            
            GameObject entry = Instantiate(roomEntryPrefab);
            entry.transform.SetParent(transform);
            entry.transform.localScale = Vector3.one;
            RectTransform entryTransform = entry.GetComponent<RectTransform>();
            entryTransform.offsetMax = new Vector2(0, -35 * _roomEntryList.Count);
            entryTransform.offsetMin = new Vector2(0, -35 * (_roomEntryList.Count + 1));
            
            entry.GetComponent<RoomListEntry>().Initialize(roomInfo);
            
            _roomEntryList.Add(roomInfo.Name, entry);
        }
        
        private void ClearRoomListView()
        {
            foreach (GameObject entry in _roomEntryList.Values)
            {
                Destroy(entry.gameObject);
            }

            _roomEntryList.Clear();
        }
    }
}