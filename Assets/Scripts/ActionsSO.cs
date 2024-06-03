using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions Data")]
public class ActionsSO : ScriptableObject
{
    public string actionName;
    public enum ActionType { Attack, Skill, ItemUsage, Defence }
    public ActionType actionType;
    public float actionCost;


}
