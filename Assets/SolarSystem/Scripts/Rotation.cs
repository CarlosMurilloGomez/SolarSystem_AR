using UnityEngine;
public class Rotation : MonoBehaviour
{
    [Tooltip("Velocidad orbita/traslación")]
    public float Speed;
    void Update()
    {
        // El pivote rota sobre el Sol, arrastrando al planeta hijo
        transform.Rotate(Vector3.up, Speed * Time.deltaTime);
    }
}