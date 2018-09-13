using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void EndGame()
    {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Debug.Log("Game over");
            Invoke("Restart", restartDelay);
        }
    }
}
