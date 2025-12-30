using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableComponent : MonoBehaviour
{
    [SerializeField] private List<InteractionStrategy> interactionStrategies;

    public UnityEvent OnHoverStarted;
    public UnityEvent OnHoverEnded;
    public UnityEvent OnInteracted;

    public void OnHoverEnter()
    {
        foreach (var strategy in interactionStrategies)
        {
            if (strategy != null)
                strategy.OnHoverEnter(gameObject);
        }

        OnHoverStarted?.Invoke();
    }

    public void OnHoverExit()
    {
        foreach (var strategy in interactionStrategies)
        {
            if (strategy != null)
                strategy.OnHoverExit(gameObject);
        }
        
        OnHoverEnded?.Invoke();
    }

    public void OnInteract()
    {
        foreach (var strategy in interactionStrategies)
        {
            if (strategy != null)
                strategy.OnInteract();
        }
        
        OnInteracted?.Invoke();
    }
}