using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Char_Selected : MonoBehaviour
{
    public void GameSceneCtrlChoice()
    {
        SceneManager.LoadScene(1); //어떤 씬 이름으로 이동할 건지
    }
    public void GameSceneCtrl()
    {
        SceneManager.LoadScene(2); //어떤 씬 이름으로 이동할 건지
    }


}
