using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public enum TYPE
    {
        NONE = 0,
        DEFAULT = 1,
        PLAYER = 2,
        ENEMY = 3,
    }

    public class Interaction : MonoBehaviour
    {
        public TYPE type;
        public GameObject RefObject;
        public bool IsObjectNear = false;
        public bool IsInteracting = false;
        public float DetectionArea = 1.5f;
        public float InteractionArea = 1.5f;
        public Vector3 DetectionOffset;

        void FixedUpdate()
        {
            IsObjectNearToObject();
            if (IsObjectInteractingWithObject() && RefObject.GetComponent<Interaction>().type == TYPE.ENEMY)
            {
                Debug.Log("Atacking Enemy");
            }
        }

        public bool IsObjectNearToObject()
        {
            if (Vector3.Distance(RefObject.transform.position, transform.position) <= DetectionArea)
            {
                IsInteracting = true;
                return true;
            }
            IsInteracting = false;
            return false;
        }

        public bool IsObjectInteractingWithObject()
        {
            if (Vector3.Distance(RefObject.transform.position, transform.position) <= InteractionArea)
            {
                IsInteracting = true;
                return true;
            }
            IsInteracting = false;
            return false;
        }
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(transform.position + DetectionOffset, DetectionArea);
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position + DetectionOffset, InteractionArea);
        }
    }
}