using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PassiveAllocation : MonoBehaviour
{
    private Button _button;
    public PassivePoints _point;
    private TMP_Text _passiveText;
    public Player player;

    private void Awake()
    {
        _button = GetComponent<Button>();
        this.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = _point.name;
        _button.onClick.AddListener(OnClickButton);
    }


    private void OnClickButton()
    {
        if (!_point.allocated && player.level >= _point.levelReq && player.passivePoints > 0)
        {
            _point.ApplyPassivePoint(player);
            _point.allocated = true;
            player.passivePoints -= 1;
        }
    }
}
