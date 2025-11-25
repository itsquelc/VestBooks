// Page Scroll
window.addEventListener("scroll", function () {
  const navbar = document.querySelector(".navbar");

  if (window.scrollY > 500) {
    navbar.classList.add("scrolled");
  } else {
    navbar.classList.remove("scrolled");
  }
});



// Função para o Scroll dos livros
const containerLivro = document.getElementById("livros");

if (containerLivro != null) {
  let scrollIntervalLivros; // Controlador para o intervalo de scroll
  let scrollDirectionLivros = 0; // Direção do scroll (0 = parado, 1 = direita, -1 = esquerda)

  containerLivro.addEventListener("mousemove", (e) => {
    const boundingRect = containerLivro.getBoundingClientRect();
    const mouseX = e.clientX;

    const threshold = 200; // Distância das bordas para ativar o scroll

    if (mouseX < boundingRect.left + threshold) {
      scrollDirectionLivros = -1; // Scroll para a esquerda
      containerLivro.style.cursor = "url('/img/arrow-left.png'), auto"; // Cursor para a esquerda
    } else if (mouseX > boundingRect.right - threshold) {
      scrollDirectionLivros = 1; // Scroll para a direita
      containerLivro.style.cursor = "url('/img/arrow-right.png'), auto"; // Cursor para a direita
    } else {
      scrollDirectionLivros = 0; // Parar scroll
      containerLivro.style.cursor = "pointer"; // Cursor padrão
    }
  });

  containerLivro.addEventListener("mouseleave", () => {
    scrollDirectionLivros = 0; // Parar scroll quando o mouse sai do elemento
    containerLivro.style.cursor = "default"; // Resetar cursor
  });

  // Função para scroll contínuo
  function autoScrollLivros() {
    if (scrollDirectionLivros !== 0) {
      containerLivro.scrollLeft += scrollDirectionLivros * 6; // Ajuste a velocidade (5 = rápido)
    }
  }

  scrollIntervalLivros = setInterval(autoScrollLivros, 16); // ~60 FPS
}

const containerAutor = document.getElementById("autor");
if (containerAutor != null) {

  let scrollIntervalAutores; // Controlador para o intervalo de scroll
  let scrollDirectionAutores = 0; // Direção do scroll (0 = parado, 1 = direita, -1 = esquerda)

  containerAutor.addEventListener("mousemove", (e) => {
    const boundingRect = containerAutor.getBoundingClientRect();
    const mouseX = e.clientX;

    const threshold = 200; // Distância das bordas para ativar o scroll

    if (mouseX < boundingRect.left + threshold) {
      scrollDirectionAutores = -1; // Scroll para a esquerda
      containerAutor.style.cursor = "url('/img/arrow-left.png'), auto"; // Cursor para a esquerda
    } else if (mouseX > boundingRect.right - threshold) {
      scrollDirectionAutores = 1; // Scroll para a direita
      containerAutor.style.cursor = "url('/img/arrow-right.png'), auto"; // Cursor para a direita
    } else {
      scrollDirectionAutores = 0; // Parar scroll
      containerAutor.style.cursor = "pointer"; // Cursor padrão
    }
  });

  containerLivro.addEventListener("mouseleave", () => {
    scrollDirectionAutores = 0; // Parar scroll quando o mouse sai do elemento
    containerAutor.style.cursor = "default"; // Resetar cursor
  });

  // Função para scroll contínuo
  function autoScrollAutores() {
    if (scrollDirectionAutores !== 0) {
      containerAutor.scrollLeft += scrollDirectionAutores * 6; // Ajuste a velocidade (5 = rápido)
    }
  }

  scrollIntervalAutores = setInterval(autoScrollAutores, 16); // ~60 FPS
}

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

