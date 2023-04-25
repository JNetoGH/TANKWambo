using System;
using OkapiKit;
using UnityEngine;

public class JNetoBasicTankAtkModeManager : MonoBehaviour
{
    [SerializeField] private MovementFollow movementFollow;
    
    private void OnEnable() => movementFollow.enabled = false;
    private void Awake() => movementFollow.enabled = false;
    private void Start() => movementFollow.enabled = false;
    private void OnTriggerEnter2D(Collider2D col) => movementFollow.enabled = true;
    private void OnTriggerExit2D(Collider2D other) => movementFollow.enabled = false;
}
