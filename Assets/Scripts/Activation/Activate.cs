using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class Activate : MonoBehaviour {
    StreamReader sr;
    int i;
    public GameObject TextBar;
    public GameObject TextBox;
    Text textObject;

    void Awake()
    {
        sr = new StreamReader("C:\\Users\\Requiem\\Documents\\CollaborativeRPG\\Assets\\Dialogue\\Dialogue.txt");
    }

    public void Read(int line) {
        for (i = 1; i < line; i++) {
            sr.ReadLine();
        }



        TextBox.SetActive(true);
        textObject = TextBar.GetComponent<Text>();
        textObject.text = sr.ReadLine();
    }



    public void End() {
        sr.Close();
    }
}
