using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationControllerManager : MonoBehaviour
{
    public Animator animator;  // 캐릭터 오브젝트의 Animator 컴포넌트
    public RuntimeAnimatorController knightAnimatorController;  // Knight 애니메이션 컨트롤러
    public RuntimeAnimatorController lizardAnimatorController;  // Lizard 애니메이션 컨트롤러

    private void Start()
    {
        // PlayerPrefs에서 선택된 스프라이트 인덱스를 가져옴
        int selectedSpriteIndex = PlayerPrefs.GetInt("SelectedSpriteIndex", -1);

        // 선택된 스프라이트에 맞는 애니메이션 컨트롤러를 설정
        if (selectedSpriteIndex == 0)
        {
            // Knight 스프라이트가 선택된 경우
            animator.runtimeAnimatorController = knightAnimatorController;
        }
        else if (selectedSpriteIndex == 1)
        {
            // Lizard 스프라이트가 선택된 경우
            animator.runtimeAnimatorController = lizardAnimatorController;
        }
        else
        {
            Debug.LogError("잘못된 스프라이트 선택 값입니다.");
        }
    }

}
