using UnityEngine;

public class FollowToTheSide : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void FixedUpdate()
    {
        transform.position = target.position + Vector3.up * offset.y +
                             Vector3.ProjectOnPlane(target.right, Vector3.up).normalized * offset.x +
                             Vector3.ProjectOnPlane(target.forward, Vector3.up).normalized * offset.z;

        transform.eulerAngles = new Vector3(0, target.eulerAngles.y, 0);
    }
}