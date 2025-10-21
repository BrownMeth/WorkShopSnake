using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Keeps a list of body segments following the head with smoothing.
/// Swap in physics-driven segments later (rigidbody joints or soft-body integration).
/// </summary>
public class SegmentFollower : MonoBehaviour
{
    public Transform head;
    public List<Transform> segments = new List<Transform>();
    public float followDistance = 0.5f;
    public float smoothSpeed = 10f;

    void LateUpdate()
    {
        if (head == null || segments == null || segments.Count == 0) return;

        Vector3 targetPos = head.position;
        Quaternion targetRot = head.rotation;

        for (int i = 0; i < segments.Count; i++)
        {
            Transform seg = segments[i];
            Vector3 desiredPos = Vector3.Lerp(seg.position, targetPos - targetRot * Vector3.forward * followDistance, Time.deltaTime * smoothSpeed);
            seg.position = desiredPos;
            seg.rotation = Quaternion.Slerp(seg.rotation, targetRot, Time.deltaTime * smoothSpeed);

            targetPos = seg.position;
            targetRot = seg.rotation;
        }
    }
}