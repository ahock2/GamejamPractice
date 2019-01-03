using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetGamer : MonoBehaviour {
    Vector3 StartPosition;
    Quaternion StartRotation;

    void Start()
    {
        StartPosition.Set(0f, 0.5f, 0f);
        StartRotation.Set(0f, 0f, 0f, 0f);
    }
    // Update is called once per frame
    void Update ()
    {
        if (transform.position.y < -5)
        {
            //transform.SetPositionAndRotation(StartPosition, StartRotation);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

	}
}
