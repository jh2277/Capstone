using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    //UI�� ���� �̹��� ���۳�Ʈ �����
    public List<Image> currentColor = new List<Image>();
    public List<Image> targetColor = new List<Image>();

    //ó�� 3�ʸ� �̹��� �����ְԲ�.
    public float displayTime = 2f;

    //���� ���
    public List<Color> colorList; // ������� �������� ���� ���� ���
    private int currentIndex = 0; // ���� ������ ������ �ε���

    //�˸��� ������ �������� �Ծ��� �� ���� ����
    public AudioSource Sound;
    public AudioClip fail;
    public AudioClip success;
    public AudioClip Finish;


    //���� ���� �� UI
    public GameObject gameClear;
    //Scene Change
    public int stage;
    public bool finalStage;

    //���
    private int currentHeart = 0; // ���� ��� ���� �ε���
    public List<RawImage> heart = new List<RawImage>();



    void Start() //ù �����ӿ� ����
    {
        //���� ��ü ��������
        Sound = GetComponent<AudioSource>();


        //���� �߰�
        HideCurrentImages();
        colorList.Add(Color.red);
        colorList.Add(Color.yellow);
        colorList.Add(Color.blue);
        // ������ ������ ���� ���� ����Ʈ�� �����ϰ� �����ϴ�.
        ShuffleColorList();
        // ������ ������ ����մϴ�.
        PrintColorList();
    }


    // ������ ������ �����ϰ� ���� �Լ�
    void ShuffleColorList()
    {
        for (int i = 0; i < colorList.Count; i++)
        {
            Color temp = colorList[i];
            int randomIndex = Random.Range(i, colorList.Count);
            colorList[i] = colorList[randomIndex];
            colorList[randomIndex] = temp;
            
        }
    }

    // ������ ������ ����ϴ� �Լ�
    void PrintColorList()
    {
        for (int i = 0; i < colorList.Count; i++)
        {
            targetColor[i].color = colorList[i]; //���� 
        }
        //�ڷ�ƾ �����Ͽ� 3�ʸ� �̹��� ��Ÿ���� ����.
        StartCoroutine(HideImageAfterDelay(displayTime));
    }
    IEnumerator HideImageAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // delay �ð�(3��)��ŭ ����մϴ�.

        HideTargetImages(); // Traget�̹����� ��Ȱ��ȭ�ϸ鼭 ���ÿ�
        ShowCurrentImages();// Current�̹��� Ȱ��ȭ.
    }
    void HideTargetImages() // Traget�̹����� ��Ȱ��ȭ�Լ�
    {
        foreach (Image image in targetColor)
        {
            image.enabled = false; 
        }
    }
    void HideCurrentImages() // Current�̹����� ��Ȱ��ȭ�Լ�
    {
        foreach (Image image in currentColor)
        {
            image.enabled = false; 
        }
    }
    void ShowCurrentImages() //Current�̹��� Ȱ���Լ�
    {
        foreach (Image image in currentColor)
        {
            image.enabled = true;
        }
    }
    //�÷��̾ �������� ���� �� ȣ��Ǵ� �Լ�
    public void EatItem(GameObject obj)
    {
        //���� �����۰� ��ġ�ϴ��� Ȯ���ϰ� ���� ���������� �����մϴ�.
        Color color = obj.GetComponent<Renderer>().material.color;

        if (color == targetColor[currentIndex].color)
        {
            Debug.Log("����! ���� ���������� �����մϴ�.");
            Sound.clip = success;
            Sound.Play();
            currentColor[currentIndex].color = targetColor[currentIndex].color;
            currentIndex++;
            Destroy(obj);

            // ��� �������� �� �Ծ��� �� ���� Ŭ���� ó���� �� ���� �ֽ��ϴ�.
            if (currentIndex == colorList.Count)
            {
                Debug.Log("���� Ŭ����!");
                Sound.clip = Finish;
                Sound.Play();
                gameClear.SetActive(true);
                // ���� Ŭ���� ó�� �߰�
                StartCoroutine(NextStage(1.5f));
                
            }
        }
        else
        {
            Debug.Log("Ʋ�Ƚ��ϴ�!");
            Sound.clip = fail;
            Sound.Play();
            // ���� ���� ó�� �߰�
        }
    }
    IEnumerator NextStage(float delay)
    {
        yield return new WaitForSeconds(delay); // delay �ð�(3��)��ŭ ����մϴ�.

        if (!finalStage)
        {
            SceneManager.LoadScene(stage + 1);
        }
        else
        {
            ExitGame();
        }

    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif

    }
    public void LifeDecrease() // ��� ���� �Լ�
    {
        if (heart.Count>0)
        {
            RawImage rawImage = heart[currentHeart];
            rawImage.gameObject.SetActive(false);
            currentHeart++;
        }
    }

}