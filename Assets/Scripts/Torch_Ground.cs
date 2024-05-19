using UnityEngine;

public class Torch_Ground : MonoBehaviour
{
    public bool hasKey = true; // Variable pour savoir si l'objet possède la clé
    public Camera player; // Référence au GameObject du joueur
    public string interactKey = "e"; // Touche pour interagir
    public float interactionDistance = 4f; // Distance maximale d'interaction
    public GameObject ground_torch;
    public GameObject hand_torch;
    public GameObject crosshair; // Référence vers l'objet Image représentant le viseur

    void Update()
    {
        if (Input.GetKeyDown(interactKey)) {
            // Lance un rayon depuis la caméra du joueur
            RaycastHit hit;
            // The code below only checks if the camera is looking at something, but it doesn't check if the item is the key
            if (Physics.Raycast(player.transform.position, player.transform.forward, out hit, interactionDistance)) {
                if (hit.collider.gameObject != ground_torch) {
                    return;
                }
                // Vérifie si le rayon a touché cet objet
                // Si l'objet a la clé et que le joueur n'a pas déjà la clé
                if (hasKey) {
                    // Fait disparaître l'objet
                    ground_torch.SetActive(false);
                    hand_torch.SetActive(true);
                    // Modifie la variable Has_Key du joueur en True
                    hasKey = false;
                }
            }
        } else {
            crosshair.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}
