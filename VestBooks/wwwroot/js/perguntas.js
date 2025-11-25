function checkAnswer(element) {
  const options = document.querySelectorAll('.quiz-option');

  // bloquear cliques após resposta
  options.forEach(opt => opt.style.pointerEvents = 'none');

  // verifica se a clicada é correta (minúsculo)
  const isCorrect = element.dataset.correct === "true";

  if (isCorrect) {
      element.classList.add('correct');
      return;
  }

  // marca a clicada como errada
  element.classList.add('incorrect');

  // encontra a alternativa correta
  const correctOption = Array.from(options)
      .find(opt => opt.dataset.correct === "true");

  if (correctOption)
      correctOption.classList.add('correct');
}


function changeVideo(videoId) {
  const iframe = document.getElementById("mainVideo");
  iframe.src = `https://www.youtube.com/embed/${videoId}?autoplay=1`;
}