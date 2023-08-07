using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    AudioSource audio;

    void Awake()
    {
        // AudioSource ������Ʈ�� ���� ���� ������Ʈ���� �����ͼ� audio ������ �Ҵ��մϴ�.
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            audio.Play();
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "Finish")
        {
            other.gameObject.SetActive(false);
        }
    }
}
