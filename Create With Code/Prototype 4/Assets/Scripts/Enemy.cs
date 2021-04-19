using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRb;
    private GameObject player;
    public float speed = 3.0f;
    
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    
    void Update()
    {
        enemyRb.AddForce((player.transform.position - transform.position).normalized * speed);
    }
}
