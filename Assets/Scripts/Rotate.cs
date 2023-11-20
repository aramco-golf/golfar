using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Transform rotateT;
    [SerializeField] private float _speed = 10;
    private bool isRotating;

    public void StartRotate()
    {
        isRotating = true;
       // GetComponent<Animator>().enabled = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            rotateT.Rotate(Vector3.up, _speed * Time.deltaTime);
        }
    }
}
