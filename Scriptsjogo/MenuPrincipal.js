#pragma strict
var Animador:Animator;

function Start(){
	Animador=GetComponent(Animator);
}

function Iniciar () {
	Application.LoadLevel(1);
}

function Creditos () {
	Application.LoadLevel(3);
}
function Sair () {
	Application.Quit();
}