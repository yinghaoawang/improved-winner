public struct MovementEventData
{
    public float xInput;
    public float yInput;
    public bool isWalking;
    public bool isRunning;
    public bool isIdle;
    public bool isCarrying;
    public ToolEffect toolEffect;
    public bool isUsingToolRight;
    public bool isUsingToolLeft;
    public bool isUsingToolUp;
    public bool isUsingToolDown;
    public bool isLiftingToolRight;
    public bool isLiftingToolLeft;
    public bool isLiftingToolUp;
    public bool isLiftingToolDown;
    public bool isPickingRight;
    public bool isPickingLeft;
    public bool isPickingToolUp;
    public bool isPickingToolDown;
    public bool isSwingingToolRight;
    public bool isSwingingToolLeft;
    public bool isSwingingToolUp;
    public bool isSwingingToolDown;
    public bool idleRight;
    public bool idleLeft;
    public bool idleUp;
    public bool idleDown;
};

public delegate void MovementDelegate(MovementEventData eventData);

public static class EventHandler
{
    public static MovementDelegate MovementEvent;

    public static void CallMovementEvent(MovementEventData eventData)
    {
        if (MovementEvent != null)
        {
            MovementEvent(eventData);
        }
    }
}
