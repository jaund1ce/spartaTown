using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteManager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;  // �÷��̾� ������Ʈ�� ��������Ʈ ������

    public Sprite sprite1;
    public Sprite sprite2;

    private void Start()
    {
        // PlayerPrefs���� ������ ��������Ʈ �̸��� ������
        string selectedSpriteName = PlayerPrefs.GetString("SelectedSprite");

        // ������ ��������Ʈ �̸��� �´� ��������Ʈ�� ����
        if (selectedSpriteName == sprite1.name)
        {
            spriteRenderer.sprite = sprite1;
        }
        else if (selectedSpriteName == sprite2.name)
        {
            spriteRenderer.sprite = sprite2;
        }
        else
        {
            Debug.Log("��������Ʈ�� ã�� �� �����ϴ�.");
        }
    }
}
