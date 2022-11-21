using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorParamsChanger : MonoBehaviour
{
    private Animator _thisAnimator;

    private void Awake()
    {
        _thisAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            _thisAnimator.SetTrigger("ButtonPressedTrigger");
        }
    }
}
