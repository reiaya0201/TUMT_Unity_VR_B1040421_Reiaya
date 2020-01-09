using UnityEngine;

public class SingleDoor : MonoBehaviour
{
    private Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();

    }

    public void OpenDoor()
    {
        ani.SetBool("isOpen_Obj_1", true);
    }
}
