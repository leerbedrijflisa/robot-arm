﻿using UnityEngine;
using System.Collections;

public class AnimationIsDone : StateMachineBehaviour {

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("AnimationIsDone", true);
        animator.SetBool("GoPickUp", false);
    }
}
