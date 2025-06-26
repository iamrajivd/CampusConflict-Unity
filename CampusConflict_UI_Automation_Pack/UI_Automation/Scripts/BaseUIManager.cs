using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BaseUIManager : MonoBehaviour
{
    public TMP_Text energyText;
    public TMP_Text booksText;
    public TMP_Text laptopsText;

    private int energy = 100;
    private int books = 250;
    private int laptops = 60;

    void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        energyText.text = "⚡ " + energy;
        booksText.text = "📚 " + books;
        laptopsText.text = "💻 " + laptops;
    }

    public void OnBuildClicked()
    {
        Debug.Log("Open build menu.");
    }

    public void OnTrainClicked()
    {
        Debug.Log("Open training menu.");
    }

    public void OnResearchClicked()
    {
        Debug.Log("Open research window.");
    }

    public void OnAttackClicked()
    {
        Debug.Log("Matchmaking to start PvP...");
    }
}
