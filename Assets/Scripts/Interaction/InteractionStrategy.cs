using UnityEngine;

public abstract class InteractionStrategy : ScriptableObject
{
    public virtual void OnHoverEnter( GameObject gameObject ) { }

    public virtual void OnHoverExit( GameObject gameObject ) { }

    public abstract void OnInteract();
}