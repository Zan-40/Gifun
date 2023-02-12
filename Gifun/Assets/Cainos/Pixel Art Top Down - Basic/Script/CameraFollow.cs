using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    //let camera follow target
    public class CameraFollow : MonoBehaviour
    {
        public Transform target; //Player position
        public float lerpSpeed = 1.0f; //Camera speed

        private Vector3 offset;

        private Vector3 targetPos;

        private void Start()
        {
            if (target == null) return; //If target hasn't been asigned returns (this avoids console errors)

            offset = transform.position - target.position;
        }

        private void Update()
        {
            if (target == null) return; //If target hasn't been asigned returns (this avoids console errors)

            targetPos = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPos, lerpSpeed * Time.deltaTime);
        }

    }
}
