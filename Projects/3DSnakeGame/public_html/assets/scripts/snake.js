
function animate() {
				
	tail = tabCube.pop();
	tail.position.x = tabCube[0].position.x;
	tail.position.y = tabCube[0].position.y;
	tail.position.z = tabCube[0].position.z;
	
	if(direction[0] == 1) {
		if(tabCube[0].position.x == (largeur*9)) {
			tail.position.x = -(largeur*10);
		} else {
			tail.position.x += largeur;
		}
	}
	if(direction[1] == 1) {
		if(tabCube[0].position.y == (largeur*9)) {
			tail.position.y = -(largeur*10);
		} else {
			tail.position.y += largeur;
		}
	}
	if(direction[2] == 1) {
		if(tabCube[0].position.z == (largeur*9)) {
			tail.position.z = -(largeur*10);
		} else {
			tail.position.z += largeur;
		}
	}
	
	if(direction[0] == -1) {
		if(tabCube[0].position.x == -(largeur*10)) {
			tail.position.x = (largeur*9);
		} else {
			tail.position.x -= largeur;
		}
	}
	if(direction[1] == -1) {
		if(tabCube[0].position.y == -(largeur*10)) {
			tail.position.y = (largeur*9);
		} else {
			tail.position.y -= largeur;
		}
	}
	if(direction[2] == -1) {	
		if(tabCube[0].position.z == -(largeur*10)) {
			tail.position.z = (largeur*9);
		} else {
			tail.position.z -= largeur;
		}
	}
	tabCube.unshift(tail);

	if(snakeConfondBonbon()) {	
		ajoutCubeEnQueue(tail);
		positionAleatoireBonbon();
		document.getElementById("score").innerHTML++;
		
	} else if(teteConfondSnake(tail)) {
		if(confirm("Partie terminée! Recommencer?")) {
			location.reload(); 
		} else {
			clearInterval(timer);
		}
	}
	
	renderer.render(scene, camera);	
}

function allouerDirection(e) {
	/**
	* KEYCODE
	*
	* gauche	37
	* haut 		38
	* droite	39
	* bas		40
	* W             87
	* Z             90
	**/

	if(e.keyCode == 37) {
		if(direction[0] != 1) {
			direction = new Array(0,0,0);
			direction[0] = -1;
		}
	}
	if(e.keyCode == 38) {
		if(direction[1] != -1) {			
			direction = new Array(0,0,0);
			direction[1] = 1;
		}
	}
	if(e.keyCode == 39) {
		if(direction[0] != -1) {
			direction = new Array(0,0,0);
			direction[0] = 1;
		}
	}
	if(e.keyCode == 40) {
		if(direction[1] != 1) {
			direction = new Array(0,0,0);
			direction[1] = -1;
		}
	}
	if(e.keyCode == 87) {
		if(direction[2] != -1) {
			direction = new Array(0,0,0);
			direction[2] = 1;
		}
	}
	if(e.keyCode == 90) {
		if(direction[2] != 1) {
			direction = new Array(0,0,0);
			direction[2] = -1;
		}
	}
}

function snakeConfondBonbon() {
	if(tail.position.x == bonbon.position.x && tail.position.y == bonbon.position.y && tail.position.z == bonbon.position.z) {	
		return true;
	} else {
		return false;
	}
}

function teteConfondSnake(head) {
	for(i = 1; i < tabCube.length; i++) {
		if(head.position.x == tabCube[i].position.x && head.position.y == tabCube[i].position.y && head.position.z == tabCube[i].position.z) {
			return true;
		}
	}
	return false;
}

function ajoutCubeEnQueue(tail) {
	var l = tabCube.length;
	tabCube.push(new THREE.Mesh(new THREE.CubeGeometry(largeur, largeur, largeur), new THREE.MeshNormalMaterial({color: 0x0000ff, wireframe: false})) );
	tabCube[l].position.x = tail.position.x;
	tabCube[l].position.y = tail.position.y;
	tabCube[l].position.z = tail.position.z;
	scene.add(tabCube[l]);
}
	
function aleatoire() {

	var pos;
	
	if(Math.random() > 0.5) {
		pos = Math.floor(Math.random()*10)*largeur;
	} else {
		pos = -Math.ceil(Math.random()*10)*largeur;
	}
					
	return pos;
}

function positionAleatoireBonbon() {
	var posX = aleatoire();
	var posY = aleatoire();
	var posZ = aleatoire();
					
	for(i = 0; i < tabCube.length; i++) {
		if(posX == tabCube[i].position.x && posY == tabCube[i].position.y && posZ == tabCube[i].position.z) {
			positionAleatoireBonbon();
		}
	}
			
	bonbon.position.x = posX;
	bonbon.position.y = posY;
	bonbon.position.z = posZ;
}			
			