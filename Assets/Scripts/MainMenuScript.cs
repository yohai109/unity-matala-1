using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuScript : MonoBehaviour
{
    public Canvas quitMenu;
    public Button starText;
    public Button exitText;
    // Start is called before the first frame update
    void Start()
    {
        quitMenu.enabled = false;
        
    }

    public void ExitPress() {
        quitMenu.enabled = true;
        starText.enabled = false;
        exitText.enabled = false;
    }

public void NoPress() {
        quitMenu.enabled = false;
        starText.enabled = true;
        exitText.enabled = true;
    }

    public void StartLevel () {
        SceneManager.LoadScene("Game");
    }


    public void ExitGame (){
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
