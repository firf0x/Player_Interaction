using UnityEngine;

public abstract class InteractionStrategy : ScriptableObject, IInteraction
{
    public virtual void OnHoverEnter( GameObject gameObject ) { }

    public virtual void OnHoverExit( GameObject gameObject ) { }

    public abstract void OnInteract();
}

public interface IInteraction
{
    public void OnHoverEnter( GameObject gameObject );

    public void OnHoverExit( GameObject gameObject );

    public void OnInteract();
}