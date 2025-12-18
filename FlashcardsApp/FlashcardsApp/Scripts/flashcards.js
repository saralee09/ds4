let cards = [];
let index = 0;
let score = 0;

fetch(`/api/flashcards/adaptive/${languageId}/1`)
    .then(res => res.json())
    .then(data => {
        cards = data;
        showFlashcard(cards[index]);
    });


function showFlashcard(card) {
    document.getElementById("word").innerText = card.word;
}

function answer(isCorrect) {
    if (isCorrect) score += 10;

    index++;
    if (index < cards.length) {
        showFlashcard(cards[index]);
    } else {
        finish();
    }
}

function finish() {
    const userId = 1;

    fetch('/api/sessions', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
            userId: userId,
            score: score
        })
    })
        .then(() => {
            window.location.href = `/Study/Result?score=${score}`;
        });
}
