﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
namespace FlowSystem
{
    [System.Serializable]
    public class ConnectAble
    {
        public string itemName;
        public int nodeId;
        public Vector3 relativePos;
        public Quaternion relativeRot;
    }
}