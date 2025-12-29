using UnityEngine;

[CreateAssetMenu(fileName = "LogInteractionStrategy", menuName = "Scriptable Objects/Interaction/Log Strategy")]
public class LogInteractionStrategy : InteractionStrategy
{
    [SerializeField] private string beginMessage = "Interaction started!";
    [SerializeField] private string completeMessage = "Interaction completed!";
    
    public override void OnInteractionBegin()
    {
        Debug.Log(beginMessage);
    }
    
    public override void OnInteractionComplete()
    {
        Debug.Log(completeMessage);
    }
}