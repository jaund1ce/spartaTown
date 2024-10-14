using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationControllerManager : MonoBehaviour
{
    public Animator animator;  // ĳ���� ������Ʈ�� Animator ������Ʈ
    public RuntimeAnimatorController knightAnimatorController;  // Knight �ִϸ��̼� ��Ʈ�ѷ�
    public RuntimeAnimatorController lizardAnimatorController;  // Lizard �ִϸ��̼� ��Ʈ�ѷ�

    private void Start()
    {
        // PlayerPrefs���� ���õ� ��������Ʈ �ε����� ������
        int selectedSpriteIndex = PlayerPrefs.GetInt("SelectedSpriteIndex", -1);

        // ���õ� ��������Ʈ�� �´� �ִϸ��̼� ��Ʈ�ѷ��� ����
        if (selectedSpriteIndex == 0)
        {
            // Knight ��������Ʈ�� ���õ� ���
            animator.runtimeAnimatorController = knightAnimatorController;
        }
        else if (selectedSpriteIndex == 1)
        {
            // Lizard ��������Ʈ�� ���õ� ���
            animator.runtimeAnimatorController = lizardAnimatorController;
        }
        else
        {
            Debug.LogError("�߸��� ��������Ʈ ���� ���Դϴ�.");
        }
    }

}
