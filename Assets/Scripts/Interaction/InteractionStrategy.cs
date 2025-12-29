using UnityEngine;

public abstract class InteractionStrategy : ScriptableObject, IInteraction
{
    public virtual void OnHoverEnter() { }

    public virtual void OnHoverExit() { }

    public abstract void OnInteract();
}

public interface IInteraction
{
    public virtual void OnHoverEnter() { }

    public virtual void OnHoverExit() { }

    public abstract void OnInteract();
}