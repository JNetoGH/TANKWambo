using System;
using UnityEngine;

public class SplittableBulletCustomController : MonoBehaviour {
    
    [SerializeField] private GameObject splittableBulletMinion;
    
    private VariableInstance _hits;
    public bool IsSplitting { get; private set; }
    
    void Start() {
        _hits = GetComponent<VariableInstance>();
        
    }
    
    void Update() {
        UpdateStatus();
        if (IsSplitting) {
            Debug.Log("splitted");
            SplitIn3Minions();
            Destroy(this.gameObject);
        }
    }
    
    private void UpdateStatus() => IsSplitting = int.Parse(_hits.GetValueString()) == 0;

    private void SplitIn3Minions() {
        
        GameObject minionBullet1 = Instantiate(splittableBulletMinion);
        GameObject minionBullet2 = Instantiate(splittableBulletMinion);
        GameObject minionBullet3 = Instantiate(splittableBulletMinion);

        minionBullet1.transform.position = this.transform.position;
        minionBullet2.transform.position = this.transform.position;
        minionBullet3.transform.position = this.transform.position;

        minionBullet1.transform.rotation = this.transform.rotation;
        minionBullet2.transform.rotation = Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, 50);
        minionBullet3.transform.rotation = Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, -50);
    }


}
