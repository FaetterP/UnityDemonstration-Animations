using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorParamsChanger : MonoBehaviour
{
    private Animator _thisAnimator;
    private bool _isBlinking = false;

    private void Awake()
    {
        _thisAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            _isBlinking = !_isBlinking;
            _thisAnimator.SetBool("ButtonPressedBool", _isBlinking);
        }
    }
}
