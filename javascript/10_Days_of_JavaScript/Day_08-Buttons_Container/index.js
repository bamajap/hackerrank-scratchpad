var buttonContainer = document.createElement('div');
buttonContainer.className = 'buttonContainer';
buttonContainer.id = 'btns';

var buttons = [];
for (let i = 1; i <= 9; i++) {
    var btn = document.createElement('button');
    btn.id = 'btn'+i;
    btn.innerHTML = i;
    buttonContainer.appendChild(btn);
    buttons.push(btn);
}

document.body.appendChild(buttonContainer);

buttons[4].onclick = () => {
    // alert('Pressed button 5');
    let order = [1, 2, 3, 6, 9, 8, 7, 4];

    // "In-Order" Traversal
    // let prev = document.querySelector('#btn4').innerHTML;
    // for (let step = 0; step < order.length; step++) {
    //     let i = order[step];
    //     let currBtn = document.querySelector('#btn'+i);
    //     let curr = currBtn.innerHTML;
    //     currBtn.innerHTML = prev;
    //     // console.log(`btn${i} becomes ${prev}`);
    //     prev = curr;
    // }

    // "Reverse-Order" Traversal
    let firstVal = document.querySelector('#btn4').innerHTML;
    for (let step = order.length-1; step > 0; step--) {
        let c = order[step];
        let p = order[step-1];
        document.querySelector('#btn'+ c).innerHTML = document.querySelector('#btn'+ p).innerHTML;
    }
    document.querySelector('#btn1').innerHTML = firstVal;

    // "Reverse-Order" Traversal #2
    // let firstVal = document.querySelector('#btn4').innerHTML;
    // document.querySelector('#btn4').innerHTML = document.querySelector('#btn7').innerHTML;
    // document.querySelector('#btn7').innerHTML = document.querySelector('#btn8').innerHTML;
    // document.querySelector('#btn8').innerHTML = document.querySelector('#btn9').innerHTML;
    // document.querySelector('#btn9').innerHTML = document.querySelector('#btn6').innerHTML;
    // document.querySelector('#btn6').innerHTML = document.querySelector('#btn3').innerHTML;
    // document.querySelector('#btn3').innerHTML = document.querySelector('#btn2').innerHTML;
    // document.querySelector('#btn2').innerHTML = document.querySelector('#btn1').innerHTML;
    // document.querySelector('#btn1').innerHTML = firstVal;
};
