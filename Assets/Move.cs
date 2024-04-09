using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 10;
    [SerializeField] private float rotationSpeed = 25;

    private float rotateAxis;

    private float moveAxis;

    private Rigidbody tankRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        tankRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        /*
        localTransform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        localTransform.Translate(Input.GetAxis("Vertical") * Vector3.forward * maxSpeed * Time.deltaTime);
        */
        
        transform.Rotate(Vector3.up, -rotateAxis * rotationSpeed * Time.deltaTime);
        
        // transform.Translate( -moveAxis * maxSpeed * Vector3.forward);
        
        // tankRigidbody.AddRelativeForce(Time.deltaTime * -moveAxis * maxSpeed * Vector3.forward, ForceMode.VelocityChange);
        
        tankRigidbody.AddForce(-moveAxis * maxSpeed * transform.forward, ForceMode.Force);
    }

    public void HandleRotate(InputAction.CallbackContext inputContext)
    {
        rotateAxis = inputContext.ReadValue<float>();
        Debug.Log("Rotate  = " + rotateAxis);
    }

    public void BackwardForward(InputAction.CallbackContext inputContext)
    {
        moveAxis = inputContext.ReadValue<float>();
        Debug.Log("Rotate  = " + rotateAxis);
    }
    
}