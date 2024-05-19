using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    public GameObject crosshair; // Référence vers l'objet Image représentant le viseur

    void Start()
    {
        crosshair.SetActive(true);
    }
}
