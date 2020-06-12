# Rouguelike

# Nome dos alunos:
- Leonor Figueiredo: 21902968
- João Pedro: 21906096

Os dois colegas trabalharam no código. Apesar de que a Leonor Figueiredo se ocupou mais do código enquanto, João Pedro ajudava com o diagrama.

# Repositório no Git

https://github.com/Leonor9999Glitched/Rouguelike

# Arquitetura da solução

O programa foi dividido em várias classes, sendo de que algumas dessas classes têm metódos lá dentros para recolher valores de outras zonas do código. Haverá classes que terão mais importância do que outras, ou seja, essas classes terão mais responsabilidades.

O programa começa com a classe Main. É através desta classe o programa irá iniciar as suas acções e terminar, consoante a decisão do jogador. Se o jogador escolher a terceira opção (Sair), o programa terminará com uma mensagem de despedida. Se o jogador escolher ver as regras (Segunda opção), o programa mostrará as regras e depois, regressará ao menu principal. Haverá também uma opcção para os Credits, que irá mostrar os autores do jogo (quem fez o jogo). E também haverá uma opcção para mostrar uma tabela com as melhores pontuações do jogo. O programa chamará a Class Jogo, se o jogador escolher a primeira opcção, dando assim inicio ao jogo.


- A Classe EStat guarda o estado das posições. Basicamente, será a classes que guarda os símbolos para o icone do jogador, boss, minion, saída e lugares que estão bloqueados.


- A Classe Game recebe as informações de todas as outras classes, que decide que classe irá agir, que método chamar para resolver os problemas. Tirando a Classe Main à parte, esta é classe mais importante do programa.


- O Program (Classe Main) é a classe que chama a Classe Game. Também é a classe que vai analisar os argumentos que o utilizador dá, antes de começar


- A Classe Board é responsável pela criação do tabuleiro do jogo. Também é através desta classe que o programa sabe se houve empate no jogo, se há vencedor e se o jogo já acabou.


![Diagrama em UML das Classes do RougueLike](https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/2fb39435-99ff-49ad-9246-42032eeea416/ddz99u4-09c88547-8aec-4085-8524-4c9e55e26e2c.png/v1/fill/w_1201,h_652,q_80,strp/roguelike_by_glitchydemonfairy_ddz99u4-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOiIsImlzcyI6InVybjphcHA6Iiwib2JqIjpbW3siaGVpZ2h0IjoiPD02NTIiLCJwYXRoIjoiXC9mXC8yZmIzOTQzNS05OWZmLTQ5YWQtOTI0Ni00MjAzMmVlZWE0MTZcL2Rkejk5dTQtMDljODg1NDctOGFlYy00MDg1LTg1MjQtNGM5ZTU1ZTI2ZTJjLnBuZyIsIndpZHRoIjoiPD0xMjAxIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmltYWdlLm9wZXJhdGlvbnMiXX0.yXCMsO6owdc1R-jRfSQ8qzBagQs2sZSmwmM4CQ2N5po)

# Referências

https://www.youtube.com/watch?v=h7ofkKpV4kw&feature=youtu.be
Os meus colegas no Discord.