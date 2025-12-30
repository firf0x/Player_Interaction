using UnityEngine;

[CreateAssetMenu(fileName = "LogInteractionStrategy", menuName = "Scriptable Objects/Interaction/LogInteractionStrategy")]
public class LogInteractionStrategy : InteractionStrategy
{
    [SerializeField] private string completeMessage = "Interaction completed!";

    public override void OnInteract()
    {
        Debug.Log(completeMessage);
    }
}