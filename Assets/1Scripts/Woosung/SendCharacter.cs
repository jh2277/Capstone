using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendCharacter : MonoBehaviour
{
    public int characterID; // 각 캐릭터마다 고유한 ID를 설정합니다.

    private void Start()
    {
        if (PlayerPrefs.HasKey("C_Data"))
        {
            int selectedCharacterID = PlayerPrefs.GetInt("C_Data");
            Debug.Log(selectedCharacterID);
            
            // 현재 캐릭터의 ID와 선택된 캐릭터의 ID가 일치하면 활성화, 아니면 비활성화
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

