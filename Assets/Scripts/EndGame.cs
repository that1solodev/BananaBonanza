using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Text txt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scr = PlayerPrefs.GetFloat("score", 0);
        txt.text = "Final Score: " + scr.ToString("0");
    }
    public void restartGame()
    {
        SceneManager.LoadScene(1);

    }
    public void mainGame()
    {
        SceneManager.LoadScene(0);
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
