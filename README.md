<h1> Nome dos integrantes: Danilo Garcia e Isabele Timotio </h1>
<h2> Atividade jogo com raycast e iluminação - 2° bimestre - 3°JD </h2>
<br>

<h2> Objetivo: em nosso game a nossa ideia central era criar uma simulação de paintball. Nele encrementamos os conceitos
de raycast e iluminação sendo como bases principais para o desenvolvimento do jogo.  </h2>
<br>

<h2> Principais códigos utilizados e a explicação de ambos: </h2>
<ul>
  <li>
    <strong> Script da arma:</strong> Permite que o jogador dispare um raio laser que interage com o ambiente do jogo,
    criando um efeito visual de laser e um splash de tinta aparece onde o raio atinge um objeto. 
     <br>
     <strong> As partes principais do código são: </strong>
    <br>
    <strong> [RequireComponent(typeof(LineRenderer))]: </strong> Garante que o objeto tenha um componente LineRenderer anexado. Se o componente não estiver presente, ele será adicionado automaticamente.
    <br>
    <strong> Public GameObject bullet;: </strong> É uma referência ao prefab da bala que será instanciada quando o raio laser atingir um objeto.
    <br>
    <strong> Public Camera playercamera;: </strong> É uma referência à câmera do jogador.
    <br>
    <strong> Public Transform origemtiro;: </strong> É a posição de origem do raio laser.
    <br>
    <strong> Public float gunrange = 50f;: </strong> É a distância máxima que o raio laser pode percorrer.
    <br>
    <strong> Public float firerate = 0.2f;: </strong> É o tempo mínimo entre cada disparo.
    <br>
    <strong> Public float laserduration = 0.05f;: </strong> É a duração do raio laser visual.
    <br>
    <strong> LineRenderer laserline;: </strong> É uma referência ao componente <strong> LineRenderer </strong> anexado ao objeto. É usado para desenhar o raio laser no jogo.
    <br>
    <strong> Float FireTimer;: </strong> É uma variável que controla o tempo desde o último disparo.
    <br>
    No método <strong> Awake() </strong>, é obtida uma referência ao componente <strong> LineRenderer </strong> anexado ao objeto.
    <br>
    No método <strong> Update() </strong> , o tempo desde o último disparo é incrementado com <strong> Time.deltaTime </strong>.
    <br>
    Em seguida, é verificado se o botão de disparo <strong> (Fire1) </strong> foi pressionado e se o tempo desde o último disparo é maior que o tempo mínimo entre disparos <strong> (firerate) </strong>.
    <br>
    Se a condição acima for verdadeira, o tempo desde o último disparo é resetado <strong> (FireTimer = 0) </strong> e a posição inicial do raio laser é definida como a posição de origem <strong> (origemtiro.position) </strong>
    <br>
    É feito um <strong> Raycast </strong> a partir da posição de origem e direção do raio lançado pela câmera do jogador. Se o raio atingir um objeto dentro do alcance definido <strong> (gunrange) </strong>, 
    o <strong> LineRenderer </strong> é atualizado para mostrar o ponto de colisão, um splash de tinta é instanciada nesse ponto e um efeito visual é iniciado. Caso contrário, o <strong> LineRenderer </strong>  é atualizado para mostrar 
    o ponto máximo de alcance do raio.
    <br>
    As corrotinas <strong> ShootLaser() </strong> e <strong> ApagarTinta() </strong> são chamadas usando <strong> StartCoroutine() </strong> para controlar o tempo de duração dos efeitos visuais do raio laser e da tinta.
    <br>
    A corrotina <strong> ShootLaser() </strong> ativa o componente <strong> LineRenderer </strong> para tornar o raio laser visível por um tempo <strong> (laserduration) </strong> e, em seguida, o desativa novamente.
    <br>
    A corrotina <strong> ApagarTinta() </strong> espera por um período de tempo especificado <strong> (10f) </strong> e, em seguida, desativa o objeto da tinta.
   <br>
    <br> 
    <strong> Imagens do jogo com os script explicados: </strong>
    <br>
    ![image](https://github.com/Isabele-Timotio/DaniloIsabele/assets/101645908/3cb2a1ad-b2ab-42d4-9406-61d7e375ee32) //raycast
    <br>
    ![image](https://github.com/Isabele-Timotio/DaniloIsabele/assets/101645908/0ade107b-f3e5-49f6-b6cb-3703ac0e2013) //raycast - depois que passa o tempo desaparece a tinta
    <br>
    ![image](https://github.com/Isabele-Timotio/DaniloIsabele/assets/101645908/f96aa9e7-c665-4e8c-aad0-e51d870bc4b4)

  </li> </ul> 
    <br>
    <br> 
    <ul> <li>
     <strong> Script da câmera: </strong> Este código permite que a câmera no jogo seja controlada pelo movimento do mouse, proporcionando 
     uma experiência mais imersiva ao jogador.
     <br>
     <strong> As partes principais do código são: </strong> 
     <br>
     <strong> Public bool travarMouse = true;: </strong> Essa variável booleana controla se o cursor do mouse será exibido ou não.
       <br>
     <strong> Public float sensibilidade = 2.0f;: </strong> Essa variável define a sensibilidade do movimento do mouse.
       <br>
     <strong> Public float mouseX = 0.0f, mouseY = 0.0f;: </strong> Essas variáveis armazenam as <strong> rotações do mouse </strong> nos <strong> eixos X e Y </strong>.
       <br>
     No método <strong> Start() </strong>, caso a variável <strong> travarMouse </strong> seja definida como <strong> true </strong>, o cursor do mouse é ocultado e travado no centro da tela.
       <br>
     No método <strong> Update() </strong>, o movimento do mouse é capturado usando <strong> Input.GetAxis("Mouse X") </strong> para obter o movimento horizontal do mouse e 
     <strong> Input.GetAxis("Mouse Y") </strong> para obter o movimento vertical do mouse. Esses valores são então multiplicados pela sensibilidade definida.
       <br>
     Em seguida, as variáveis <strong> mouseX </strong> e <strong> mouseY </strong> são atualizadas de acordo com o movimento do mouse.
       <br>
     Por fim, <strong> transform.eulerAngles </strong> é usado para rotacionar a câmera de acordo com os <strong> valores </strong> atualizados de <strong> mouseX </strong> e <strong> mouseY </strong>, permitindo 
     que a câmera siga o movimento do mouse.
  <br>
  <br>
    <strong> Imagens do jogo com os script explicados: </strong>
  <br>
  ![image](https://github.com/Isabele-Timotio/DaniloIsabele/assets/101645908/a5ff9cb4-893f-4098-8720-86ff06839d1d)
  ![image](https://github.com/Isabele-Timotio/DaniloIsabele/assets/101645908/2db19d61-ba56-4596-bf1b-6c8fc36f735e)

  </li> </ul>
  <br>
  <h3> Sobre a iluminação </h3>
  <br>
  Na iluminação utilizamos o pointlights no carro para ser os farol (curiosidade: a luz do farol da esquerda é maior que a da direita, assim como é na vida real). 
  Imagem demonstrando isto: ![image](https://github.com/Isabele-Timotio/DaniloIsabele/assets/101645908/2bad2ce9-a909-4fc4-8a2d-b1085fe10982)
  <br>
  E Temos também o directional light do sol para iluminação total do jogo. Imagem que demonstra isso: 
  <br>
  ![image](https://github.com/Isabele-Timotio/DaniloIsabele/assets/101645908/f7c95e3c-600f-4f27-8679-445151ba916d)
<br>
![image](https://github.com/Isabele-Timotio/DaniloIsabele/assets/101645908/6ca82843-53ed-495f-9645-a3461ef0d5dd)

<h1> Contudo concluímos nosso jogo! Espero que gostem bastante e se quiserem reproduzir estão livres desde que deem os devidos crétidos</h1>
  

