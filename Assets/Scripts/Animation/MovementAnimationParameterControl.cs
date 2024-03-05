using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnimationParameterControl: MonoBehaviour
{
    private Animator animator;

    void AnimationEventPlayFootstepSound()
    {
        
    }

    public void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnEnable()
    {
        EventHandler.MovementEvent += SetAnimationParameters;
    }

    public void OnDisable()
    {
        EventHandler.MovementEvent -= SetAnimationParameters;
    }

    public void SetAnimationParameters(MovementEventData eventData)
    {
        animator.SetFloat(Animator.StringToHash("xInput"), eventData.xInput);
        animator.SetFloat(Animator.StringToHash("yInput"), eventData.yInput);
        animator.SetBool(Animator.StringToHash("isWalking"), eventData.isWalking);
        animator.SetBool(Animator.StringToHash("isRunning"), eventData.isRunning);
        animator.SetInteger(Animator.StringToHash("toolEffect"), (int)eventData.toolEffect);

        if (eventData.isUsingToolRight)
            animator.SetTrigger(Animator.StringToHash("isUsingToolRight"));
        if (eventData.isUsingToolLeft)
            animator.SetTrigger(Animator.StringToHash("isUsingToolLeft"));
        if (eventData.isUsingToolUp)
            animator.SetTrigger(Animator.StringToHash("isUsingToolUp"));
        if (eventData.isUsingToolDown)
            animator.SetTrigger(Animator.StringToHash("isUsingToolDown"));

        if (eventData.isLiftingToolRight)
            animator.SetTrigger(Animator.StringToHash("isLiftingToolRight"));
        if (eventData.isLiftingToolLeft)
            animator.SetTrigger(Animator.StringToHash("isLiftingToolLeft"));
        if (eventData.isLiftingToolUp)
            animator.SetTrigger(Animator.StringToHash("isLiftingToolUp"));
        if (eventData.isLiftingToolDown)
            animator.SetTrigger(Animator.StringToHash("isLiftingToolDown"));

        if (eventData.isPickingRight)
            animator.SetTrigger(Animator.StringToHash("isPickingRight"));
        if (eventData.isPickingLeft)
            animator.SetTrigger(Animator.StringToHash("isPickingLeft"));
        if (eventData.isPickingToolUp)
            animator.SetTrigger(Animator.StringToHash("isPickingToolUp"));
        if (eventData.isPickingToolDown)
            animator.SetTrigger(Animator.StringToHash("isPickingToolDown"));

        if (eventData.isSwingingToolRight)
            animator.SetTrigger(Animator.StringToHash("isSwingingToolRight"));
        if (eventData.isSwingingToolLeft)
            animator.SetTrigger(Animator.StringToHash("isSwingingToolLeft"));
        if (eventData.isSwingingToolUp)
            animator.SetTrigger(Animator.StringToHash("isSwingingToolUp"));
        if (eventData.isSwingingToolDown)
            animator.SetTrigger(Animator.StringToHash("isSwingingToolDown"));

        if (eventData.idleRight)
            animator.SetTrigger(Animator.StringToHash("idleRight"));
        if (eventData.idleLeft)
            animator.SetTrigger(Animator.StringToHash("idleLeft"));
        if (eventData.idleUp)
            animator.SetTrigger(Animator.StringToHash("idleUp"));
        if (eventData.idleDown)
            animator.SetTrigger(Animator.StringToHash("idleDown"));
    }
}
