using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    // Start is called before the first frame update
    public RawImage img;
    private int b = 0;
    private bool v = false;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            OnClick_close(this.gameObject);
        });
    }
    public void OnClick_close(GameObject _obj)
    {
        if (b < 5)
        {

            //GameObject.Find("RawImage").SetActive(false);
            this.img.gameObject.SetActive(this.v);
        }
        else
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
        this.b++;
        this.v = !this.v;

        print("点击了按钮：" + _obj.name);

    }
    // Update is called once per frame
    void Update()
    {

    }
}
