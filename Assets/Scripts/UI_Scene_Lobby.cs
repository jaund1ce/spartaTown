using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Scene_Lobby : MonoBehaviour
{
    [SerializeField] private Button confirmButton;  // ���� Ȯ�� ��ư

    private Sprite selectedSprite;
    private int selectedSpriteIndex = -1;  // ���õ� ��������Ʈ�� �ε���
    public void OnSelectKnight()
    {
        selectedSpriteIndex = 0;  // knight ��������Ʈ ����
    }

    // �� ��° ��������Ʈ(Lizard) ���� (��ư 2 Ŭ�� �� ȣ��)
    public void OnSelectLizard()
    {
        selectedSpriteIndex = 1;  // lizard ��������Ʈ ����
    }

    // ���� ��ư Ŭ�� �� ȣ��
    public void OnStartGame()
    {
        if (selectedSpriteIndex != -1)
        {
            // ������ ��������Ʈ�� �ε����� ����
            PlayerPrefs.SetInt("SelectedSpriteIndex", selectedSpriteIndex);
            PlayerPrefs.Save();

            SceneManager.LoadScene("Main");
        }
        else
        {
            Debug.Log("��������Ʈ�� �����ϼ���.");
        }
    }
}
