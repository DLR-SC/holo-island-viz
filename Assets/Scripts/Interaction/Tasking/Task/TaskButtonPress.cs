﻿using System.Collections;
using UnityEngine;

namespace HoloIslandVis.Interaction.Tasking.Task
{
    public class TaskButtonPress : DiscreteGestureInteractionTask
    {
        public override IEnumerator Perform(GestureInteractionEventArgs eventArgs)
        {
            Debug.Log("PERFORM INTERACTION: TaskGestureDiscreteTest");
            yield break;
        }
    }
}
