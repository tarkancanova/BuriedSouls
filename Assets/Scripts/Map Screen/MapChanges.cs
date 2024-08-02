using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MapChanges : MonoBehaviour
{
    public GameObject roomOne, roomTwo, roomThree, roomFour;
    [SerializeField] private Button _buttonOne;
    [SerializeField] private Button _buttonTwo;
    [SerializeField] private TMP_Text _textTwo;
    [SerializeField] private TMP_Text _textOne;
    [SerializeField] private TMP_Text _currentRoomText;
    public int tracker;

    public string currentRoom;
    public string bossRoom = "Boss Room";
    public string treasureRoom = "Treasure Room";
    public string fightRoom = "Fight Room";
    public string stairsRoom = "Stairs Room";
    public PlayerData playerData;

    private void Update()
    {
        _currentRoomText .text = currentRoom;
    }

    private void Start()
    {

        StartSettings();
        GroupDecider();


    }

    private void ProceedToStairs()
    {
        Debug.Log(4);
        RemoveListeners();
        currentRoom = "Stairs Room";
    }

    private void ProceedToBossRoom()
    {
        Debug.Log(1);
        RemoveListeners();
        currentRoom = "Boss Room";

    }

    private void ProceedToFightRoom()
    {
        Debug.Log(2);
        RemoveListeners();
        currentRoom = "Fight Room";
    }

    private void ProceedToTreasureRoom()
    {
        Debug.Log(3);
        RemoveListeners();
        currentRoom = "Treasury Room";

    }

    private void NextRoomDecider(GameObject _roomObject)
    {
        

        if (playerData.floor < 10)
        {
            int deciderForFirst = Random.Range(0, 16);
            switch (deciderForFirst)
            {

                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:

                    _roomObject.transform.GetChild(0).GetComponent<TMP_Text>().text = "Fight Room";
                    break;

                case 10:
                case 11:

                    _roomObject.transform.GetChild(0).GetComponent<TMP_Text>().text = "Treasury Room";
                    break;

                case 12:
                case 13:
                case 14:
                case 15:

                    _roomObject.transform.GetChild(0).GetComponent<TMP_Text>().text = "Stairs";
                    break;
            }
        }
        else
        {
            int deciderForFirst = Random.Range(0, 18);
            switch (deciderForFirst)
            {

                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:

                    _roomObject.transform.GetChild(0).GetComponent<TMP_Text>().text = "Fight Room";
                    break;

                case 10:
                case 11:

                    _roomObject.transform.GetChild(0).GetComponent<TMP_Text>().text = "Treasury Room";
                    break;

                case 12:
                case 13:
                case 14:
                case 15:

                    _roomObject.transform.GetChild(0).GetComponent<TMP_Text>().text = "Stairs";
                    break;

                case 16:
                case 17:
                    _roomObject.transform.GetChild(0).GetComponent<TMP_Text>().text = "Boss";
                    break;
            }
        }
    }

    public void PostRoomSelection()
    {
        switch (tracker)
        {
            case 1:
                _textOne.text = roomOne.transform.GetChild(0).GetComponent<TMP_Text>().text;
                switch (_textOne.text)
                {
                    case "Stairs":
                        _buttonOne.onClick.AddListener(ProceedToStairs); break;
                    case "Boss":
                        _buttonOne.onClick.AddListener(ProceedToBossRoom); break;
                    case "Fight Room":
                        _buttonOne.onClick.AddListener(ProceedToFightRoom); break;
                    case "Treasury Room":
                        _buttonOne.onClick.AddListener(ProceedToTreasureRoom); break;
                }
                _textTwo.text = roomTwo.transform.GetChild(0).GetComponent <TMP_Text>().text;
                switch (_textTwo.text)
                {
                    case "Stairs":
                        _buttonTwo.onClick.AddListener(ProceedToStairs); break;
                    case "Boss":
                        _buttonTwo.onClick.AddListener(ProceedToBossRoom); break;
                    case "Fight Room":
                        _buttonTwo.onClick.AddListener(ProceedToFightRoom); break;
                    case "Treasury Room":
                        _buttonTwo.onClick.AddListener(ProceedToTreasureRoom); break;
                }
                break;
            case 2:
                _textOne.text = roomThree.transform.GetChild(0).GetComponent<TMP_Text>().text;
                switch (_textOne.text)
                {
                    case "Stairs":
                        _buttonOne.onClick.AddListener(ProceedToStairs); break;
                    case "Boss":
                        _buttonOne.onClick.AddListener(ProceedToBossRoom); break;
                    case "Fight Room":
                        _buttonOne.onClick.AddListener(ProceedToFightRoom); break;
                    case "Treasury Room":
                        _buttonOne.onClick.AddListener(ProceedToTreasureRoom); break;
                }
                _textTwo.text = roomFour.transform.GetChild(0).GetComponent<TMP_Text>().text;
                switch (_textTwo.text)
                {
                    case "Stairs":
                        _buttonTwo.onClick.AddListener(ProceedToStairs); break;
                    case "Boss":
                        _buttonTwo.onClick.AddListener(ProceedToBossRoom); break;
                    case "Fight Room":
                        _buttonTwo.onClick.AddListener(ProceedToFightRoom); break;
                    case "Treasury Room":
                        _buttonTwo.onClick.AddListener(ProceedToTreasureRoom); break;
                }
                break;
        }

        GroupDecider();

    }

    private void StartSettings()
    {
        
        _textOne.text = "Fight Room";
        _textTwo.text = "Fight Room";
        _buttonOne.onClick.AddListener(ProceedToFightRoom);
        _buttonTwo.onClick.AddListener(ProceedToFightRoom);

    }

    public void TrackerOne()
    {
        tracker = 1;
        Debug.Log(_textOne.text);
    }   
    public void TrackerTwo()
    {
        tracker = 2;
        Debug.Log(_textTwo.text);
    }

    private void RemoveListeners()
    {
        _buttonOne.onClick.RemoveListener(ProceedToBossRoom);
        _buttonOne.onClick.RemoveListener(ProceedToTreasureRoom);
        _buttonOne.onClick.RemoveListener(ProceedToFightRoom);
        _buttonOne.onClick.RemoveListener(ProceedToStairs);
        _buttonTwo.onClick.RemoveListener(ProceedToBossRoom);
        _buttonTwo.onClick.RemoveListener(ProceedToTreasureRoom);
        _buttonTwo.onClick.RemoveListener(ProceedToFightRoom);
        _buttonTwo.onClick.RemoveListener(ProceedToStairs);
    }

    private void GroupDecider()
    {
        NextRoomDecider(roomOne);
        NextRoomDecider(roomTwo);
        NextRoomDecider(roomThree);
        NextRoomDecider(roomFour);
    }
}
