
const buttons = document.querySelectorAll('button');

const display = document.querySelector('.display');
display.value ="0";
var check = false;
var check2 = false;
buttons.forEach(function(button) {
  button.addEventListener('click', calculate);
});




function calculate(event) {
  
  const clickedButtonValue = event.target.value;
if(!check2){
 if(check){
  if (clickedButtonValue === '=') {
    
    if (display.value !== '0') {
      
      display.value = eval(display.value);
        check2 = true;
      
    }
    
} 

  else {
    display.value += clickedButtonValue;
  }
}
else{
    display.value = clickedButtonValue;
    check = true;
}
}
else{
    display.value = "0";
    check = false;
    check2= false;
}
  
 
}
function clearDisplay(){
    display.value="0";
}