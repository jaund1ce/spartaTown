using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteManager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;  // 플레이어 오브젝트의 스프라이트 렌더러

    public Sprite sprite1;
    public Sprite sprite2;

    private void Start()
    {
        // PlayerPrefs에서 선택한 스프라이트 이름을 가져옴
        string selectedSpriteName = PlayerPrefs.GetString("SelectedSprite");

        // 가져온 스프라이트 이름에 맞는 스프라이트를 설정
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
            Debug.Log("스프라이트를 찾을 수 없습니다.");
        }
    }
}
