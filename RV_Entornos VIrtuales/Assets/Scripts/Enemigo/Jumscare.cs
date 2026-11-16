using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Jumscare : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvas;
    [SerializeField] private AudioSource audioS;
    public GameObject mundo;
    public VideoPlayer video;

    public string muerte = "perdida";
    void Start()
    {
        video.Prepare();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public async Task Grito()
    {
        /*canvas.alpha = 1;*/
        mundo.SetActive(false);
        audioS.Play();
        video.Play();
        await Task.Delay(4000);

        SceneManager.LoadScene(muerte);
    }

}
