using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MASTER : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animator panelAnim;
    void Start()
    {
        panelAnim = panelAnim.GetComponent<Animator>();
        panelAnim.enabled = false;
    }

    void Update()
    {
        
    }

    public void SettingsBtn()
    {
        panelAnim.enabled = true;
        panelAnim.SetBool("in", true);
    }
    public void StartBtn()
    {
        SceneManager.LoadScene("scenemain");
    }
    public void ClosePanel()
    {
        panelAnim.SetBool("in", false);
    }
}
