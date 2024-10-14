using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Scene_Lobby : MonoBehaviour
{
    [SerializeField] private Button confirmButton;  // 선택 확정 버튼

    private Sprite selectedSprite;
    private int selectedSpriteIndex = -1;  // 선택된 스프라이트의 인덱스
    public void OnSelectKnight()
    {
        selectedSpriteIndex = 0;  // knight 스프라이트 선택
    }

    // 두 번째 스프라이트(Lizard) 선택 (버튼 2 클릭 시 호출)
    public void OnSelectLizard()
    {
        selectedSpriteIndex = 1;  // lizard 스프라이트 선택
    }

    // 시작 버튼 클릭 시 호출
    public void OnStartGame()
    {
        if (selectedSpriteIndex != -1)
        {
            // 선택한 스프라이트의 인덱스를 저장
            PlayerPrefs.SetInt("SelectedSpriteIndex", selectedSpriteIndex);
            PlayerPrefs.Save();

            SceneManager.LoadScene("Main");
        }
        else
        {
            Debug.Log("스프라이트를 선택하세요.");
        }
    }
}
