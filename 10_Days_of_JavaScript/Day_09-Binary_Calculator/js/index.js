/** @type {HTMLElement} */
const results = document.querySelector('#res');
/** @type {HTMLElement} */
const btn0 = document.querySelector('#btn0');
/** @type {HTMLElement} */
const btn1 = document.querySelector('#btn1');
/** @type {HTMLElement} */
const btnClr = document.querySelector('#btnClr');
/** @type {HTMLElement} */
const btnSum = document.querySelector('#btnSum');
/** @type {HTMLElement} */
const btnSub = document.querySelector('#btnSub');
/** @type {HTMLElement} */
const btnMul = document.querySelector('#btnMul');
/** @type {HTMLElement} */
const btnDiv = document.querySelector('#btnDiv');
/** @type {HTMLElement} */
const btnEql = document.querySelector('#btnEql');

let addButtonTextToResults = (e) => {
    // let test = ev.currentTarget.id;
    // console.log(test);
    results.innerHTML += e.currentTarget.innerHTML;
};

btnClr.onclick = () => {
    results.innerHTML = '';
};

btn0.onclick = addButtonTextToResults;
btn1.onclick = addButtonTextToResults;
btnSum.onclick = addButtonTextToResults;
btnSub.onclick = addButtonTextToResults;
btnMul.onclick = addButtonTextToResults;
btnDiv.onclick = addButtonTextToResults;

btnEql.onclick = () => {
    let operand1, operator, operand2;
    let ops = results.innerHTML.match(/([01]+)([+*/-])([01]+)/);
    ops.shift();
    // console.log(ops);
    [operand1, operator, operand2] = [...ops];

    if (operator === '/') {
        results.innerHTML = Math.floor(operand1 / operand2);
    } else {
        let result = eval(`${parseInt(operand1, 2)} ${operator} ${parseInt(operand2, 2)}`);
        results.innerHTML = result.toString(2);
    }
};