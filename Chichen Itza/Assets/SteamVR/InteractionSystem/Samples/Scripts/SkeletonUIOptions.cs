//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using Valve.VR.InteractionSystem;

namespace Valve.VR.InteractionSystem.Sample
{
    public class SkeletonUIOptions : MonoBehaviour
    {
        public float distance;
        public Vector3 actualPosition;
        public Vector3 nextPosition;
        public Vector3 yPosition;

        public void AnimateHandWithController()
        {
            for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
            {
                Hand hand = Player.instance.hands[handIndex];
                if (hand != null)
                {
                    hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithController);
                }
            }
        }

        public void AnimateHandWithoutController()
        {
            for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
            {
                Hand hand = Player.instance.hands[handIndex];
                if (hand != null)
                {
                    hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithoutController);
                }
            }
        }

        

        public void SetRenderModel(RenderModelHolder prefabs)
        {
            for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
            {
                Hand hand = Player.instance.hands[handIndex];
                if (hand != null)
                {
                    if (hand.handType == SteamVR_Input_Sources.RightHand)
                        hand.SetRenderModel(prefabs.rightPrefab);
                    if (hand.handType == SteamVR_Input_Sources.LeftHand)
                        hand.SetRenderModel(prefabs.leftPrefab);
                }
            }
        }

        public void set10m()
        {
            GameObject.Find("Target").transform.position = new Vector3(121f, GameObject.Find("Target").transform.position.y, -3f);
            GameObject.Find("Target").transform.localScale = new Vector3(GameObject.Find("Target").transform.localScale.x, GameObject.Find("Target").transform.localScale.y, GameObject.Find("Target").transform.localScale.z);

        }

        public void set15m()
        {
            GameObject.Find("Target").transform.position = new Vector3(126f, GameObject.Find("Target").transform.position.y, -3f);
            GameObject.Find("Target").transform.localScale = new Vector3(GameObject.Find("Target").transform.localScale.x, GameObject.Find("Target").transform.localScale.y, GameObject.Find("Target").transform.localScale.z);

        }

        public void set20m()
        {
            GameObject.Find("Target").transform.position = new Vector3(131f, GameObject.Find("Target").transform.position.y, -3f);
            GameObject.Find("Target").transform.localScale = new Vector3(GameObject.Find("Target").transform.localScale.x, GameObject.Find("Target").transform.localScale.y, GameObject.Find("Target").transform.localScale.z);

        }

        public void set30m()
        {
            GameObject.Find("Target").transform.position = new Vector3(141f, GameObject.Find("Target").transform.position.y, -3f);
            GameObject.Find("Target").transform.localScale = new Vector3(GameObject.Find("Target").transform.localScale.x, GameObject.Find("Target").transform.localScale.y, GameObject.Find("Target").transform.localScale.z);

        }

        public void set50m()
        {
            GameObject.Find("Target").transform.position = new Vector3(151f, GameObject.Find("Target").transform.position.y, -3f);
            GameObject.Find("Target").transform.localScale = new Vector3(GameObject.Find("Target").transform.localScale.x, GameObject.Find("Target").transform.localScale.y, GameObject.Find("Target").transform.localScale.z);
        }

        public void petiteTaille()
        {
            GameObject.Find("Target").transform.localScale = new Vector3(50f, 50f, 50f);
            GameObject.Find("Target").transform.position = new Vector3(GameObject.Find("Target").transform.position.x, 0.83f, GameObject.Find("Target").transform.position.z);
        }

        public void normaleTaille()
        {
            GameObject.Find("Target").transform.localScale = new Vector3(100f, 100f, 100f);
            GameObject.Find("Target").transform.position = new Vector3(GameObject.Find("Target").transform.position.x, 1.69f, GameObject.Find("Target").transform.position.z);
        }

        public void grandeTaille()
        {
            GameObject.Find("Target").transform.localScale = new Vector3(200f, 200f, 200f);
            GameObject.Find("Target").transform.position = new Vector3(GameObject.Find("Target").transform.position.x, 3.4f, GameObject.Find("Target").transform.position.z);
        }
    }
}