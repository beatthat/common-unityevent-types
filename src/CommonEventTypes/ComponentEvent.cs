using System;
using UnityEngine.Events;
using UnityEngine;

namespace BeatThat
{
	[Serializable]public class ComponentEvent : UnityEvent<Component> { }
}