using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class MapChanges : MonoBehaviour
{
    [SerializeField] private TMP_Text _mapTextOne;
    [SerializeField] private TMP_Text _mapTextTwo;
    [SerializeField] private Button _buttonOne;
    [SerializeField] private Button _buttonTwo;
    private Button _mapButtonOne;
    private Button _mapButtonTwo;

    private void OnEnable()
    {
        int deciderForFirst = Random.Range(0, 3);

        switch (deciderForFirst)
        {
            case 0:
                _mapTextOne.text = "Treasure Room";
                _buttonOne.onClick.AddListener(ProceedToTreasureRoom);
                break;

            case 1:
                _mapTextOne.text = "Fight Room";
                _buttonOne.onClick.AddListener(ProceedToFightRoom);
                break;

            case 2:
                _mapTextOne.text = "Boss Room";
                _buttonOne.onClick.AddListener(ProceedToBossRoom);
                break;
        }        
        
        int deciderForSecond = Random.Range(0, 3);

        switch (deciderForSecond)
        {
            case 0:
                _mapTextTwo.text = "Treasure Room";
                _buttonTwo.onClick.AddListener(ProceedToTreasureRoom);
                break;

            case 1:
                _mapTextTwo.text = "Fight Room";
                _buttonTwo.onClick.AddListener(ProceedToFightRoom);
                break;

            case 2:
                _mapTextTwo.text = "Boss Room";
                _buttonTwo.onClick.AddListener(ProceedToBossRoom);
                break;
        }
    }

    private void OnDisable()
    {
        _buttonOne.onClick.RemoveAllListeners();
        _buttonTwo.onClick.RemoveAllListeners();
    }

    private void ProceedToBossRoom()
    {
        Debug.Log(1);
    }

    private void ProceedToFightRoom()
    {
        Debug.Log(2);
    }

    private void ProceedToTreasureRoom()
    {
        Debug.Log(3);
    }
}
