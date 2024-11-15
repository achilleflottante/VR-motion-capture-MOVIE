using UnityEngine;

public class RotateMesh : MonoBehaviour
{
    public float rotationSpeed = 90f; // Vitesse de rotation en degrés par seconde

    private Vector3[] originalVertices;
    private Mesh mesh;

    void Start()
    {
        // Accéder au mesh via le SkinnedMeshRenderer
        SkinnedMeshRenderer skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        if (skinnedMeshRenderer != null)
        {
            // Créer une copie du mesh pour manipulation
            mesh = Instantiate(skinnedMeshRenderer.sharedMesh);
            skinnedMeshRenderer.sharedMesh = mesh;

            // Sauvegarder les vertices d'origine
            originalVertices = mesh.vertices.Clone() as Vector3[];
        }
        else
        {
            Debug.LogError("Aucun SkinnedMeshRenderer trouvé sur cet objet !");
        }
    }

    void Update()
    {
        if (mesh == null || originalVertices == null)
            return;

        // Calculer l'angle de rotation pour cette frame
        float angle = rotationSpeed * Time.deltaTime;
        Quaternion rotation = Quaternion.Euler(0, angle, 0);
        Matrix4x4 rotationMatrix = Matrix4x4.Rotate(rotation);

        // Appliquer la rotation aux vertices d'origine
        Vector3[] rotatedVertices = new Vector3[originalVertices.Length];
        for (int i = 0; i < originalVertices.Length; i++)
        {
            rotatedVertices[i] = rotationMatrix.MultiplyPoint3x4(originalVertices[i]);
        }

        // Mettre à jour le mesh avec les vertices transformés
        mesh.vertices = rotatedVertices;
        mesh.RecalculateNormals(); // Recalculer les normales pour l'éclairage
    }
}