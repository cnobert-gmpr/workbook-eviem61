using Codice.Client.BaseCommands;
using UnityEngine;

namespace GMPR2512Lesson04Scripting01
{
    public class DeathZone : MonoBehaviour
    {

        [SerializeField] private int _year = 1000;
        private float _seconds = 0f;

        void Awake()
        {
            _year += 1026;
            Debug.Log($"I'm awake! It's the year {_year}.");
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log($"Let's get started! It's finally the year {_year}.");
        }

        // Update is called once per frame
        void Update()
        {
            _seconds += Time.deltaTime;
        }

        void OnTriggerEnter2D(Collider2D collider)
        {
            Debug.Log("An object has entered the death zone!");

            Destroy(collider.gameObject.GetComponent<Rigidbody2D>());

        }
    }
}
