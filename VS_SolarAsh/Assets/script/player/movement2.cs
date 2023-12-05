using UnityEngine;

public class movement2 : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;

    [SerializeField] private float sprintMulti = 2f;

    public float TurnSpeed = 0.1f;

    private float TurnSpeedVelocity;


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 derection = new Vector3(horizontal, 0, vertical).normalized;

        if (derection.magnitude >= 0.1f)
        {
            float PlayerAngle = Mathf.Atan2(derection.x, derection.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, PlayerAngle, ref TurnSpeedVelocity, TurnSpeed);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 walkDir = Quaternion.Euler(0f, PlayerAngle, 0f) * Vector3.forward;

            if (Input.GetKey(KeyCode.LeftShift)) controller.Move(walkDir.normalized * speed * sprintMulti * Time.deltaTime);

            else controller.Move(walkDir.normalized * speed * Time.deltaTime);

        }
    }
}
