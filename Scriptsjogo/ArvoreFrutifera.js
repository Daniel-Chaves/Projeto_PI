#pragma strict
var raio:float;
var tempo:float;
var margemErro:float;
var fruta:GameObject;
private var intervalo:float;
function Update () {
	intervalo+=Time.deltaTime;
	if(intervalo>=(tempo+Random.Range(0.0,margemErro))){
		intervalo=0;
		Instantiate(fruta, (transform.position+Vector3(Random.Range(raio*-1,raio),Random.Range(raio*-1,raio),Random.Range(raio*-1,raio))), transform.rotation);
	}
}