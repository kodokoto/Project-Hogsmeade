using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : ScriptableObject
{
    public float cooldownTime;
    public float activeTime;
    public int manaCost;
    public virtual void Activate(GameObject parent){}
    public virtual void Deactivate(GameObject parent){}

    public virtual bool IsValid(GameObject parent)
    {
        Player player = parent.GetComponent<Player>();
        if (player.IsGhost) {
            return false;
        }
        return true;
    }

    public bool Validate(GameObject parent)
    {
        Player player = parent.GetComponent<Player>();
        if (player.GetMana() >= manaCost && IsValid(parent))
        {
            player.ConsumeMana(manaCost);
            return true;
        }
        else
        {
            return false;
        }
    }  
}
