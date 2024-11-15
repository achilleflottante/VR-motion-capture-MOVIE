using UnityEngine;

public class RotateSkinnedMesh : MonoBehaviour
{
    public float rotationAngle = 90f; // Rotation en degrés autour de l'axe Y

    void Start()
    {
        // Accéder au SkinnedMeshRenderer du GameObject
        SkinnedMeshRenderer skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        if (skinnedMeshRenderer != null)
        {
            // Créer une copie du mesh pour la manipulation
            Mesh mesh = Instantiate(skinnedMeshRenderer.sharedMesh);
            skinnedMeshRenderer.sharedMesh = mesh;

            // Définir la rotation de 90° autour de l'axe Y
            Quaternion rotation = Quaternion.Euler(0, rotationAngle, 0); // 90° autour de Y
            Matrix4x4 rotationMatrix = Matrix4x4.Rotate(rotation);

            // Récupérer les vertices et les données des bones
            Vector3[] vertices = mesh.vertices;

            // Appliquer la rotation aux vertices
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i] = rotationMatrix.MultiplyPoint3x4(vertices[i]);
            }

            // Mettre à jour les vertices dans le mesh
            mesh.vertices = vertices;

            // Recalculer les normales pour l'éclairage
            mesh.RecalculateNormals();

            // Si tu veux aussi recalculer les tangentes, tu peux le faire ici :
            mesh.RecalculateTangents();
        }
        else
        {
            Debug.LogError("Aucun SkinnedMeshRenderer trouvé sur cet objet !");
        }
    }
}
