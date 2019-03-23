using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Start(){}
    void Update(){}

    public void StartScene(){
        SceneManager.LoadScene("StartScene");
    }
    public void LoadingScene(){
        SceneManager.LoadScene("LoadingScene");
    }
    public void MainGameScene(){
        SceneManager.LoadScene("MainGameScene");
    }
    public void JoinASelectScene(){
        SceneManager.LoadScene("SelectScene");
    }
}
