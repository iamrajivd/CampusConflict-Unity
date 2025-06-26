using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void OnStartGame()
    {
        SceneManager.LoadScene("BaseScene");
    }

    public void OnGuilds()
    {
        Debug.Log("Guild panel coming soon.");
    }

    public void OnDailyRewards()
    {
        Debug.Log("Show daily rewards screen.");
    }

    public void OnLeaderboard()
    {
        Debug.Log("Open leaderboard.");
    }
}
