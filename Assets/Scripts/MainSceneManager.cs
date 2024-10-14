using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterSpriteRenderer;  // 스프라이트 렌더러
    [SerializeField] private Sprite[] allSprites;  // 모든 스프라이트 리스트 (게임에서 사용할 스프라이트)

    private void Start()
    {
        ApplySelectedSprite();  // 씬이 시작될 때 스프라이트 적용
    }

    private void ApplySelectedSprite()
    {
        // PlayerPrefs에서 선택된 스프라이트 이름을 불러옴
        string selectedSpriteName = PlayerPrefs.GetString("selectedSpriteName", "");

        if (!string.IsNullOrEmpty(selectedSpriteName))
        {
            // 모든 스프라이트 리스트에서 선택된 이름과 일치하는 스프라이트를 찾음
            foreach (Sprite sprite in allSprites)
            {
                if (sprite.name == selectedSpriteName)
                {
                    // 일치하는 스프라이트를 SpriteRenderer에 적용
                    characterSpriteRenderer.sprite = sprite;
                    Debug.Log("스프라이트 변경 완료: " + selectedSpriteName);
                    return;
                }
            }
            Debug.LogWarning("스프라이트를 찾을 수 없습니다: " + selectedSpriteName);
        }
        else
        {
            Debug.LogWarning("저장된 스프라이트가 없습니다.");
        }
    }
}
