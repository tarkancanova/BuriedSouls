using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleScript : MonoBehaviour
{
    public BattleState state;
    [SerializeField] private GameObject _enemyParentObject;
    [SerializeField] private GameObject _fightUI;
    [SerializeField] private GameObject _fightScene;
    [SerializeField] private GameObject _playerObject;
    private GameObject enemyGO;
    private Enemy enemyScript;

    private void OnEnable()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    private void Update()
    {

    }


    private IEnumerator SetupBattle()
    {
        _fightUI.SetActive(true);
        _fightScene.SetActive(true);
        int enemyIndex = UnityEngine.Random.Range(0, _enemyParentObject.transform.childCount);
        enemyGO = _enemyParentObject.transform.GetChild(enemyIndex).gameObject;
        enemyScript = enemyGO.GetComponent<Enemy>();
        enemyGO.SetActive(true);

        yield return new WaitForSeconds(2f);

        TurnDecider();
    }

    private void SetupHealth(Enemy enemyScript)
    {
        enemyScript.currentHealth = (int)enemyScript.maxHealth;
    }

    private void TurnDecider()
    {
        if (_playerObject.GetComponent<Player>().dexterity >= enemyScript.level * 50) state = BattleState.PLAYERTURN;

        else if (_playerObject.GetComponent<Player>().dexterity >= enemyScript.level * 10 && _playerObject.GetComponent<Player>().dexterity < enemyScript.level * 50)
        {
            int turnStartDecider = UnityEngine.Random.Range(0, 2);
            switch (turnStartDecider)
            {
                case 0:
                    state = BattleState.PLAYERTURN; break;
                case 1:
                    state = BattleState.ENEMYTURN; break;
            }
        }

        else state = BattleState.ENEMYTURN;
    }

    public IEnumerator PlayerAttack()
    { 
        enemyScript.TakeDamage(_playerObject.GetComponent<Player>().attackDamage);
        Debug.Log("Attacking...");
        state = BattleState.ENEMYTURN;
        yield return new WaitForSeconds(1);
        StartCoroutine(EnemyTurn());
    }

    IEnumerator EnemyTurn()
    {
        yield return new WaitForSeconds(1);
        enemyScript.Attack(_playerObject.GetComponent<Player>());
        Debug.Log("enemy attacked");
        state = BattleState.PLAYERTURN;
    }

    public void OnAttackButtonClick()
    {
        if (state != BattleState.PLAYERTURN) return;

        StartCoroutine(PlayerAttack());
    }
}
