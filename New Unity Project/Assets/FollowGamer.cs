using UnityEngine;

public class FollowGamer : MonoBehaviour
{
    public Transform gamer;
    public Vector3 offset;

	void Update ()
    {
        transform.position = gamer.position + offset;
	}
}
