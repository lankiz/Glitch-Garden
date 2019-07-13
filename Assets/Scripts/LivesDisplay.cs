using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float baseLives = 3;
    float lives;
    [SerializeField] int damage = 1;
    Text livesText;
    // Start is called before the first frame update
    void Start()
    {
        lives = baseLives - PlayerPrefsController.GetDifficulty();
        livesText = GetComponent<Text>();
        UpdateDisplay();
        Debug.Log("difficulty setting currently is " + PlayerPrefsController.GetDifficulty());
    }

    // Update is called once per frame
    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }
    public float Getlives()
    {
        return lives;
    }
    public void ReduceLives()
    {
        lives -= damage;
        UpdateDisplay();
        
        if(lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }

    }
    


    void Update()
    {

    }
}