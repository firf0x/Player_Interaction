using System;
using System.Collections.Generic;
using UnityEngine;

public class InteractableComponent : MonoBehaviour
{
    [SerializeField] private List<InteractionStrategy> interactionStrategies;
    [SerializeField] private Renderer objectRenderer;

    public event Action OnHoverStarted;
    public event Action OnHoverEnded;
    public event Action OnInteracted;

    public void OnHoverEnter()
    {
        foreach (var strategy in interactionStrategies)
        {
            if (strategy != null)
                strategy.OnHoverEnter();
        }
    }

    public void OnHoverExit()
    {
        foreach (var strategy in interactionStrategies)
        {
            if (strategy != null)
                strategy.OnHoverExit();
        }
    }

    public void OnInteract()
    {
        foreach (var strategy in interactionStrategies)
        {
            if (strategy != null)
                strategy.OnInteract();
        }
    }
}