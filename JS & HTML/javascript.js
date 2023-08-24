
let score = 0;
let rounds = 0;

document.getElementById("guess").onclick = function(){
    rounds += 1;
    document.getElementById("rounds").innerHTML = "Rounds : " + rounds;
    const guess = document.getElementById("userinput").value;
    let correct;
    correct = Math.ceil((Math.random() *7)) -1;
    if (guess == correct){
        console.log("Correct!");
        document.getElementById("result").innerHTML = "Your guess was correct! The correct number was " + correct + ".";
        score += 1;
        document.getElementById("score").innerHTML = "Score : " + score;
    }
    else {
        console.log("Incorrect!");
        document.getElementById("result").innerHTML = "Your guess was wrong! You guessed " + guess + " but the correct number was " + correct + ".";
    }
}