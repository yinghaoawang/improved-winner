using UnityEngine;

public class Player : SingletonMonobehaviour<Player>
{
    private float xInput;
    private float yInput;

    private bool isIdle;
    private bool isRunning;
    private bool isWalking;
    private bool isCarrying = false;

    private bool isUsingToolRight;
    private bool isUsingToolLeft;
    private bool isUsingToolUp;
    private bool isUsingToolDown;
    private bool isLiftingToolRight;
    private bool isLiftingToolLeft;
    private bool isLiftingToolUp;
    private bool isLiftingToolDown;
    private bool isPickingRight;
    private bool isPickingLeft;
    private bool isPickingToolUp;
    private bool isPickingToolDown;
    private bool isSwingingToolRight;
    private bool isSwingingToolLeft;
    private bool isSwingingToolUp;
    private bool isSwingingToolDown;
    private ToolEffect toolEffect = ToolEffect.None;

    private Rigidbody2D rigidbody2D;

    private Direction direction;
    private float movementSpeed;
    private bool _playerInputIsDisabled = false;
    public bool PlayerInputIsDisabled
    {
        get => _playerInputIsDisabled;
        set => _playerInputIsDisabled = value;
    }

    protected override void Awake()
    {
        base.Awake();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        #region Player Input

        ResetAnimationTriggers();
        PlayerMovementInput();
        PlayerWalkInput();
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
            idleRight = false,
            idleLeft = false,
            idleUp = false,
            idleDown = false
        });

        #endregion
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        Vector2 move = new Vector2(xInput * movementSpeed * Time.fixedDeltaTime, yInput * movementSpeed * Time.fixedDeltaTime);
        rigidbody2D.MovePosition(rigidbody2D.position + move);
    }

    private void ResetAnimationTriggers()
    {
        isUsingToolRight = false;
        isUsingToolLeft = false;
        isUsingToolUp = false;
        isUsingToolDown = false;
        isLiftingToolRight = false;
        isLiftingToolLeft = false;
        isLiftingToolUp = false;
        isLiftingToolDown = false;
        isPickingRight = false;
        isPickingLeft = false;
        isPickingToolUp = false;
        isPickingToolDown = false;
        isSwingingToolRight = false;
        isSwingingToolLeft = false;
        isSwingingToolUp = false;
        isSwingingToolDown = false;
        toolEffect = ToolEffect.None;
    }

    private void PlayerMovementInput()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

        if (xInput != 0 && yInput != 0)
        {
            xInput *= .71f;
            yInput *= .71f;
        }
        if (xInput != 0 || yInput != 0)
        {
            isRunning = true;
            isWalking = false;
            isIdle = false;
            movementSpeed = Settings.runningSpeed;

            if (xInput < 0)
            {
                direction = Direction.Left;
            }
            else if (xInput > 0)
            {
                direction = Direction.Right;
            }
            else if (yInput < 0)
            {
                direction = Direction.Down;
            }
            else
            {
                direction = Direction.Up;
            }
        }
        else if (xInput == 0 && yInput == 0)
        {
            isWalking = false;
            isRunning = false;
            isIdle = true;
        }
    }

    private void PlayerWalkInput()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            isRunning = false;
            isWalking = true;
            isIdle = false;
            movementSpeed = Settings.walkingSpeed;
        }
        else
        {
            isRunning = true;
            isWalking = false;
            isIdle = false;
            movementSpeed = Settings.runningSpeed;
        }
    }
}
