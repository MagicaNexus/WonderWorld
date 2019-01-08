using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System;
namespace Valve.VR.InteractionSystem
{
    [RequireComponent(typeof(Interactable))]
    public class selectDistance : MonoBehaviour
    {
        public CustomEvents.UnityEventHand onHandClick;
        private Hand currentHand;
        public float distance;
        public GameObject cible;
        public float damping = 10f;

        private void Update()
        {
            cible.transform.position = Vector3.MoveTowards(cible.transform.position, new Vector3(0f, 1.65f, distance), damping * Time.deltaTime);
        }
        void Awake()
        {
            Button button = GetComponent<Button>();
            if (button)
            {
                button.onClick.AddListener(OnButtonClick);
            }
        }

        void Distance(Hand hand)
        {
            //cible.transform.position = new Vector3(0f, 1.8f, distance);
        }

        private void OnButtonClick()
        {
            onHandClick.Invoke(currentHand);
            cible.transform.position = new Vector3(0f, 1.8f, distance);
        }
    }
}
