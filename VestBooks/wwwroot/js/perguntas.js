function checkAnswer(element) {
  // container da pergunta clicada
  const container = element.closest('.container-pergunta');
  const options = container.querySelectorAll('.quiz-option');
  const feedback = container.querySelector('.feedback-message');

  // bloquear cliques só dessa pergunta
  options.forEach(opt => opt.style.pointerEvents = 'none');

  const isCorrect = element.dataset.correct === "true";

  if (isCorrect) {
    element.classList.add('correct');
    if (feedback) feedback.textContent = 'Resposta correta!';
    return;
  }

  // marca a clicada como errada
  element.classList.add('incorrect');

  // encontra a alternativa correta dentro dessa pergunta
  const correctOption = Array.from(options)
    .find(opt => opt.dataset.correct === "true");

  if (correctOption) correctOption.classList.add('correct');

  if (feedback) feedback.textContent = 'Resposta incorreta.';
}
