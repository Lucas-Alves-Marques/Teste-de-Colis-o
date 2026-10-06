# 🚗 Projeto de estudo em C# 

Aplicação Windows Forms desenvolvida como estudo da linguagem C# e da lógica de programação visual em ambiente desktop. O projeto foi criado durante as aulas de programação na Etec de Embu como base para aprender conceitos como formulários, eventos, imagens,Timers e colisão entre objetos na interface.

O objetivo principal foi praticar a criação de interfaces gráficas, manipulação de componentes visuais e uso de eventos do Windows Forms. Esse mesmo tipo de base foi depois aproveitado para desenvolver o Jogo do Heroi em C#.

## 📚 Sobre o projeto 

Este projeto foi criado para entender como funciona o desenvolvimento em C# com WinForms, uma tecnologia do .NET Framework para construção de aplicações desktop com interface gráfica. Durante as aulas, a ideia foi testar como os controles visuais podem ser movidos, posicionados e interagirem com o usuário.

A aplicação simula uma cena simples de rua com um carro em movimento e uma árvore como obstáculo. Quando o carro encosta no objeto, a colisão é detectada e a ação é interrompida com uma mensagem no usuário.

Esse tipo de projeto é importante para aprender:

- criação de formulários (`Form`);
- uso de componentes visuais (`PictureBox`, `Button`, `Timer`);
- posicionamento de objetos via propriedades `Left`, `Top`, `Size` e `Location`;
- uso de eventos como `Click` e `Tick`;
- interação com imagens e recursos do projeto;
- detecção de colisão usando `Bounds.IntersectsWith`.

## 🧰 Tecnologias e ambiente 

- **C#** como linguagem principal;
- **.NET Framework 4.0**;
- **Windows Forms** para a interface gráfica;
- **SharpDevelop / Visual Studio** para desenvolvimento e execução da aplicação;
- **System.Windows.Forms** para controles visuais e eventos;
- **System.Drawing** para manipulação de imagens e cores;
- **MSBuild** para compilação do projeto.

## 🗂️ Estrutura do projeto 

A solução contém os seguintes arquivos principais:

```text
Teste-de-Colis-o/
├── Colisão.sln
├── Colisão/
│   ├── Colisão.csproj
│   ├── Program.cs
│   ├── MainForm.cs
│   ├── MainForm.Designer.cs
│   ├── MainForm.resx
│   └── Properties/
│       └── AssemblyInfo.cs
└── README.md
```

### Componentes principais

- **`Colisão.sln`**: arquivo da solução do projeto, que organiza a aplicação dentro do ambiente de desenvolvimento.
- **`Colisão.csproj`**: arquivo de configuração do projeto .NET, com referências às bibliotecas do WinForms e definição da saída executável.
- **`Program.cs`**: ponto de entrada do programa. Esse arquivo chama `Application.Run(new MainForm());`, garantindo que a janela principal seja aberta ao iniciar a aplicação.
- **`MainForm.cs`**: lógica do formulário. É aqui que o carro é posicionado, o botão dispara o movimento e o `Timer` atualiza a cena.
- **`MainForm.Designer.cs`**: código gerado pela IDE para a criação visual dos controles, incluindo o campo de imagem da estrada, o carro, a árvore e o botão "Mover".
- **`MainForm.resx`**: recursos embutidos do formulário, como imagens utilizadas na interface.

## 🔄 Como a aplicação funciona

A lógica principal foi implementada em `MainForm.cs` e segue este fluxo:

1. O formulário é criado com `MainForm()`.
2. A imagem do carro e da árvore são configuradas como filhos da imagem da estrada, para que fiquem sobre a cena.
3. O botão **Mover** chama `Button1Click`.
4. Ao clicar no botão, o carro volta para a posição inicial e o `Timer` é ativado.
5. A cada intervalo do `Timer` (`timer1.Tick`), o carro avança para a direita em 10 pixels.
6. Quando o carro alcança a posição limite, o movimento é parado.
7. Se a área do carro (`Bounds`) intersecta a área da árvore (`Bounds`), a colisão é detectada.
8. O temporizador é parado, a imagem do carro muda para uma versão amassada e uma `MessageBox` mostra a mensagem "O carro bateu".

A detecção de colisão é feita pela comparação das bounding boxes dos componentes:

```csharp
if (picBox_Carro.Bounds.IntersectsWith(picBox_Arvore.Bounds))
```

Esse trecho é o núcleo da lógica do projeto e representa o aprendizado prático de interseção de elementos na tela.

## 🖼️ Componentes visuais da tela

### `PictureBox` da estrada

- `picBox_Estrada` representa a base da cena.
- A imagem de fundo é atribuída e ajustada com `SizeMode.StretchImage`.
- Ele serve como container visual para as imagens do carro e da árvore.

### `PictureBox` do carro

- `picBox_Carro` é o objeto que se move.
- É posicionado no lado esquerdo da estrada com `Left = 0` e `Top = 5`.
- O valor do intervalo do timer é ajustado em 25ms, gerando uma animação simples do movimento.
- Quando ocorre a colisão, a imagem do carro é trocada para uma representação alternativa.

### `PictureBox` da árvore

- `picBox_Arvore` representa o obstáculo.
- É posicionada na parte direita da estrada para que o carro colida ao avançar.
- Também recebe fundo transparente (`BackColor = Color.Transparent`) para que a imagem se misture melhor ao cenário.

### Botão "Mover"

- O botão inicia a movimentação do carro.
- Seu evento `Click` reinicia a posição e ativa o temporizador.

### Timer

- O componente `timer1` controla a repetição do movimento.
- Ele dispara a cada intervalo e chama o método `Timer1Tick`.
- A partir desse evento, o carro muda sua posição horizontal, simulando deslocamento.

## 💻 Requisitos de execução 

Para executar o projeto, são necessários:

- sistema operacional **Windows**;
- **.NET Framework 4.0** ou compatível;
- **Visual Studio** ou **SharpDevelop** instalado;
- acesso ao código e aos recursos de imagem usados no projeto.

Como a aplicação é feita em WinForms, ela funciona melhor em ambiente Windows nativo. Não é um projeto baseado em web, mobile ou em .NET Core moderno.

## 🚀 Como executar o projeto

### Opção 1: com o Visual Studio

1. Abra o arquivo `Colisão.sln`.
2. Aguarde o Visual Studio restaurar as dependências do projeto.
3. Selecione o modo **Debug** ou **Release**.
4. Pressione **F5** para compilar e executar.
5. Clique no botão **Mover** para iniciar o movimento do carro.
6. Observe a colisão com a árvore e a mensagem exibida.

### Opção 2: compilação via linha de comando

Se o ambiente tiver o SDK do .NET Framework e o MSBuild disponível:

```bat
msbuild Colisão.sln
```

Depois, execute o arquivo gerado em `bin\Debug\Colisão.exe` ou `bin\Release\Colisão.exe`.

## 🧭 Fluxo de execução do programa

Ao iniciar:

- `Program.cs` chama o `MainForm`.
- `MainForm` inicializa a interface e os componentes visuais.
- A aplicação fica aguardando a interação do usuário.

Ao pressionar "Mover":

- O carro retorna à posição inicial.
- O timer começa a contagem.
- O carro desloca-se horizontalmente até atingir o limite.

Ao colidir:

- o movimento para,
- a imagem muda,
- a caixa de mensagem aparece.

## 🔎 Observações de estudo

Esse projeto é um excelente exemplo inicial para aprender a lógica de desenvolvimento desktop em C# porque reúne vários conceitos importantes em um exemplo pequeno e visual:

- eventos,
- controle de estado,
- interação com imagens,
- lógica de movimentação,
- condição de colisão,
- uso de `MessageBox` para feedback ao usuário.

Ele também funciona como base para projetos mais complexos, como jogos, simuladores e interfaces com movimento e interação.

## 🧩 Conclusão

O projeto mostra de forma simples e didática como criar uma aplicação Windows Forms em C# com objetos visuais e lógica de colisão. Foi desenvolvido como material de estudo e como base para o futuro jogo do Heroi em C#, que exigiria conceitos ainda mais avançados de animação, lógica de jogo e interação do usuário.
