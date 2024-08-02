using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "PlayerData", order = 1)]
public class PlayerData : ScriptableObject
{
    public int floor;
    public int currentHealth;
    public float maxHealth;
    public int level;
    public int baseAttackDamage;
    public int maxShield;
    public int currentShield;
    public int evasionRating;
    public int armour;
    public int fireResistance;
    public int coldResistance;
    public int lightningResistance;
    public int poisonResistance;
    public int critChance;
    public int criticalDamage;
    public int fireDamage;
    public int coldDamage;
    public int lightningDamage;
    public int physicalDamage;
    public int increasedPhysicalDamage;
    public int increasedFireDamage;
    public int increasedColdDamage;
    public int increasedLightningDamage;
    public int chanceToPoison;
    public int chanceToBleed;
    public int elementalPenetration;
    public int stunChance;
    public int chanceToBlock;
    public int lifesteal;
    public int intelligence;
    public int strength;
    public int dexterity;

    // Add default values for each attribute
    public int defaultFloor = 1;
    private int defaultCurrentHealth = 100;
    private float defaultMaxHealth = 100f;
    private int defaultLevel = 1;
    private int defaultBaseAttackDamage = 10;
    private int defaultMaxShield = 50;
    private int defaultCurrentShield = 50;
    private int defaultEvasionRating = 0;
    private int defaultArmour = 0;
    private int defaultFireResistance = 0;
    private int defaultColdResistance = 0;
    private int defaultLightningResistance = 0;
    private int defaultPoisonResistance = 0;
    private int defaultCritChance = 5;
    private int defaultCriticalDamage = 50;
    private int defaultFireDamage = 0;
    private int defaultColdDamage = 0;
    private int defaultLightningDamage = 0;
    private int defaultPhysicalDamage = 10;
    private int defaultIncreasedPhysicalDamage = 0;
    private int defaultIncreasedFireDamage = 0;
    private int defaultIncreasedColdDamage = 0;
    private int defaultIncreasedLightningDamage = 0;
    private int defaultChanceToPoison = 0;
    private int defaultChanceToBleed = 0;
    private int defaultElementalPenetration = 0;
    private int defaultStunChance = 0;
    private int defaultChanceToBlock = 0;
    private int defaultLifesteal = 0;
    private int defaultIntelligence = 10;
    private int defaultStrength = 10;
    private int defaultDexterity = 10;

    public void ResetData()
    {
        floor = defaultFloor;
        currentHealth = defaultCurrentHealth;
        maxHealth = defaultMaxHealth;
        level = defaultLevel;
        baseAttackDamage = defaultBaseAttackDamage;
        maxShield = defaultMaxShield;
        currentShield = defaultCurrentShield;
        evasionRating = defaultEvasionRating;
        armour = defaultArmour;
        fireResistance = defaultFireResistance;
        coldResistance = defaultColdResistance;
        lightningResistance = defaultLightningResistance;
        poisonResistance = defaultPoisonResistance;
        critChance = defaultCritChance;
        criticalDamage = defaultCriticalDamage;
        fireDamage = defaultFireDamage;
        coldDamage = defaultColdDamage;
        lightningDamage = defaultLightningDamage;
        physicalDamage = defaultPhysicalDamage;
        increasedPhysicalDamage = defaultIncreasedPhysicalDamage;
        increasedFireDamage = defaultIncreasedFireDamage;
        increasedColdDamage = defaultIncreasedColdDamage;
        increasedLightningDamage = defaultIncreasedLightningDamage;
        chanceToPoison = defaultChanceToPoison;
        chanceToBleed = defaultChanceToBleed;
        elementalPenetration = defaultElementalPenetration;
        stunChance = defaultStunChance;
        chanceToBlock = defaultChanceToBlock;
        lifesteal = defaultLifesteal;
        intelligence = defaultIntelligence;
        strength = defaultStrength;
        dexterity = defaultDexterity;
    }

    public void ApplyDataToPlayer(Player player)
    {
        player.currentHealth = currentHealth;
        player.maxHealth = maxHealth;
        player.level = level;
        player.baseAttackDamage = baseAttackDamage;
        player.maxShield = maxShield;
        player.currentShield = currentShield;
        player.evasionRating = evasionRating;
        player.armour = armour;
        player.fireResistance = fireResistance;
        player.coldResistance = coldResistance;
        player.lightningResistance = lightningResistance;
        player.poisonResistance = poisonResistance;
        player.critChance = critChance;
        player.criticalDamage = criticalDamage;
        player.fireDamage = fireDamage;
        player.coldDamage = coldDamage;
        player.lightningDamage = lightningDamage;
        player.physicalDamage = physicalDamage;
        player.increasedPhysicalDamage = increasedPhysicalDamage;
        player.increasedFireDamage = increasedFireDamage;
        player.increasedColdDamage = increasedColdDamage;
        player.increasedLightningDamage = increasedLightningDamage;
        player.chanceToPoison = chanceToPoison;
        player.chanceToBleed = chanceToBleed;
        player.elementalPenetration = elementalPenetration;
        player.stunChance = stunChance;
        player.chanceToBlock = chanceToBlock;
        player.lifesteal = lifesteal;
        player.intelligence = intelligence;
        player.strength = strength;
        player.dexterity = dexterity;
    }

    public void SaveDataFromPlayer(Player player)
    {
        currentHealth = player.currentHealth;
        maxHealth = player.maxHealth;
        level = player.level;
        baseAttackDamage = player.baseAttackDamage;
        maxShield = player.maxShield;
        currentShield = player.currentShield;
        evasionRating = player.evasionRating;
        armour = player.armour;
        fireResistance = player.fireResistance;
        coldResistance = player.coldResistance;
        lightningResistance = player.lightningResistance;
        poisonResistance = player.poisonResistance;
        critChance = player.critChance;
        criticalDamage = player.criticalDamage;
        fireDamage = player.fireDamage;
        coldDamage = player.coldDamage;
        lightningDamage = player.lightningDamage;
        physicalDamage = player.physicalDamage;
        increasedPhysicalDamage = player.increasedPhysicalDamage;
        increasedFireDamage = player.increasedFireDamage;
        increasedColdDamage = player.increasedColdDamage;
        increasedLightningDamage = player.increasedLightningDamage;
        chanceToPoison = player.chanceToPoison;
        chanceToBleed = player.chanceToBleed;
        elementalPenetration = player.elementalPenetration;
        stunChance = player.stunChance;
        chanceToBlock = player.chanceToBlock;
        lifesteal = player.lifesteal;
        intelligence = player.intelligence;
        strength = player.strength;
        dexterity = player.dexterity;
    }
}