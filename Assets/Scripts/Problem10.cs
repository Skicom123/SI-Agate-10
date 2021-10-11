using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Problem10 : MonoBehaviour
{   
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;   
    void Start()
    {
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        Button btn4 = button4.GetComponent<Button>();
        Button btn5 = button5.GetComponent<Button>();
        Button btn6 = button6.GetComponent<Button>();
        Button btn7 = button7.GetComponent<Button>();
        Button btn8 = button8.GetComponent<Button>();
        Button btn9 = button9.GetComponent<Button>();
        btn1.onClick.AddListener(OnClick1);
        btn2.onClick.AddListener(OnClick2);
        btn3.onClick.AddListener(OnClick3);
        btn4.onClick.AddListener(OnClick4);
        btn5.onClick.AddListener(OnClick5);
        btn6.onClick.AddListener(OnClick6);
        btn7.onClick.AddListener(OnClick7);
        btn8.onClick.AddListener(OnClick8);
        btn9.onClick.AddListener(OnClick9);
    }

    void OnClick1()
    {
        SceneManager.LoadScene("Problem1");
    }
    void OnClick2()
    {
        SceneManager.LoadScene("Problem2");
    }
    void OnClick3()
    {
        SceneManager.LoadScene("Problem3");
    }
    void OnClick4()
    {
        SceneManager.LoadScene("Problem4");
    }
    void OnClick5()
    {
        SceneManager.LoadScene("Problem5");
    }
    void OnClick6()
    {
        SceneManager.LoadScene("Problem6");
    }
    void OnClick7()
    {
        SceneManager.LoadScene("Problem7");
    }
    void OnClick8()
    {
        SceneManager.LoadScene("Problem8");
    }
    void OnClick9()
    {
        SceneManager.LoadScene("Problem9");
    }
}
