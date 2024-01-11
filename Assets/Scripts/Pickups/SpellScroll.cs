using UnityEngine;

public class SpellScroll : Pickup
{
    public Spell spell;
    [SerializeField] private DialogueSignalSO dialogueSignal;

    void Update()
    {
        transform.Rotate(Vector3.up, 50 * Time.deltaTime);
    }

    protected override void OnPickup(GameObject actor)
    {
        // Add spell to player's spell list
        actor.GetComponent<Player>().AddSpell(spell);
        dialogueSignal.Trigger(spell.sentences);
        Destroy(gameObject);
    }
}