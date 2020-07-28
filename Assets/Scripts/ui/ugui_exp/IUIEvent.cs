﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine.UI
{
    public class IUIEvent :MonoBehaviour
    {
        public Action<MonoBehaviour> EventOnClick;
        public Action<MyDragData> EventOnDrag;


        void OnClickEvent(MonoBehaviour behaviour) { EventOnClick?.Invoke(behaviour); }
        void OnDragEvent(MyDragData  myDragData) { EventOnDrag?.Invoke(myDragData); }

    }
}