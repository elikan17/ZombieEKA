using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject selectedZombie;
    public GameObject[] zombies;
    public Vector3 selectedSize;
    public Vector3 pushForce;
    private InputAction left, right, jump;
    private int selectedIndex = 0;
    public TMP_Text timerText;
    private float time = 0;
    
    
    void Start()
    {
        SelectZombie(0);
        left = InputSystem.actions.FindAction("PreviousZombie");
        right = InputSystem.actions.FindAction("NextZombie");
        jump =  InputSystem.actions.FindAction("Jump");
    }

    void SelectZombie(int index)
    {
        if (selectedZombie != null)
            selectedZombie.transform.localScale = Vector3.one;
        selectedZombie = zombies[index];
        selectedZombie.transform.localScale = selectedSize;
        Debug.Log("selected: " + selectedZombie.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (left.triggered)
        {
            selectedIndex--;
            if (selectedIndex < 0)
                selectedIndex = zombies.Length - 1;
            SelectZombie(selectedIndex);
            Debug.Log("left pressed");
        }
        if (right.triggered)
        {
            selectedIndex++;
            if(selectedIndex >= zombies.Length)
                selectedIndex = 0;
            SelectZombie(selectedIndex);
            Debug.Log("right pressed");
        }

        if (jump.triggered)
        {
            Rigidbody rb = selectedZombie.GetComponent<Rigidbody>();
            rb.AddForce(pushForce);
            Debug.Log("jump");
        }
        time += Time.deltaTime;
        timerText.text = "Time: " + time.ToString("F1") + "s";
    }
}
