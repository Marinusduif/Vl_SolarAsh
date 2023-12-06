using UnityEngine;

public class movement3 : MonoBehaviour
{
    [SerializeField] private float momentum;
    [Header("speed settings")]
    [SerializeField] private float maxWalkSpeed;
    [SerializeField] private float maxSkateSpeed;
    [Header("acceleration settings")]
    [SerializeField] private float decelerateSpeed;
    [SerializeField] private float accelerateSpeed;
    [Header("turn settings")]
    [SerializeField] private float TurnSpeed = 0.1f;
    [SerializeField] private float TurnSpeedVelocity;
    [Header("references")]
    [SerializeField] private CharacterController controller;
    [SerializeField] private Transform cam;
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 derection = new Vector3(horizontal, 0, vertical).normalized;

        if (derection.magnitude >= 0.1f)
        {
            float PlayerAngle = Mathf.Atan2(derection.x, derection.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = 0f;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, PlayerAngle, ref TurnSpeedVelocity, TurnSpeed * 3);
            }
            else
            {
                angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, PlayerAngle, ref TurnSpeedVelocity, TurnSpeed);
            }
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            float tempX;

            if (derection.normalized.x < 0)
            {
                tempX = derection.normalized.x * -1;
            }
            else
            {
                tempX = derection.normalized.x;
            }
            float tempZ;

            if (derection.normalized.z < 0)
            {
                tempZ = derection.normalized.z * -1;
            }
            else
            {
                tempZ = derection.normalized.z;
            }

            momentum += (tempX + tempZ) * accelerateSpeed * Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                momentum = maxSkateSpeed;
            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (momentum > maxSkateSpeed)
                {
                    momentum -= Time.deltaTime * decelerateSpeed;
                }
            }
            else
            {
                if (momentum > maxWalkSpeed)
                {
                    momentum -= Time.deltaTime * decelerateSpeed;
                }
            }

            Vector3 walkDir = Quaternion.Euler(0f, PlayerAngle, 0f) * Vector3.forward;

            if (Input.GetKey(KeyCode.LeftShift)) controller.Move(transform.forward * momentum * Time.deltaTime);

            else controller.Move(walkDir.normalized * momentum * Time.deltaTime);


        }
    }
}
