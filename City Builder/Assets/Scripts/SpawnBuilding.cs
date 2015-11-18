using UnityEngine;

public class SpawnBuilding : MonoBehaviour {

	public Transform inst;
	GameObject build;
	bool building;

	void Update(){
		var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		if(Input.GetMouseButtonDown(0)){
			building = true;
		}

		if(Input.GetMouseButtonUp(0)){
			if(Physics.Raycast(ray, out hit)){
				Instantiate(inst, new Vector3(Mathf.Round(hit.point.x), 0, Mathf.Round(hit.point.z)), Quaternion.identity);
			}
		}

		if(Input.GetMouseButton(0)){
			if(building){
				if(Physics.Raycast (ray, out hit)){
					Destroy (GameObject.Find ("DESTROY ME"));
					build = (GameObject)Instantiate(inst, new Vector3(Mathf.Round(hit.point.x), 0, Mathf.Round(hit.point.z)), Quaternion.identity);
					build.name = "DESTROY ME";
				}
			}
		}

	}

}
