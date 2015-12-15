using UnityEngine;
using System.Collections.Generic;

public class ForeachInUnity : MonoBehaviour {

	Dictionary<int, int> _testDict = new Dictionary<int, int>();
	const string s_label = "_InUnity";

	void Start()
	{
		for (int i = 0; i < 100; i++)
		{
			_testDict.Add(i, i * i);
		}
	}

	int _placeHolderRes = 0;
	public void TestWithForeach()
	{
		_placeHolderRes = 0;
		Profiler.BeginSample ("ForeachCompiled" + s_label);
		foreach (var t in _testDict) {
			_placeHolderRes = t.Value;
		}
		Profiler.EndSample ();
	}

	public void TestWithWhile()
	{
		_placeHolderRes = 0;
		Profiler.BeginSample ("WhileCompiled" + s_label);
		var e = _testDict.GetEnumerator ();
		while (e.MoveNext ()) {
			_placeHolderRes = e.Current.Value;
		}
		Profiler.EndSample ();
	}

	public void Update()
	{
		TestWithForeach ();
		TestWithWhile ();
	}
}
