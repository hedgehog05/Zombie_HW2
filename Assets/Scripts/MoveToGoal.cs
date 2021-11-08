using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoal : MonoBehaviour
{
    public float zombieSpeed = 1.0f;
    public float accuracy = 0.01f;
    public Transform goal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //calculating direction
        this.transform.LookAt(goal.position);
        //find direction
        Vector3 direction = goal.position - this.transform.position;

        Debug.DrawRay(this.transform.position, direction, Color.blue);

        if(direction.magnitude > accuracy)
        {
            //move the object
            this.transform.Translate(direction.normalized * zombieSpeed * Time.deltaTime, Space.World);
        }
    }
}
