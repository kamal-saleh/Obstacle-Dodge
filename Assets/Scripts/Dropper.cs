using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float TimeToWait = 5f;

    private MeshRenderer myMeshRenderer;
    private Rigidbody myRigidbody;
    
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        
        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TimeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
