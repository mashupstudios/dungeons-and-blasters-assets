using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationstatecontroller2 : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    int isJumpingHash;
    int isWalkingbackHash;
    int isWalkingrightHash;
    int isWalkingleftHash;
    int isDancingHash;
    int isFiringHash;
    //int isWalkfireHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isJumpingHash = Animator.StringToHash("jumpPressed");
        isWalkingbackHash = Animator.StringToHash("isWalkingback");
        isWalkingrightHash = Animator.StringToHash("isWalkingright");
        isWalkingleftHash = Animator.StringToHash("isWalkingleft");
        isDancingHash = Animator.StringToHash("isDancing");
        isFiringHash = Animator.StringToHash("isFiring");
        //isWalkfireHash = Animator.StringToHash("isWalkfire");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isJumping = animator.GetBool(isJumpingHash);
        bool isWalkingback = animator.GetBool(isWalkingbackHash);
        bool isWalkingright = animator.GetBool(isWalkingrightHash);
        bool isWalkingleft = animator.GetBool(isWalkingleftHash);
        bool isDancing = animator.GetBool(isDancingHash);
        bool isFiring = animator.GetBool(isFiringHash);
        //bool isWalkfire = animator.GetBool(isWalkfireHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        bool jumpPressed = Input.GetKey("space");
        bool backwardPressed = Input.GetKey("s");
        bool rightPressed = Input.GetKey("d");
        bool leftPressed = Input.GetKey("a");
        bool dancePressed = Input.GetKey("g");
        bool FiringPressed = Input.GetMouseButtonDown(0);
        //bool WalkFirePressed = Input.GetMouseButtonDown(0);

        if (!isWalking && forwardPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool(isRunningHash, true);
        }

        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool(isRunningHash, false);
        }
        if (!isJumping && jumpPressed)
        {
            animator.SetBool(isJumpingHash, true);
        }
        if (isJumping && !jumpPressed)
        {
            animator.SetBool(isJumpingHash, false);
        }

        if (!isWalkingback && backwardPressed)
        {
            animator.SetBool(isWalkingbackHash, true);
        }
        if (isWalkingback && !backwardPressed)
        {
            animator.SetBool(isWalkingbackHash, false);
        }
        if (!isWalkingright && rightPressed)
        {
            animator.SetBool(isWalkingrightHash, true);
        }
        if (isWalkingright && !rightPressed)
        {
            animator.SetBool(isWalkingrightHash, false);
        }
        if (!isWalkingleft && leftPressed)
        {
            animator.SetBool(isWalkingleftHash, true);
        }
        if (isWalkingleft && !leftPressed)
        {
            animator.SetBool(isWalkingleftHash, false);
        }
        if (!isDancing && dancePressed)
        {
            animator.SetBool(isDancingHash, true);
        }
        if (isDancing && !dancePressed)
        {
            animator.SetBool(isDancingHash, false);
        }
        if (!isFiring && FiringPressed)
        {
            animator.SetBool(isFiringHash, true);
        }

        if (isFiring && !FiringPressed)
        {
            animator.SetBool(isFiringHash, false);
        }
    }
}