using UnityEngine;

public abstract class InteractionStrategy : ScriptableObject
{
    public virtual void OnInteractionBegin() {}
    public virtual void OnInteract() {}
    public virtual void OnInteractionComplete() {}
}
