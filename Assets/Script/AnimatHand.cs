using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatHand : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private InputActionProperty _pinchAction;
    
    [SerializeField] private InputActionProperty _gripAction;

    [SerializeField] Animator _animate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggervalue = _pinchAction.action.ReadValue<float>();

          _animate.SetFloat("trigger ", triggervalue);

                float gripvalue = _gripAction.action.ReadValue<float>();
    
      _animate.SetFloat("grip", gripvalue);
    }



}
