using UnityEngine;

public class ExplosionController : MonoBehaviour {
    private void Start() => Invoke("DestroyIt", 0.8f);
    private void DestroyIt() => Destroy(gameObject);
}
