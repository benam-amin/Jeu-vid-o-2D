using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentSceneManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject playerMovement;
    public bool isPaused = false;

    public VoidEventChannel onPlayerDeath;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    private void OnEnable()
    {
        onPlayerDeath.OnEventRaised += Die;    
    }

    private void OnDisable()
    {
        onPlayerDeath.OnEventRaised -= Die;    
    }

    private void Die() {
        gameOverScreen.SetActive(true);
    }

    private void Pause() {
        if (Time.timeScale == 0) {
                Time.timeScale = 1;
                isPaused = false;
                playerMovement.GetComponent<PlayerMovement>().enabled = true;
            } else {
                Time.timeScale = 0;
                isPaused = true;
                playerMovement.GetComponent<PlayerMovement>().enabled = false;
            }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Pause();
        }
#if UNITY_EDITOR 
        if(Input.GetKeyDown(KeyCode.R)) {
            RestartGame();
        }
#endif
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
