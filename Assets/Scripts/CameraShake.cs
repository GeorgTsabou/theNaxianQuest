using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Camera Information
    public Transform cameraTransform;
    private Vector3 orignalCameraPos;

    // Shake Parameters
    public float shakeAmount = 0.7f;

  


    // Start is called before the first frame update
    void Start()
    {
        orignalCameraPos = cameraTransform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

        ShakeCamera();

    }

    public void ShakeCamera()
    {
        cameraTransform.localPosition = orignalCameraPos + Random.insideUnitSphere * shakeAmount;
    }

  

}