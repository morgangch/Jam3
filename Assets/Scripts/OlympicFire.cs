using UnityEngine;

public class OlympicFire : MonoBehaviour
{
    public bool hasKey = true; // Variable pour savoir si l'objet possède la clé
    public Camera player; // Référence au GameObject du joueur
    public string interactKey = "e"; // Touche pour interagir
    public float interactionDistance = 4f; // Distance maximale d'interaction
    public GameObject flame;
    public GameObject cauldron;

    void Update()
    {
        if (Input.GetKeyDown(interactKey) && PlayerPrefs.GetInt("has_torch") == 1) {
            // Lance un rayon depuis la caméra du joueur
            RaycastHit hit;
            // The code below only checks if the camera is looking at something, but it doesn't check if the item is the key
            if (Physics.Raycast(player.transform.position, player.transform.forward, out hit, interactionDistance)) {
                if (hit.collider.gameObject != cauldron) {
                    return;
                }
                // Vérifie si le rayon a touché cet objet
                // Si l'objet a la clé et que le joueur n'a pas déjà la clé
                if (hasKey) {
                    flame.SetActive(true);
                    hasKey = false;
                }
            }
        }
    }
}
