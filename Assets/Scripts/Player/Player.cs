using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    Alive,
    Dead
}

public class Player : MonoBehaviour , ITakeDamage, IGhost
{

    [Header("Data")]
    [SerializeField] public PlayerSpawnPoint currentSpawnPoint;
    [SerializeField] public PlayerData data;
    [SerializeField] public PlayerInventory PlayerInventory;


    // public PlayerState state;
    [SerializeField] private Transform projectileSpawnPoint;
    private float healthRegenTimer;
    private float manaRegenTimer;
    
    // UI
    public HealthBar healthBar;
    public ManaBar manaBar;
    public XPBar xpBar;
    public bool isRightEnabled=false;
    public bool isLeftEnabled=false;

    public Dialogue levelUpUI;


    public List<SpellHandler> SpellHandlers;

    // Broadcasts
    [SerializeField] private SignalSO _onPlayerDeath;

    // State
    public bool IsGhost{ get; set; } = false;


    void Start()
    {
        Debug.Log("Plz");
        SetUpSpells();
        healthBar.SetMaxHealth(data.maxHealth);
        manaBar.SetMaxMana(data.maxMana);
        transform.position = currentSpawnPoint.GetSpawnPoint();
    }
   
    void Update()
    {
        HealthRegen();
        ManaRegen();
    }

    private void SetUpSpells()
    {
        Debug.Log("Setting up spells");
        SpellHandlers = new List<SpellHandler>();
        foreach (Spell spell in PlayerInventory.Spells)
        {
            SpellHandler spellHandler = gameObject.AddComponent<SpellHandler>();
            spellHandler.Spell = spell;
            SpellHandlers.Add(spellHandler);
        }
    }

    private void HealthRegen()
    {
        if (data.health < data.maxHealth)
        {
            if (healthRegenTimer > data.healthRegenRate)
            {
                RestoreHealth(data.healthRegen);
                healthRegenTimer = 0;
            }
            else
            {
                healthRegenTimer += Time.deltaTime;
            }
        }
    }

    private void ManaRegen()
    {
        if (data.mana < data.maxMana)
        {
            if (manaRegenTimer > data.manaRegenRate)
            {
                RestoreMana(data.manaRegen);
                manaRegenTimer = 0;
            }
            else
            {
                manaRegenTimer += Time.deltaTime;
            }
        }
    }

    // Helpers

    public int GetMana()
    {
        return data.mana;
    }

    public int GetHealth()
    {
        return data.health;
    }

    public bool IsShielded()
    {
        return data.isShielded;
    }

    public void SetIsShielded(bool isShielded)
    {
        data.isShielded = isShielded;
    }

    public void TakeDamage(int damage, bool showEffect = true)
    {
        if (!data.isShielded)
        {
             RemoveHealth(damage);
        }
    }

    public void ConsumeMana(int mana)
    {
        RemoveMana(mana);
    }

    public void RestoreHealth(int healAmount)
    {
        AddHealth(healAmount);
    }

    public void RestoreMana(int mana)
    {
        AddMana(mana);
    }


    public void AddXP(int xp)
    {
        Debug.Log("Xp before: " + data.currentXp);
        Debug.Log("Adding " + xp + " xp");
        data.currentXp += xp;
        Debug.Log("Xp after: " + data.currentXp);
        if (data.currentXp >= data.xpLevels[data.currentXpLevel])
        {
            LevelUp();
        }
        xpBar.SetXP(data.currentXp);
    }

    public Transform GetProjectileSpawnPoint()
    {
        return projectileSpawnPoint;
    }

    public int GetMaxHealth()
    {
        return data.maxHealth;
    }

    public int getExcess()
    {
        return data.excessHealth;
    }

    public void setExcess(int amount)
    {
        SetExcess(amount);
    }

    public void setMaxHealth(int maxHealth)
    {
        data.maxHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void setHealth(int health)
    {
        SetHealth(health);
    }


    // private data modifiers

    private void SetHealth(int health)
    {
        data.health = Mathf.Min(health, data.maxHealth);
    }

    private void SetExcess(int amount)
    {
        data.excessHealth = amount;
    }

    private void LevelUp()
    {
        // if current level is max level, do nothing
        if (data.currentXpLevel >= data.xpLevels.Length)
        {
            return;
        }

        data.currentXp -= data.xpLevels[data.currentXpLevel];
        data.currentXpLevel++;
        SetMaxHealth(data.maxHealth + data.levelUpHealthRate);
        SetMaxMana(data.maxMana + data.levelUpManaRate);

        xpBar.SetMaxXP(data.xpLevels[data.currentXpLevel]);
    }



    private void SetMaxHealth(int amount)
    {
        data.maxHealth = amount;
        data.health = Mathf.Min(data.health, data.maxHealth);
        healthBar.SetMaxHealth(data.maxHealth);
    }

    private void SetMaxMana(int amount)
    {
        data.maxMana = amount;
        data.mana = Mathf.Min(data.mana, data.maxMana);
        manaBar.SetMaxMana(data.maxMana);
    }

    private void AddHealth(int amount)
    {
        if(getExcess()!=0 && amount > getExcess())
        {
            amount = amount - getExcess();
            setExcess(0);
        }
        else if(getExcess() != 0)
        {
            setExcess(getExcess()-amount);
            return;
        }
        data.health = Mathf.Min(data.health + amount, data.maxHealth);
        healthBar.SetHealth(data.health);
    }

    private void RemoveHealth(int amount)
    {
        data.health = Mathf.Max(data.health - amount, 0);
        healthBar.SetHealth(data.health);
        if (data.health <= 0)
        {
            Debug.Log("Health is 0");
            HandleDeath();
        }
    }

    private void AddMana(int amount)
    {
        data.mana = Mathf.Min(data.mana + amount, data.maxMana);
        manaBar.SetMana(data.mana);
    }

    private void RemoveMana(int amount)
    {
        data.mana = Mathf.Max(data.mana - amount, 0);
        manaBar.SetMana(data.mana);
    }

    private void HandleDeath()
    {
        _onPlayerDeath.Trigger();
    }

    internal void AddSpell(Spell spell)
    {
        PlayerInventory.AddSpell(spell);
        SpellHandler spellHandler = gameObject.AddComponent<SpellHandler>();
        spellHandler.Spell = spell;
        SpellHandlers.Add(spellHandler);
    }
}
