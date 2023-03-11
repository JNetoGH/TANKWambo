using UnityEngine;

public class ExplosiveBulletCustomController : MonoBehaviour {
    
    [SerializeField] private GameObject bulletExplosion;
    
    private VariableInstance _hits;
    public bool IsExploding { get; private set; }
    
    void Start() =>_hits = GetComponent<VariableInstance>();
    
    void Update() {
        UpdateStatus();
        if (IsExploding) 
            OverrideDeathWithExplosion();
    }
    
    private void UpdateStatus() => IsExploding = int.Parse(_hits.GetValueString()) == 0;

    private void OverrideDeathWithExplosion() {
        GameObject instance = Instantiate(bulletExplosion);
        instance.transform.position = this.transform.position;
        Debug.Log("explodiu");
        Destroy(this.gameObject);
    }

}
