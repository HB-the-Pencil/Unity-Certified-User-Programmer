using UnityEngine;

public class GameInstructions : MonoBehaviour
{
    [SerializeField] string controls = "Move using the WASD keys";
    void Start()
    {
        print(controls);
    }
}
