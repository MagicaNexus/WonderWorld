//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using Valve.VR.InteractionSystem;

namespace Valve.VR.InteractionSystem.Sample
{
    public class TargetScript : MonoBehaviour
    {
        public float distance;
        public Vector3 actualPosition;
        public Vector3 nextPosition;
        public Vector3 yPosition;

        public void set10m()
        {
            GameObject.Find("Target").transform.position = new Vector3(121f, 1.7f, -3f);
        }

        public void set15m()
        {
            GameObject.Find("Target").transform.position = new Vector3(126f, 1.7f, -3f);
        }

        public void set20m()
        {
            GameObject.Find("Target").transform.position = new Vector3(131f, 1.7f, -3f);
        }

        public void set30m()
        {
            GameObject.Find("Target").transform.position = Vector3.MoveTowards(transform.position, new Vector3(141f, 1.7f, -3f), Time.deltaTime * 2);
        }

        public void set50m()
        {
            GameObject.Find("Target").transform.position = new Vector3(151f, 1.7f, -3f);
        }

        public void petiteTaille()
        {
            GameObject.Find("Target").transform.localScale = new Vector3(50f, 50f, 50f);
        }

        public void normaleTaille()
        {
            GameObject.Find("Target").transform.localScale = new Vector3(100f, 100f, 100f);
            //GameObject.Find("Target").transform.position.x = 
        }

        public void grandeTaille()
        {
            GameObject.Find("Target").transform.localScale = new Vector3(200f, 200f, 200f);
        }
    }
}