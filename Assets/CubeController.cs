using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	//キューブの移動速度
	private float speed = -12;

	//消滅位置
	private float deadLine = -10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//キューブを移動させる
		transform.Translate (this.speed* Time.deltaTime,0,0);

		//画面外に出たら破棄する
		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		//接触した相手を判別
		string yourTag = collision.gameObject.tag;

		//地面と接触した場合とキューブ同士が接触した場合に効果音を鳴らす
		if (collision.gameObject.tag == "Ground" | yourTag == "Cube") {
			GetComponent<AudioSource> ().volume = 1;
		} 
	}
}
