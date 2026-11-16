using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private bool wahrheitswert = true;
    public int zahl = 5;
    private float kommazahl = 5.5f;
    public string text = "Hallo Welt!";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        zahl = AddNumbers(7, 29);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int AddNumbers(int a, int b)
    {
        int ergebnis = a + b;
        Debug.Log("addNumbers-Ergebniss: " + ergebnis);

        return ergebnis;
    }
}
