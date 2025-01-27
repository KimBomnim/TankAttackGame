using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RoomData : MonoBehaviour
{
    [HideInInspector] //public 이지만 인스펙터에는 보이지 않는다.
    public string roomName = "";
    [HideInInspector]
    public int connectPlayer = 0;
    [HideInInspector]
    public int maxPlayer = 0;
    public Text textRoomName;
    public Text textConnectInfo;
    public void DisplayRoomData()
    {
        textRoomName.text = roomName;
        textConnectInfo.text = "(" + connectPlayer.ToString() + "/" + maxPlayer.ToString() + ")";
    }
}
