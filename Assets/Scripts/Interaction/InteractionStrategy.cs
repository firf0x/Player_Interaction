using UnityEngine;

[CreateAssetMenu(fileName = "InteractionStrategy", menuName = "Scriptable Objects/InteractionStrategy")]
public abstract class InteractionStrategy : ScriptableObject
{
    public virtual void OnInteractionBegin() {}
    public virtual void OnInteract() {}
    public virtual void OnInteractionComplete() {}
}
