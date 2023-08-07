using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource backgroundMusic;

    // ��������� ����ϴ� �޼���
    public void PlayBackgroundMusic()
    {
        backgroundMusic.Play();
    }

    // ��������� �Ͻ������ϴ� �޼���
    public void PauseBackgroundMusic()
    {
        backgroundMusic.Pause();
    }

    // ��������� �����ϴ� �޼���
    public void StopBackgroundMusic()
    {
        backgroundMusic.Stop();
    }
}
