using UnityEngine;

[CreateAssetMenu(fileName = "ChangeColorInteractionStrategy", menuName = "Scriptable Objects/Interaction/ChangeColorInteractionStrategy")]
public class ChangeColorInteractionStrategy : InteractionStrategy
{
    [SerializeField] private Color color = Color.black;
    private Color defaultColor;
    private GameObject objectStrategy;

    public override void OnHoverEnter(GameObject gameObject)
    {
        objectStrategy = gameObject;

        defaultColor = objectStrategy.GetComponent<Renderer>().material.color;
        objectStrategy.GetComponent<Renderer>().material.color = color;
    }

    public override void OnHoverExit(GameObject gameObject)
    {
        objectStrategy.GetComponent<Renderer>().material.color = defaultColor;
    }

    public override void OnInteract() { }
}