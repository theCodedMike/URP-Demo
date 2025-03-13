using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 A = new Vector2(1, 2);
        Vector2 B = new Vector2(0, 1);
        float distance = Vector2.Distance(A, B);
        print($"distance: {distance}");
        Vector2 BA = A - B;
        print($"Distance: {distance}, Magnitude of BA: {BA.magnitude}");
        print($"n: {BA / distance}, Normalized of BA: {BA.normalized}");
        print($"Angle: {Vector2.Angle(A, B)}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
