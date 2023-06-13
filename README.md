<h1> Nome dos integrantes: Danilo Garcia e Isabele Timotio </h1>
<h2> Atividade jogo com raycast - 2° bimestre </h2>
<br>

<h2> Objetivo: em nosso game a nossa idela central era criar uma simulação de paintball. Nele encrementamos os conceitos
de raycast e iluminação sendo como bases principais para o desenvolvimento do jogo.  </h2>
<br>

<h2> Principais códigos utilizados e sua explicação: </h2>
<ul>
  <li>
    <strong> Script da arma:</strong> Permite que o jogador dispare um raio laser que interage com o ambiente do jogo,
    criando um efeito visual de laser e um splash de tinta aparece onde o raio atinge um objeto. </h3>
     <br>
     <strong> As partes principais do código são: </strong>
    LineRenderer laserline: É uma referência ao componente LineRenderer anexado ao objeto. É usado para desenhar o raio laser no jogo.
    <br>
    FireTimer é usado para controlar o tempo entre cada disparo.
    <br>
    Raycast a partir da posição de origem e direção do raio lançado pela câmera do jogador. Se o raio atingir um objeto dentro do alcance
    definido, o LineRenderer é atualizado para mostrar o ponto de colisão, uma bala é instanciada nesse ponto e um efeito visual é iniciado. 
    Caso contrário, o LineRenderer é atualizado para mostrar o ponto máximo de alcance do raio.
    // imagem
    </li>
    <li>
     <strong> Script da câmera: 
    
  
