using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xAngle = 0;
    [SerializeField] private float yAngle = 0;
    [SerializeField] private float zAngle = 0;
    [SerializeField] private float spinSpeed = 0;
    
    void Start()
    {
        
    }

    void Update()
    {
        Spin();
    }

    void Spin()
    {
        Vector3 spinDirection = new Vector3(xAngle, yAngle, zAngle);
        transform.Rotate(spinDirection * Time.deltaTime * spinSpeed);
    }
}
