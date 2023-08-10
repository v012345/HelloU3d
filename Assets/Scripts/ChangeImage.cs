using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
               this.GetComponent<Button>().onClick.AddListener
            (delegate()
            {
                OnClick_close(this.gameObject);
            });
    }
       public void OnClick_close(GameObject _obj)
    {
        print("点击了按钮："+_obj.name);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
