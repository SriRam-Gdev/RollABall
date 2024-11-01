using UnityEngine;

public class Rotatecube : MonoBehaviour
{
     

    void Update()
    {
        transform.Rotate(new Vector3(30, 45, 60) * Time.deltaTime);
    }
}
