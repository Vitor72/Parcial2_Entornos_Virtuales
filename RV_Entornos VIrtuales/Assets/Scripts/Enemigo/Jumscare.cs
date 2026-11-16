using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumscare : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvas;
    [SerializeField] private AudioSource audioS;

    
    public string muerte = "perdida";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public async Task Grito()
    {
        canvas.alpha = 1;
        audioS.Play();
        await Task.Delay(4000);
        SceneManager.LoadScene(muerte);



    }
}
