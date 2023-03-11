using UnityEngine;

/// <summary>
/// When a bullet collides with another bullet, they kill each other, so I am making
/// a custom script to disable the splittable bullets minion collision with other bullets
/// for a short amount of time on their instantiation, in order to make them not collide
/// with each order, at that given point ONLY.
///
/// OBS: I changed the tags field in (TriggerOnCollision) to public in order to be able to do it.
/// </summary>
public class SplittableMinionBulltetController : MonoBehaviour {
    
    [SerializeField] private TriggerOnCollision triggerOnCollisionBullet;
    [SerializeField] private Hypertag bulletTag;
    
    // Start is called before the first frame update
    void Start() {
        triggerOnCollisionBullet.tags[0] = null;
        Invoke("EnableCollision", 1f);
    }

    private void EnableCollision() {
        triggerOnCollisionBullet.tags[0] = bulletTag;
    }
    

    
 
    
    
}
