using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationTest : MonoBehaviour
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

    private void Update()
    {
        EventHandler.CallMovementEvent(new MovementEventData
        {
            xInput = xInput,
            yInput = yInput,
            isWalking = isWalking,
            isRunning = isRunning,
            isIdle = isIdle,
            isCarrying = isCarrying,
            toolEffect = toolEffect,
            isUsingToolRight = isUsingToolRight,
            isUsingToolLeft = isUsingToolLeft,
            isUsingToolUp = isUsingToolUp,
            isUsingToolDown = isUsingToolDown,
            isLiftingToolRight = isLiftingToolRight,
            isLiftingToolLeft = isLiftingToolLeft,
            isLiftingToolUp = isLiftingToolUp,
            isLiftingToolDown = isLiftingToolDown,
            isPickingRight = isPickingRight,
            isPickingLeft = isPickingLeft,
            isPickingToolUp = isPickingToolUp,
            isPickingToolDown = isPickingToolDown,
            isSwingingToolRight = isSwingingToolRight,
            isSwingingToolLeft = isSwingingToolLeft,
            isSwingingToolUp = isSwingingToolUp,
            isSwingingToolDown = isSwingingToolDown,
            idleRight = idleRight,
            idleLeft = idleLeft,
            idleUp = idleUp,
            idleDown = idleDown
        });
    }
}
