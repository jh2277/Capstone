using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Char_Selected : MonoBehaviour
{
    public void GameSceneCtrlChoice()
    {
        SceneManager.LoadScene(1); //� �� �̸����� �̵��� ����
    }
    public void GameSceneCtrl()
    {
        SceneManager.LoadScene(2); //� �� �̸����� �̵��� ����
    }


}
