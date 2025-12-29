using UnityEngine;

public abstract class InteractionStrategy : ScriptableObject, IInteraction
{
    [SerializeField] private Material HoverMaterial { get; set; }
    [SerializeField] private Material defaultMaterial { get; set; }	
    public string InteractionText { get; protected set; }

    public virtual void OnHoverEnter() { }

    public virtual void OnHoverExit() { }

    public abstract void OnInteract();
}

public interface IInteraction
{
    public string InteractionText { get; }
    public virtual void OnHoverEnter() { }

    public virtual void OnHoverExit() { }

    public abstract void OnInteract();
}