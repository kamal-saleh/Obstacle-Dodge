using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't bump into objects!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal");
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xValue, yValue, zValue);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
