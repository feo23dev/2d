using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.Combats;
using UProje1.Movement;

namespace UProje1.Controllers
{
public class PlayerController : MonoBehaviour
{    
    
    Rigidbody2D _rigidbody2D;
    Jump _jump;
    PCInputController _PCInputController;
    LaunchProjectile _launchProjectile;
    AudioSource _audioSource;
    bool _isLeftMouseClicked;

    private void Awake() 
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _jump = GetComponent<Jump>();
        _launchProjectile = GetComponent<LaunchProjectile>();
        _PCInputController = new PCInputController();
        _audioSource = GetComponent<AudioSource>();
    }
    
    private void Update() 
    {
        if(_PCInputController.LeftMouseClickDown)
        {
            _isLeftMouseClicked =true;
        } 
        if(_PCInputController.rightMouseClickDown) 
        {
            _launchProjectile.Launch();
        }
    }

    private void FixedUpdate() 
    {
        if(_isLeftMouseClicked)
        {
            _jump.JumpAction(_rigidbody2D);
            _audioSource.Play();
            _isLeftMouseClicked = false;
        } 
    }

 


   
}   

}

