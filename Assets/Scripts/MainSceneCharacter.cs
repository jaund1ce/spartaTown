using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainSceneCharacter : MonoBehaviour
{
    [Header("Character Name Display")]
    [SerializeField] private TextMeshProUGUI characterNameText;

    private void Start()
    {
        // PlayerPrefs에서 저장된 유저 ID 불러오기
        string userID = PlayerPrefs.GetString("user_id");

        // 저장된 ID가 있으면 캐릭터 이름을 변경
        if (!string.IsNullOrEmpty(userID))
        {
            characterNameText.text = userID;
        }
        else
        {
            Debug.Log("저장된 유저 ID가 없습니다.");
        }
    }
}
