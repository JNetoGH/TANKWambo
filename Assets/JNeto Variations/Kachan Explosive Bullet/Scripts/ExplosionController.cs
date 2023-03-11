using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplosionController : MonoBehaviour {

    [SerializeField] private Hypertag tankHypertag;
    [SerializeField] private Hypertag playerHypertag;
    private AnimatorController _animatorController;

    private void Start() => Invoke("DestroyIt", 0.8f);

    private void OnTriggerEnter2D(Collider2D col) {
        if (!col.gameObject.HasHypertag(tankHypertag)) 
            return;
        Destroy(col.gameObject); // kills the player
        
        // resets the level only when player is killed
        if (!col.gameObject.HasHypertag(playerHypertag))
            return;
        ReloadScene();
    }
    
    private void DestroyIt() => Destroy(gameObject);
    private void ReloadScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
}
