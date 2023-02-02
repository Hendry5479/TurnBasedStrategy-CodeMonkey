using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    [SerializeField] TrailRenderer trailRenderer;
    [SerializeField] Transform bulletHitVFXPrefab;
    Vector3 targetPosition;
    public void Setup(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }

    void Update()
    {
        Vector3 moveDir = (targetPosition - transform.position).normalized;


        float distanceBeforeMoving = Vector3.Distance(transform.position , targetPosition);
        float moveSpeed = 200f;
        Vector3 newPosition = transform.position + (moveDir * moveSpeed * Time.deltaTime);
        //transform.position += moveDir * moveSpeed * Time.deltaTime;
        float distanceAfterMoving = Vector3.Distance(transform.position, newPosition);

        if (distanceBeforeMoving < distanceAfterMoving)
        {
            transform.position = targetPosition;
            trailRenderer.transform.parent = null;
            Instantiate(bulletHitVFXPrefab, targetPosition, Quaternion.identity);
            Destroy(gameObject);
        } else
        {
            transform.position = newPosition;
        }
    }
}
