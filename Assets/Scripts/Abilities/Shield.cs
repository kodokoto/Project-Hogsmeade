using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Shield : Spell
{

    public Color32 sheildTint = new(60, 240, 240, 240);
    public override void Activate(GameObject parent)
    {
        Player player = parent.GetComponent<Player>();
        player.SetIsShielded(true);
        parent.GetComponent<SpriteRenderer>().color = sheildTint;
    }

    public override void Deactivate(GameObject parent)
    {
        Player player = parent.GetComponent<Player>();
        player.SetIsShielded(false);
        parent.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
