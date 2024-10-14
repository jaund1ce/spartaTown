using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterSpriteRenderer;  // ��������Ʈ ������
    [SerializeField] private Sprite[] allSprites;  // ��� ��������Ʈ ����Ʈ (���ӿ��� ����� ��������Ʈ)

    private void Start()
    {
        ApplySelectedSprite();  // ���� ���۵� �� ��������Ʈ ����
    }

    private void ApplySelectedSprite()
    {
        // PlayerPrefs���� ���õ� ��������Ʈ �̸��� �ҷ���
        string selectedSpriteName = PlayerPrefs.GetString("selectedSpriteName", "");

        if (!string.IsNullOrEmpty(selectedSpriteName))
        {
            // ��� ��������Ʈ ����Ʈ���� ���õ� �̸��� ��ġ�ϴ� ��������Ʈ�� ã��
            foreach (Sprite sprite in allSprites)
            {
                if (sprite.name == selectedSpriteName)
                {
                    // ��ġ�ϴ� ��������Ʈ�� SpriteRenderer�� ����
                    characterSpriteRenderer.sprite = sprite;
                    Debug.Log("��������Ʈ ���� �Ϸ�: " + selectedSpriteName);
                    return;
                }
            }
            Debug.LogWarning("��������Ʈ�� ã�� �� �����ϴ�: " + selectedSpriteName);
        }
        else
        {
            Debug.LogWarning("����� ��������Ʈ�� �����ϴ�.");
        }
    }
}
