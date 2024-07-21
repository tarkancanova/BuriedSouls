using UnityEngine;
using TMPro;

public class CharacterSheet : MonoBehaviour
{
    public Player _player;

    // Character stats
    public TMP_Text currentHealthText;
    public TMP_Text maxHealthText;
    public TMP_Text levelText;
    public TMP_Text baseAttackDamageText;
    public TMP_Text characterNameText;

    // Defensive stats
    public TMP_Text currentShieldText;
    public TMP_Text evasionRatingText;
    public TMP_Text armourText;
    public TMP_Text fireResistanceText;
    public TMP_Text coldResistanceText;
    public TMP_Text lightningResistanceText;
    public TMP_Text poisonResistanceText;
    public TMP_Text critChanceText;
    public TMP_Text criticalDamageText;
    public TMP_Text fireDamageText;
    public TMP_Text coldDamageText;
    public TMP_Text lightningDamageText;
    public TMP_Text physicalDamageText;
    public TMP_Text increasedPhysicalDamageText;
    public TMP_Text increasedFireDamageText;
    public TMP_Text increasedColdDamageText;
    public TMP_Text increasedLightningDamageText;
    public TMP_Text chanceToPoisonText;
    public TMP_Text chanceToBleedText;
    public TMP_Text elementalPenetrationText;
    public TMP_Text stunChanceText;
    public TMP_Text chanceToBlockText;
    public TMP_Text lifestealText;

    private void OnEnable()
    {
        // Initialize the _player reference (assuming it is already assigned)
        if (_player == null)
        {
            Debug.LogError("Player reference is not assigned.");
            return;
        }

        // Initialize character stats from _player
        currentHealthText.text = "Health: " + _player.currentHealth.ToString() + "/" + _player.maxHealth.ToString();
        levelText.text = "Level: " + _player.level.ToString();
        //baseAttackDamageText.text = _player.baseAttackDamage.ToString();
        //characterNameText.text = _player.characterName;

        // Initialize defensive stats from _player
        currentShieldText.text = "Shield: " + _player.currentShield.ToString() + "/" + _player.maxShield.ToString();
        evasionRatingText.text = "Evasion: " + _player.evasionRating.ToString();
        armourText.text = "Armour: " + _player.armour.ToString();
        fireResistanceText.text = "Fire Res: " + _player.fireResistance.ToString();
        coldResistanceText.text = "Cold Res: " + _player.coldResistance.ToString();
        lightningResistanceText.text = "Lightning Res: " + _player.lightningResistance.ToString();
        poisonResistanceText.text = "Poison Res: " + _player.poisonResistance.ToString();
        critChanceText.text = "Crit Chance " + _player.critChance.ToString();
        criticalDamageText.text = "Crit Damage " + _player.criticalDamage.ToString();
        fireDamageText.text = "Added Fire: " + _player.fireDamage.ToString();
        coldDamageText.text = "Added Cold: " + _player.coldDamage.ToString();
        lightningDamageText.text = "Added Lightning: " + _player.lightningDamage.ToString();
        physicalDamageText.text = "Added Phys: " + _player.physicalDamage.ToString();
        increasedPhysicalDamageText.text = "Inc. Phys: " + _player.increasedPhysicalDamage.ToString();
        increasedFireDamageText.text = "Inc. Fire: " + _player.increasedFireDamage.ToString();
        increasedColdDamageText.text = "Inc. Cold: " + _player.increasedColdDamage.ToString();
        increasedLightningDamageText.text = "Inc Lightning: " + _player.increasedLightningDamage.ToString();
        chanceToPoisonText.text = "Chance To Poison: " + _player.chanceToPoison.ToString();
        chanceToBleedText.text = "Chance To Bleed: " + _player.chanceToBleed.ToString();
        elementalPenetrationText.text = "Ele. Pen.: " + _player.elementalPenetration.ToString();
        stunChanceText.text = "Stun Chance: " + _player.stunChance.ToString();
        chanceToBlockText.text = "Block Chance: " + _player.chanceToBlock.ToString();
        lifestealText.text = "Lifesteal: " + _player.lifesteal.ToString();
    }
}
