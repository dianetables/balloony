using UnityEngine;

public class Pathing : MonoBehaviour
{
    [SerializeField] private Transform[] waypoints;

    [SerializeField] private float moveSpeed = 30;

    private int waypointIndex = 0;
    //should i delete here or in the other one...
    public GameObject bloon;

    private void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    private void Update(){
        Move();
    }

    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position,
                                                    moveSpeed * Time.deltaTime);
        }
        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex += 1;
        }
        if (transform.position == waypoints[-1].transform.position)
        {
            //idk yet
            //Destroy(bloon);
        }
    }
}
