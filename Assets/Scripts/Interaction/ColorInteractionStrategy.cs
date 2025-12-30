using UnityEngine;

[CreateAssetMenu(fileName = "ColorInteractionStrategy", menuName = "Scriptable Objects/Interaction/Log Strategy")]
public class ColorInteractionStrategy : InteractionStrategy
{
    [SerializeField] private Color color = Color.black;
    private GameObject objectStrategy;

    public override void OnHoverEnter(GameObject gameObject)
    {
        objectStrategy = gameObject;
    }

    public override void OnInteract()
    {
        objectStrategy.GetComponent<Renderer>().material.color = color;
    }
}