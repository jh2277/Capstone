using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendCharacter : MonoBehaviour
{
    public int characterID; // �� ĳ���͸��� ������ ID�� �����մϴ�.

    private void Start()
    {
        if (PlayerPrefs.HasKey("C_Data"))
        {
            int selectedCharacterID = PlayerPrefs.GetInt("C_Data");
            Debug.Log(selectedCharacterID);
            
            // ���� ĳ������ ID�� ���õ� ĳ������ ID�� ��ġ�ϸ� Ȱ��ȭ, �ƴϸ� ��Ȱ��ȭ
            if (characterID == selectedCharacterID)
            {
                Debug.Log("Activating character: " + characterID);
                gameObject.SetActive(true);
            }
            else
            {
                Debug.Log("Deactivating character: " + characterID);
                gameObject.SetActive(false);
            }
        }
        else
        {
            Debug.Log("No character data found.");
        }
    }
}

