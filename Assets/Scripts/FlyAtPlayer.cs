using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 0;

    private Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.position;
    }

    void Update()
    {
        MoveTowardsPlayer();
        DestroyWhenReachedPlayer();
    }

    private void MoveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    private void DestroyWhenReachedPlayer()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
