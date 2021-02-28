let createButton = document.getElementById('create-button');
let createForm = document.getElementById('create-form');
let isCreateFormDisplayling = false;

let updateButton = document.getElementById('update-button');
let updateForm = document.getElementById('update-form');
let isUpdateFormDisplaying = false;

let deleteButton = document.getElementById('delete-button');
let deleteForm = document.getElementById('delete-form');
let isDeleteFormDisplaying = false;

createButton.onclick = function(){
	
	if(isCreateFormDisplayling == false){
		createForm.style.display = 'block';
		isCreateFormDisplayling = true;
	}
	else{
		createForm.style.display = 'none';
		isCreateFormDisplayling = false;
	}
}

updateButton.onclick = function(){
	
	if(isUpdateFormDisplaying == false){
		updateForm.style.display = 'block';
		isUpdateFormDisplaying = true;
	}
	else{
		updateForm.style.display = 'none';
		isUpdateFormDisplaying = false;
	}
}

deleteButton.onclick = function(){
	
	if(isDeleteFormDisplaying == false){
		deleteForm.style.display = 'block';
		isDeleteFormDisplaying = true;
	}
	else{
		deleteForm.style.display = 'none';
		isDeleteFormDisplaying = false;
	}
}