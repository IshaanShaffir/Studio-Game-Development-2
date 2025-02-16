using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
   public UnityEvent OnSpacePressed = new UnityEvent();
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            OnSpacePressed?.Invoke();
        }
    }

}
