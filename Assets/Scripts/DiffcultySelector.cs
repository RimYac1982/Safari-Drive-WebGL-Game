using UnityEngine;
using UnityEngine.SceneManagement;

public class DiffcultySelector : MonoBehaviour
{
    void Start()
    {
        EasySelect();
    }
    public void EasySelect()
    {
        PlayerPrefs.SetInt("Difficulty", 1);
        Debug.Log("Easy");
    }

    public void MediumSelect()
    {
        PlayerPrefs.SetInt("Difficulty", 2);
    }
    public void HardSelect()
    {
        PlayerPrefs.SetInt("Difficulty", 3);
    }
}
