using UnityEngine;
using System.Collections;

public class CameraPathSpline : MonoBehaviour {
	
	public Transform[] trans;
	
	LTSpline cr;
	public GameObject avatar1;
	
	void OnEnable(){
		// create the path
		cr = new LTSpline( new Vector3[] {trans[0].position, trans[0].position, trans[1].position, trans[1].position, trans[1].position} );
		//cr = new LTSpline (new Vector3[] {new Vector3 (1f, 4f, -53f), new Vector3 (1f, 4f, -300f), new Vector3 (1f, 4f, -300f), new Vector3 (1f, 4f, -300f)} );
		//cr = new LTSpline( new Vector3[] {new Vector3(1f, 4f, -53f), new Vector3(1f, 4f, -53f), new Vector3(1f, 4f, -300f), new Vector3(1f, 4f, -300f), new Vector3(1f, 4f, -300f)} );
	}
	
	void Start () {
		//avatar1 = GameObject.Find("MainCam");
		//cr = new LTSpline (new Vector3[] {trans [0].position, trans [1].position});
		// Tween automatically
		LeanTween.moveSpline(avatar1, cr.pts, 6.5f).setOrientToPath(true).setRepeat(-1).setDirection(-1f);
	}
	
	private float iter;
	void Update () {
		// Or Update Manually
		// cr.place( avatar1.transform, iter );
		
		iter += Time.deltaTime*0.07f;
		if(iter>1.0f)
			iter = 0.0f;
	}
	
	void OnDrawGizmos(){
		// Debug.Log("drwaing");
		if(cr!=null)
			OnEnable();
		Gizmos.color = Color.red;
		if(cr!=null)
			cr.gizmoDraw(); // To Visualize the path, use this method
	}
}
