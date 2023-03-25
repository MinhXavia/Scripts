using UnityEngine;

public class EnemyFollow : MonoBehaviour 
{
    public float speed;
    public float stoppingDistance;

    private Transform target;

    void Start()
    {
        target = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);  
            //Move towards to Target with 'speed * Time.deltaTime': speed faster than target's speed
        }
    }
}