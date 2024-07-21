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
    private GameObject _enemyGO;
    private Enemy _enemyScript;
    private Player _playerScript;

    private void Awake()
    {
        _playerScript = _playerObject.GetComponent<Player>();
    }

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
        _enemyGO = _enemyParentObject.transform.GetChild(enemyIndex).gameObject;
        _enemyGO.SetActive(true);
        _enemyScript = _enemyGO.GetComponent<Enemy>();

        yield return new WaitForSeconds(2f);

        TurnDecider();
    }

    private void SetupHealth(Enemy enemyScript)
    {
        enemyScript.currentHealth = (int)enemyScript.maxHealth;
    }

    private void TurnDecider()
    {
        if (_playerScript.dexterity >= _enemyScript.level * 50) state = BattleState.PLAYERTURN;

        else if (_playerScript.dexterity >= _enemyScript.level * 10 && _playerScript.dexterity < _enemyScript.level * 50)
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
        _playerScript.DealDamage(_enemyScript, new CharacterBase.GenericDamage { physicalDamage = 15 });
        Debug.Log("Attacking...");
        state = BattleState.ENEMYTURN;
        yield return new WaitForSeconds(1);
        StartCoroutine(EnemyTurn());
    }

    IEnumerator EnemyTurn()
    {
        yield return new WaitForSeconds(1);
        _enemyScript.Attack(_playerScript);
        Debug.Log("enemy attacked");
        state = BattleState.PLAYERTURN;
    }

    public void OnAttackButtonClick()
    {
        if (state != BattleState.PLAYERTURN) return;

        StartCoroutine(PlayerAttack());
    }
}
