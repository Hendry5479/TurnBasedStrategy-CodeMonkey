using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private Animator unityAnimator;
    Vector3 targetPosition;

    private void Update()
    {
        

        float stoppingDistance = 0.1f;
        if (Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            float moveSpeed = 4f;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
            unityAnimator.SetBool("IsWalking", true);
        } else
        {
            unityAnimator.SetBool("IsWalking", false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Move(MouserWorld.GetPosition());
        }
    }

    void Move(Vector3 targetPosition)
    {
        this.targetPosition= targetPosition;
    }
}
