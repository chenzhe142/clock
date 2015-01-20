using UnityEngine;
using System.Collections;
using System;

public class ClockAnimator : MonoBehaviour {

	private const float
		hourToDegree = 360f / 12f,
		minuteToDegree = 360f / 60f,
		secondToDegree = 360f / 60f;

	public Transform hour, minute, second;

	public bool analog;

	// Update is called once per frame
	void Update () {
		if (analog) {
			TimeSpan timespan = DateTime.Now.TimeOfDay;
			hour.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalHours * -hourToDegree);
			minute.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalMinutes * -minuteToDegree);
			second.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalSeconds * -secondToDegree);
				
		} else {
			DateTime time = DateTime.Now;
			hour.localRotation = Quaternion.Euler (0f, 0f, time.Hour * -hourToDegree);
			minute.localRotation = Quaternion.Euler (0f, 0f, time.Minute * -minuteToDegree);
			second.localRotation = Quaternion.Euler (0f, 0f, time.Second * -secondToDegree);
		}
	}
}
