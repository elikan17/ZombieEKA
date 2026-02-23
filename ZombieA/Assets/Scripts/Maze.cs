using UnityEngine;
using UnityEngine.InputSystem;

public class Maze : MonoBehaviour
{
    public GameObject maze;
    public float turnSpeed = 5f;
    
    private InputAction turn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        turn = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 turnValue = turn.ReadValue<Vector2>();
        maze.transform.Rotate(new Vector3(-turnValue.x, 0, -turnValue.y)* turnSpeed*Time.deltaTime);
        Debug.Log("turn val x: " + turnValue.x + " turn val y: " + turnValue.y);
    }
}
