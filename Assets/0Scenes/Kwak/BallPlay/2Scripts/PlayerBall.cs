using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    AudioSource audio;

    void Awake()
    {
        // AudioSource 컴포넌트를 같은 게임 오브젝트에서 가져와서 audio 변수에 할당합니다.
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
