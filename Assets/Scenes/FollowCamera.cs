using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject overviewCamera;
    void LateUpdate() {
        transform.position = overviewCamera.transform.position + new Vector3 (0, 0, -0.5f);
    }
}
