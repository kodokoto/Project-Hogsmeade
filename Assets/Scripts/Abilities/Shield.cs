using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Shield : Spell
{
    public GameObject ObjectToSpawn;
    private GameObject shieldParticles;

    public override void Activate(GameObject parent)
    {
        Player player = parent.GetComponent<Player>();
        player.SetIsShielded(true);
        shieldParticles = Instantiate(ObjectToSpawn);
    }

    public override void Deactivate(GameObject parent)
    {
        Destroy(shieldParticles);
        Player player = parent.GetComponent<Player>();
        player.SetIsShielded(false);
    }
}
