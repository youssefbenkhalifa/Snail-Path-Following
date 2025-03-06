using UnityEngine;
using System.Collections.Generic;

public class Snail : MonoBehaviour
{
    public Transform path;
    List<Vector3> targets = new List<Vector3>(); 
    private int currentTargetIndex = 0;
    public float speed = 2.0f;



    // Start is called before the first frame update
    void Start()
    {
        targets.Add(new Vector3(4, -4, 0));  
        targets.Add(new Vector3(6, 3, 0));
        targets.Add(new Vector3(-7, -1, 0));
        // To start from the origin
        transform.position = new Vector3(0, 0, 0);
        transform.localScale = new Vector3(5,5,5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentTarget = targets[currentTargetIndex]; 

        // Getting the vector of the direction of movement
        Vector3 direction = (currentTarget - transform.position).normalized;

        // Move the snail towards the target position
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

        // Calculating the angle of rotation based on movement direction
        Quaternion rotation = Quaternion.FromToRotation(Vector3.right, direction);
        float angle = rotation.eulerAngles.z;

        // Rotate the snail along its forward axis (rolling motion)
        transform.rotation = Quaternion.Euler(0, 0, angle);

        if (Vector3.Distance(transform.position, currentTarget) < 0.1f)
        {
            currentTargetIndex = (currentTargetIndex + 1) % 3; 
        }
    }
}