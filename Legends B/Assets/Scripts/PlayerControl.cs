using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private float moveSpeed = 7;

    private CharacterController characterController;
    private Vector3 targetPosition;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        targetPosition = transform.position;
    }


    void Update()
    {
        float distToTarget = Vector3.Distance(targetPosition, transform.position);
        if(distToTarget > 1)
        {
            Vector3 direction = Vector3.Normalize(targetPosition- transform.position );
            characterController.Move(direction* moveSpeed* Time.deltaTime);
        }

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 500, layerMask))
            {
                Debug.Log("hit: " + hit.collider.name);
                targetPosition = hit.point;
                transform.LookAt(targetPosition);
            }
        }
    }


}
