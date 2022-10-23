using UnityEngine;
using UnityEngine.SceneManagement;

namespace RPG.SceneManagement
{
    public class Portal : MonoBehaviour
    {
        [SerializeField] int sceneToLoad = -1;

        private void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Player")
            {
                print("Portal Triggred");
                SceneManager.LoadScene(1);
            }
        }
    }
}
