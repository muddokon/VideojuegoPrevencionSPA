using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private float rotVelocity = 3f;

    private Vector3 rotVector;
    
    // Start is called before the first frame update
    void Start()
    {
        rotVector = new Vector3(0f, rotVelocity, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotVector);
    }
}
