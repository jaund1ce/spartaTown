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
        // PlayerPrefs���� ����� ���� ID �ҷ�����
        string userID = PlayerPrefs.GetString("user_id");

        // ����� ID�� ������ ĳ���� �̸��� ����
        if (!string.IsNullOrEmpty(userID))
        {
            characterNameText.text = userID;
        }
        else
        {
            Debug.Log("����� ���� ID�� �����ϴ�.");
        }
    }
}
