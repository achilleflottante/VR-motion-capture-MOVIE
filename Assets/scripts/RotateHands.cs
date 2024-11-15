using UnityEngine;

public class RotateHands : MonoBehaviour
{
    public float rotationAngle = 90f; // Rotation en degrés autour de l'axe Y

    void Start()
    {
        // Appliquer une rotation de 90° autour de l'axe Y à l'objet entier (y compris les bones)
        transform.Rotate(0, rotationAngle, 0, Space.Self);
    }


    void Update()
    {

        transform.Rotate(rotationAngle, 0, 0, Space.Self);

    }
}