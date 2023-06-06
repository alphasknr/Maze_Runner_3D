using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Animations;

public class Menulocalization : MonoBehaviour
{
    int lan;
    public TMP_Dropdown listlang;
    public TMP_Text play;
    public TMP_Text settings;
    public TMP_Text instructions;
    public TMP_Text instructions1;
    public TMP_Text moregames;
    public TMP_Text exit;
    public TMP_Text reset;
    public TMP_Text back;
    public TMP_Text menu;
    public TMP_Text menu1;
    public TMP_Text adfree;
    public TMP_Text settings1;
    public TMP_Text language;
    public TMP_Text music;
    public TMP_Text sound;
    public TMP_Text privacy;
    public TMP_Text Iscroll;
    public TMP_Text desc1;
    public TMP_Text desc2;
    public TMP_Text unlock;
    public TMP_Text netwarn;

    private void Awake()
    {
        PlayerPrefs.GetInt("lan", 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        lan = PlayerPrefs.GetInt("lan");
        listlang.value = lan;
        Languageselected(lan);
       
    }
   
    public void Languageselected(int lan)
    {
        PlayerPrefs.SetInt("lan", lan);
        if (lan == 0)
        {
            //ENGLISH
            play.text = "Play";
            settings.text = "Settings";
            instructions.text = "Instructions";
            instructions1.text = "Instructions";
            moregames.text = "More Games";
            privacy.text = "Privacy Policy";
            reset.text = "Reset";
            exit.text = "Exit";
            settings1.text = "Settings";
            sound.text = "Sound";
            music.text = "Music";
            back.text = "Back";
            menu.text = "Menu";
            language.text = "Language";
            menu1.text = "Menu";
            adfree.text = "Shop";
            Iscroll.text = "\n                      GAME PLAY\n\n--->Click the game button on the menu screen and it will take you to levels screen.\n--->At the begining only one level is available for you to play, and next level will be available after completing the previous level.\n--->Click on the level you want to play, and the level will be loaded for you.\n--->First see the timer and then click the start button to start the level.\n--->In a level you will be in a maze at the centre of the maze, and you need to find a way to get out of the maze.\n--->At the same time, you will see a joystick on the screen, and at left bottom the buttons "+"L" +"for left turn &" + "R" + " for right turn and at the right bottom you will see a arrow buttons for front, back, left, right movements of the player.\n--->While finding a way out of the maze you can see the map by clicking map button on the right side of the screen to see where you are and what is the way. You need to watch an ad everytime you press the map button.\n--->Each level has different time limits to complete the maze, so you need to hurry...\n--->You can pause the game at any time while you are in a maze and you can go to menu from the level.\n--->On the menu screen, you can go to options by clicking it, and you can change music and sound settings for the game.\n--->On the menu screen, you can check the privacy policy of this game by clicking privacy policy button.\n--->On the meny screen, at the bottom left corner of the screen, you can find a reset button to reset the game and then you can play from the very beginning.So be careful with that, and thats why we put that on the corner, so that no one can touch it by mistake.\n--->After completing the final level, you can reset the game and play again from the begining.\n--->And the other things i hope you are aware of them...\nThanks for playing this game and check out more games made by us in the PLAYSTORE.\n\nALPHA APPS & GAMES";
            desc1.text = "Unlocks All Levels";
            desc2.text = "Removes Ads \n Map with no Ads";
            unlock.text = "Unlock  Next  Maze";
            netwarn.text = "Slow or Connection Failed";
        }

        if (lan == 1)
        {
            //FRENCH
            play.text = "Jouer";
            settings.text = "Paramètres";
            instructions.text = "Instructions";
            instructions1.text = "Instructions";
            moregames.text = "Plus de jeux";
            privacy.text = "Politique de confidentialité";
           
            reset.text = "Réinitialiser";
            exit.text = "Sortie";
            settings1.text = "Paramètres";
            sound.text = "Du son";
            music.text = "La musique";
            back.text = "Retour";
            menu.text = "Menu";
            menu1.text = "Menu";
            adfree.text = "magasin";
            language.text = "La langue";
            Iscroll.text = "\n                     JEU DE JEU \n \n--->Cliquez sur le bouton de jeu de l'écran de menu pour accéder à l'écran des niveaux. \n--->Au début, un seul niveau est disponible pour vous de jouer, et le niveau suivant sera disponible après avoir terminé le niveau précédent. \n--->Cliquez sur le niveau que vous voulez jouer et le niveau sera chargé pour vous. \n--->Tout d’abord, regardez le chronomètre, puis cliquez sur le bouton de démarrage pour commencer le niveau. \n--->Dans un niveau, vous serez dans un labyrinthe au centre du labyrinthe, et vous devez trouver un moyen de sortir du labyrinthe. \n--->En même temps, vous verrez un joystick sur l’écran et, en bas à gauche, les boutons "+" L "+" pour virer à gauche &"+" R "+" pour virer à droite et, en bas à droite, un bouton fléché à l’avant , retour, gauche, mouvements du joueur à droite. \n--->Tout en trouvant un moyen de sortir du labyrinthe, vous pouvez voir la carte en cliquant sur le bouton de la carte à droite de l'écran pour voir où vous vous trouvez et quel est le Vous devez regarder une annonce à chaque fois que vous appuyez sur le bouton Carte. \n ---> Chaque niveau a louer des limites de temps pour terminer le labyrinthe, donc vous devez vous dépêcher ... \n ---> Vous pouvez mettre en pause le jeu à tout moment pendant que vous êtes dans un labyrinthe et vous pouvez aller au menu à partir du niveau. \n-- -> Sur l'écran de menu, vous pouvez accéder aux options en cliquant dessus et modifier les paramètres de musique et de son du jeu. \n--->Sur l'écran de menu, vous pouvez consulter la politique de confidentialité de ce jeu en cliquant sur bouton de politique de confidentialité. \n ---> Sur l’écran Meny, dans le coin inférieur gauche de l’écran, vous trouverez un bouton de réinitialisation pour réinitialiser le jeu, puis vous pourrez jouer dès le début. Faites donc attention à cela, et c’est pourquoi nous mettons cela dans le coin, afin que personne ne puisse y toucher par erreur. \n ---> Après avoir terminé le dernier niveau, vous pouvez réinitialiser le jeu et rejouer à partir du début. \n ---> Et les autres choses que j'espère que vous êtes au courant ... \n Merci de jouer à ce jeu et de regarder plus de jeux faits par nous dans le PLAYSTORE. \n \n ALPHA APPS &GAMES ";
            desc1.text = "Débloque tous les niveaux";
            desc2.text = "Supprimer les annonces \n Carte sans annonces";
            unlock.text = "ouvrir  Maze Suivant";
            netwarn.text = "connexion échec";
        }
        if (lan == 2)
        {
            //SPANISH
            play.text = "Jugar";
            settings.text = "Ajustes";
            instructions.text = "Instrucciones";
            instructions1.text = "Instructiones";
            moregames.text = "Más juegos";
            privacy.text = "Política de privacidad";
           
            reset.text = "Reiniciar";
            exit.text = "Salida";
            settings1.text = "Ajustes";
            sound.text = "Sonido";
            music.text = "Música";
            back.text = "Atrás";
            menu.text = "Menú";
            menu1.text = "Menú";
            adfree.text = "tienda";
            language.text = "Idioma";
            Iscroll.text = "\n                  EL JUEGO \n \n--->Haga clic en el botón de juego en la pantalla de menú y que le llevará a la pantalla de niveles. \n--->Al principio solo nivel está disponible para que usted pueda jugar, y el próximo nivel estará disponible después de completar el nivel anterior. \n--->Haga clic en el nivel que desea jugar, y el nivel se cargará para usted. \n--->Primera ver el temporizador y luego haga clic en el botón de inicio para empezar el nivel. \n--->en un nivel que será en un laberinto en el centro del laberinto, y es necesario encontrar una manera de salir del laberinto. \n--->al mismo tiempo, , verá una palanca de mando en la pantalla y en la parte inferior izquierda de los botones "+" L "+ "para girar a la izquierda y " +"R"+ "para girar a la derecha y en la parte inferior derecha verá un botones de flecha para el frente , atrás, izquierda, derecha movimientos del jugador. \n ---> Mientras que encontrar una manera de salir del laberinto se puede ver el mapa haciendo clic en el botón mapa en el lado derecho de la pantalla para ver dónde se encuentra y cuál es la manera. Es necesario tener cuidado de un anuncio cada vez que se pulsa el botón del mapa. \n ---> Cada nivel tiene dife alquilar límites de tiempo para completar el laberinto, por lo que hay que darse prisa ... \n ---> Puede pausar el juego en cualquier momento mientras se encuentra en un laberinto y se puede ir al menú de nivel. \n- -> en la pantalla de menú, se puede ir a las opciones haciendo clic en él, y puede cambiar la configuración de música y sonido para el juego \n ---> en la pantalla de menú, se puede comprobar la política de privacidad de este juego haciendo clic. botón política de privacidad. \n ---> en la pantalla de Meny, en la esquina inferior izquierda de la pantalla, se puede encontrar un botón de reinicio para reiniciar el juego y luego se puede jugar desde el beginning.So tener cuidado con eso, y es por eso que ponemos que en la esquina, por lo que nadie puede tocarlo por error. \n ---> Después de completar el último nivel, se puede reiniciar el juego y jugar de nuevo desde el principio. \n ---> y las otras cosas que espero que son conscientes de ellos ... \n Gracias para jugar a este juego y ver más juegos realizados por nosotros en el playstore. \n \n Alpha Apps and Games";
            desc1.text = "Desbloquea todos los niveles";
            desc2.text = "Evitar los anuncios \n Mapa sin anuncios";
            unlock.text = "desbloquear  Siguiente Maze";
            netwarn.text = "conexión  fracaso";
        }

        if (lan == 3)
        {
            //RUSSIAN
            play.text = "Играть";
            settings.text = "настройки";
            instructions.text = "инструкции";
            instructions1.text = "инструкции";
            moregames.text = "Больше игр";
            privacy.text = "политика конфиденциальности";
            
            reset.text = "Сброс";
            exit.text = "Выход";
            settings1.text = "настройки";
            sound.text = "Звук";
            music.text = "Музыка";
            back.text = "назад";
            menu.text = "Меню";
            menu1.text = "Меню";
            adfree.text = "магазин";
            language.text = "язык";
            Iscroll.text= "\n                   ИГРА ИГРЫ \n \n ---> Нажмите кнопку игры на экране меню и он будет считать вас на экране уровней. \n ---> В начале только один уровень доступен для вас играть, и следующий уровень будут доступны после завершения предыдущего уровня. \n ---> нажмите на уровне вы хотите играть, и уровень будет загружен для вас. \n ---> Сначала увидеть таймер, а затем нажмите кнопку запуска для начать уровень. \n ---> в уровне вы будете в лабиринте в центре лабиринта, и вы должны найти способ, чтобы выйти из лабиринта. \n ---> в то же время , вы увидите джойстик на экране, и в левом нижнем углу кнопка" + " L" + "для левого поворота и" + "R" + "для правого поворота и в правом нижнем углу вы увидите кнопки со стрелкой для переднего , назад, влево, вправо движения игрока. \n ---> Хотя найти выход из лабиринта вы можете увидеть карту, нажав кнопку карты на правой стороне экрана, чтобы увидеть, где вы и что это путь. вы должны смотреть рекламную каждый раз, когда вы нажимаете кнопку на карту. \n ---> Каждый уровень имеет сиситемах арендовать сроки завершить лабиринт, так что вам нужно спешить ... \n ---> Вы можете приостановить игру в любое время, пока вы находитесь в лабиринте, и вы можете перейти в меню из уровня. \n---> на экране меню, вы можете перейти к настройкам, нажав на него, и вы можете изменить музыку и звуковые настройки для игры \n ---> на экране меню, вы можете проверить политику конфиденциальности этой игры, нажав кнопку. кнопка политики конфиденциальности. \n ---> на экране Мени, в нижнем левом углу экрана, вы можете найти кнопку сброса, чтобы сбросить игру, а затем вы можете играть с самого beginning.So быть осторожным с этим, и вот почему мы ставим, что на углу, так что никто не может прикоснуться к ней по ошибке. \n ---> После завершения последнего уровня, вы можете сбросить игру и играть снова с начала. \n ---> другие вещи, которые я надеюсь, что вы знаете о них ... \n С уважением для играть в эту игру и проверить больше игр, сделанных нами в playstore. \n\n ALPHA APPS & GAMES";
            desc1.text = "Разблокировка всех уровней";
            desc2.text = "Удалить объявления \n Карта без рекламы";
            unlock.text = "разблокировка  Следующие Maze";
            netwarn.text = "соединение  отказ";

        }
        if (lan == 4)
        {
            //PORTUGESE
            play.text = "Toque";
            settings.text = "Configurações";
            instructions.text = "instruções";
            instructions1.text = "instruções";
            moregames.text = "Mais jogos";
            privacy.text = "Política de Privacidade";
           
            reset.text = "Redefinir";
            exit.text = "Saída";
            settings1.text = "Configurações";
            sound.text = "Som";
            music.text = "Música";
            back.text = "De volta";
            menu.text = "Cardápio";
            menu1.text = "Cardápio";
            adfree.text = "fazer compras";
            language.text = "Língua";
            Iscroll.text = "\n                    JOGO DE JOGO \n \n ---> Clique no botão jogo na tela do menu e ele irá levá-lo para a tela níveis. \n ---> No apenas um nível começando está disponível para você jogar, e próximo nível estará disponível após a conclusão do nível anterior. \n ---> Clique no nível que você quer jogar, eo nível será carregado para você. \n ---> primeiro ver o temporizador e, em seguida, clique no botão Iniciar para começar o nível. \n ---> em um nível, você estará em um labirinto no centro do labirinto, e você precisa encontrar uma maneira de sair do labirinto. \n ---> ao mesmo tempo , você vai ver um joystick na tela, e no canto inferior esquerdo os botões " + " L " + "para virar à esquerda e" + "R" + " para virar à direita e na parte inferior direita você verá uma seta botões para frente , para trás, esquerda, os movimentos de direita do jogador. \n ---> quando encontrar um caminho para sair do labirinto você pode ver o mapa clicando no botão mapa no lado direito da tela para ver onde você está e qual é a caminho. você precisa assistir a um cada vez ad você pressionar o botão mapa. \n ---> Cada nível tem dife alugar prazos para completar o labirinto, então você precisa se apressar ... \n ---> Você pode pausar o jogo a qualquer momento, enquanto você está em um labirinto e você pode ir para o menu do nível. \n-- -> na tela do menu, você pode ir para opções clicando nele, e você pode alterar as configurações de áudio e música para o jogo \n ---> na tela do menu, você pode verificar a política de privacidade deste jogo clicando com o botão. botão política de privacidade. \n ---> na tela meny, no canto inferior esquerdo da tela, você pode encontrar um botão de reset para reiniciar o jogo e então você pode jogar desde o beginning.So ter cuidado com isso, e é por isso que nós colocamos que na esquina, de modo que ninguém pode tocá-lo por engano. \n ---> Depois de completar o nível final, você pode redefinir o jogo e jogar novamente desde o início. \n ---> e as outras coisas que eu espero que você está ciente deles ... \n Obrigado para jogar este jogo e confira mais jogos feitos por nós na google playstore. \n \n ALPHA APPS AND GAMES";
            desc1.text = "Desbloqueia todos os níveis";
            desc2.text = "Remova os anúncios \n Mapa sem anúncios";
            unlock.text = "desbloqueio  próxima Maze";
            netwarn.text = "conexão  fracasso";
        }
        if (lan == 5)
        {
            //GERMAN
            play.text = "Play";
            settings.text = "Einstellungen";
            instructions.text = "Anleitung";
            instructions1.text = "Anleitung";
            moregames.text = "Mehr Spiele";
            privacy.text = "Datenschutz-Bestimmungen";
           
            reset.text = "Zurücksetzen";
            exit.text = "Ausgang";
            settings1.text = "Einstellungen";
            sound.text = "Klang";
            music.text = "Musik";
            back.text = "Zurück";
            menu.text = "Speisekarte";
            menu1.text = "Speisekarte";
            adfree.text = "Geschäft";
            language.text = "Sprache";
            Iscroll.text = "\n                       SPIELWEISE \n \n ---> Klicken Sie auf die Spielschaltfläche auf dem Menübildschirm, um zum Ebenenbildschirm zu gelangen. \n ---> Am Anfang steht Ihnen nur eine Ebene zum Spielen zur Verfügung Das nächste Level ist verfügbar, wenn Sie das vorherige Level abgeschlossen haben. \n ---> Klicken Sie auf das Level, das Sie spielen möchten, und das Level wird für Sie geladen. \n ---> Sehen Sie sich zuerst den Timer an und klicken Sie dann auf Start \n ---> In einem Level befinden Sie sich in einem Labyrinth in der Mitte des Labyrinths und müssen einen Weg finden, um aus dem Labyrinth herauszukommen. \n ---> Am Gleichzeitig sehen Sie einen Joystick auf dem Bildschirm und links unten die Tasten " + " L " + " für Linksabbiegung und " + " R " + " für Rechtsabbiegung und am Unten rechts sehen Sie die Pfeilschaltflächen für die Bewegungen des Players nach vorne, hinten, links und rechts. \n ---> Wenn Sie einen Weg aus dem Labyrinth heraus finden, können Sie die Karte anzeigen, indem Sie rechts auf die Schaltfläche Karte klicken Sie müssen jedes Mal eine Anzeige sehen, wenn Sie die Kartentaste drücken. \n ---> Jede Ebene Es gibt verschiedene Zeitlimits, um das Labyrinth fertig zu stellen. Sie müssen sich also beeilen ... \n ---> Sie können das Spiel jederzeit anhalten, während Sie sich in einem Labyrinth befinden, und Sie können vom Level aus zum Menü gehen. \n- -> Auf dem Menübildschirm können Sie zu den Optionen wechseln, indem Sie darauf klicken, und Sie können die Musik- und Soundeinstellungen für das Spiel ändern. \n---> Auf dem Menübildschirm können Sie die Datenschutzbestimmungen für dieses Spiel überprüfen Klicken Sie auf die Schaltfläche Datenschutzrichtlinie. \n ---> Auf dem Menübildschirm in der linken unteren Ecke des Bildschirms finden Sie eine Schaltfläche Zurücksetzen, mit der Sie das Spiel zurücksetzen und dann von Anfang an spielen können , und deshalb haben wir das an die Ecke gelegt, damit niemand es versehentlich anfassen kann. \n ---> Nach Abschluss des letzten Levels können Sie das Spiel zurücksetzen und von Anfang an erneut spielen. \n --- > Und die anderen Dinge, von denen ich hoffe, dass Sie sie kennen ... \n Danke, dass Sie dieses Spiel gespielt haben, und schauen Sie sich weitere Spiele an, die von uns im PLAYSTORE hergestellt wurden. \n \n ALPHA APPS & GAMES ";
            desc1.text = "Schaltet alle Ebenen";
            desc2.text = "Entfernen Sie Anzeigen \n Karte ohne Werbung";
            unlock.text = "Freischalten  Weiter Maze";
            netwarn.text = "Verbindung  Fehler";

        }
        if (lan == 6)
        {
            //ARABIC
            play.text = "لعب";
            settings.text = "الإعدادات";
            instructions.text = "تعليمات";
            instructions1.text = "تعليمات";
            moregames.text = "المزيد من الألعاب";
            privacy.text = "سياسة خاصة";
           
            reset.text = "إعادة تعيين";
            exit.text = "خروج";
            settings1.text = "الإعدادات";
            sound.text = "صوت";
            music.text = "موسيقى";
            back.text = "عودة";
            menu.text = "قائمة طعام";
            menu1.text = "قائمة طعام";
            adfree.text = "متجر";
            language.text = "لغة";
            Iscroll.text = "\n                 كيف ألعب  \n ---> انقر فوق زر اللعبة على شاشة القائمة وسيأخذك إلى شاشة المستويات. \n ---> في البداية ، يتوفر مستوى واحد فقط يمكنك اللعب به ، سيكون المستوى التالي متاحًا بعد الانتهاء من المستوى السابق. \n ---> انقر على المستوى الذي تريد لعبه ، وسيتم تحميل المستوى لك. \n ---> أولاً ، انظر إلى المؤقت ، ثم انقر فوق البدء زر لبدء المستوى. \n ---> في المستوى ، ستكون في متاهة في وسط المتاهة ، وستحتاج إلى إيجاد طريقة للخروج من المتاهة.\n ---> في الوقت نفسه ، سترى ذراع التحكم على الشاشة ، وفي أسفل اليسار الأزرار " + " L " + " لليسار يمين  " + " R " + " لليمين لليمين وفي في أسفل اليمين ، سترى أزرار سهم للحركات الأمامية والخلفية واليسرى واليمنى للمشغل. \n ---> أثناء العثور على مخرج من المتاهة ، يمكنك رؤية الخريطة من خلال النقر على زر الخريطة على الجانب الأيمن من شاشة لمعرفة أين أنت وما هي الطريق. تحتاج إلى مشاهدة إعلان في كل مرة تضغط فيها على زر الخريطة. \n ---> كل مستوى يحتوي على حدود زمنية مختلفة لإكمال المتاهة ، لذلك تحتاج إلى التعجيل ... \n ---> يمكنك إيقاف اللعبة مؤقتًا في أي وقت أثناء وجودك في متاهة ويمكنك الانتقال إلى القائمة من المستوى. \n- -> على شاشة القائمة ، يمكنك الانتقال إلى الخيارات بالنقر فوقها ، ويمكنك تغيير إعدادات الموسيقى والصوت للعبة. \n ---> على شاشة القائمة ، يمكنك التحقق من سياسة الخصوصية لهذه اللعبة عن طريق النقر فوق زر سياسة الخصوصية. \n ---> على الشاشة الضيقة ، في الركن الأيسر السفلي من الشاشة ، يمكنك العثور على زر إعادة الضبط لإعادة ضبط اللعبة وبعد ذلك يمكنك اللعب من البداية. لذا كن حذرًا في ذلك ، ولهذا السبب وضعنا ذلك في الزاوية ، بحيث لا يمكن لأحد أن يمسها عن طريق الخطأ. \n ---> بعد الانتهاء من المستوى النهائي ، يمكنك إعادة ضبط اللعبة واللعب مرة أخرى من البداية. \n --- > والأشياء الأخرى آمل أن تكونوا على دراية بها ... \n شكرًا على لعب هذه اللعبة وتحقق من المزيد من الألعاب التي صنعناها في google playstore. \n \n ALPHA APPS & GAMES ";
            desc1.text = "يفتح جميع المستويات";
            desc2.text = "ازالة الاعلانات \n ن خريطة مع أي إعلانات";
            unlock.text = "الغاء القفل  المتاهة التالي";
            netwarn.text = "الإتصال  بالفشل";

        }
        if (lan == 7)
        {
            //JAPANESE
            play.text = "遊びます";
            settings.text = "設定";
            instructions.text = "説明書";
            instructions1.text = "説明書";
            moregames.text = "他のゲーム";
            privacy.text = "個人情報保護方針";
           
            reset.text = "リセット";
            exit.text = "出口";
            settings1.text = "設定";
            sound.text = "音";
            music.text = "音楽";
            back.text = "バック";
            menu.text = "メニュー";
            menu1.text = "メニュー";
            adfree.text = "ショップ";
            language.text = "言語";
            Iscroll.text= "\n                      ゲームプレイ\n \n->メニュー画面のゲームボタンをクリックすると、レベル画面に移動します。\n --->最初は、プレイできるレベルは1つだけです。前のレベルを完了すると、次のレベルが使用可能になります。\n --->プレイしたいレベルをクリックすると、レベルが自動的にロードされます。\n --->最初にタイマーを確認し、開始をクリックしますボタンを押してレベルを開始します。\n --->レベルでは、迷路の中心にある迷路に入ります。迷路から抜け出す方法を見つける必要があります。\n --->同時に、画面にジョイスティックが表示され、左下に「 " + "L" + "」ボタンがあり、左折すると" + "R" + "が右折します。右下には、プレーヤーの前後左右の動きを示す矢印ボタンが表示されます。\n --->迷路から抜け出す方法を見つけている間、右側のマップボタンをクリックしてマップを表示できます。地図ボタンを押すたびに広告を見る必要があります。\n --->各レベル迷路を完了するためのさまざまな時間制限があるため、急いでください... \n --->迷路にいる間はいつでもゲームを一時停止でき、レベルからメニューに移動できます。\n- ->メニュー画面で、クリックしてオプションに移動し、ゲームの音楽とサウンドの設定を変更できます。\n --->メニュー画面で、このゲームのプライバシーポリシーを確認できます。プライバシーポリシーボタンをクリックします。\n --->画面の左下にある多くの画面で、ゲームをリセットするためのリセットボタンを見つけることができ、最初からプレイすることができます。 、そして、だから私たちはそれを隅に置いて、だれも誤ってそれに触れないようにします。\n --->最終レベルを完了したら、ゲームをリセットして最初からやり直すことができます。\n --- >そして、あなたがそれらに気づいていることを願っています... \nこのゲームをプレイしてくれてありがとう。google play storeで私たちが作った他のゲームをチェックしてください。\n \n Alpha Apps & Games ";
            desc1.text = "すべてのレベルのロックを解除";
            desc2.text = "広告なし";
            unlock.text = "ロック解除  次の迷路";
            netwarn.text = "接続   故障";

        }
        if (lan == 8)
        {
            //CHINESE
            play.text = "玩";
            settings.text = "设置";
            instructions.text = "使用说明";
            instructions1.text = "使用说明";
            moregames.text = "更多游戏";
            privacy.text = "隐私政策";
           
            reset.text = "重启";
            exit.text = "关闭";
            settings1.text = "设置";
            sound.text = "声音";
            music.text = "音乐";
            back.text = "背部";
            menu.text = "菜单";
            menu1.text = "菜单";
            adfree.text = "店";
            language.text = "语言";
            Iscroll.text="\n                游戏玩法 \n \n--->单击菜单屏幕上的游戏按钮，它将带您进入关卡屏幕。\n--->开始时，只有一个关卡可供您玩，并且完成上一个级别后，下一个级别将可用。\n--->单击您要播放的级别，然后将为您加载该级别。\n--->首先查看计时器，然后单击开始按钮以启动关卡。\n--->在关卡中，您将处于迷宫中央的迷宫中，您需要找到一种摆脱迷宫的方法。\n--->在同时，您将在屏幕上看到操纵杆，并且在左下方的按钮“ +“ L” +“用于左转，＆“ +” R” +”用于右转，并在在右下方，您将看到一个箭头按钮，用于指示玩家向前，向后，向左，向右的运动。\n--->在迷宫中寻找出一条出路时，您可以通过单击游戏右侧的地图按钮来查看地图。屏幕以查看您的位置和方式。每次按地图按钮时，您都需要观看广告。\n--->每个级别迷宫有不同的时间限制，因此您需要抓紧时间... \n--->您可以随时在迷宫中暂停游戏，并且可以从关卡中转到菜单。\n - ->在菜单屏幕上，您可以通过单击它进入选项，并且可以更改游戏的音乐和声音设置。\n--->在菜单屏幕上，您可以通过以下方式查看此游戏的隐私权政策：单击隐私策略按钮。\n--->在屏幕的左下角的男性屏幕上，您可以找到一个重置按钮来重置游戏，然后您就可以从头开始玩了。 ，这就是为什么我们将其放在角落，所以没有人会误触它。\n--->完成最终关卡后，您可以重设游戏并从头开始玩。\n-- - > 其他我希望您也意识到了这些... \n感谢您玩此游戏，并在 Google playstore 们制作的更多游戏。\n \n ALPHA APPS＆GAMES";
            desc1.text = "解锁所有级别";
            desc2.text = "无广告";
            unlock.text = "开锁   接下来迷宫";
            netwarn.text = "连接  失败";

        }
        if (lan == 9)
        {
            //KOREAN
            play.text = "놀이";
            settings.text = "설정";
            instructions.text = "명령";
            instructions1.text = "명령";
            moregames.text = "더많은 게임";
            privacy.text = "개인 정보 정책";
           
            reset.text = "초기화";
            exit.text = "출구";
            settings1.text = "설정";
            sound.text = "소리";
            music.text = "음악";
            back.text = "뒤";
            menu.text = "메뉴";
            menu1.text = "메뉴";
            adfree.text = "가게";
            language.text = "언어";
            Iscroll.text = "\n                 게임 플레이 \n \n ---> 메뉴 화면에서 게임 버튼을 클릭하면 레벨 화면으로 이동합니다. \n ---> 처음에는 한 레벨 만 플레이 할 수 있습니다. 이전 레벨을 완료하면 다음 레벨을 사용할 수 있습니다. \n ---> 재생하려는 레벨을 클릭하면 레벨이로드됩니다. \n ---> 먼저 타이머를 본 다음 시작을 클릭하십시오. 버튼을 누르면 레벨이 시작됩니다. \n ---> 레벨에서는 미로 중앙에있는 미로가 있으며, 미로에서 벗어날 수있는 방법을 찾아야합니다. \n ---> 동시에 화면에 조이스틱이 표시되고 왼쪽 하단에 " + "L " + "왼쪽 회전 & " + "R " + "오른쪽 회전 및 오른쪽 하단에는 플레이어의 앞, 뒤, 왼쪽, 오른쪽 움직임에 대한 화살표 버튼이 표시됩니다. \n ---> 미로에서 나가는 길을 찾는 동안 오른쪽의지도 버튼을 클릭하여지도를 볼 수 있습니다 화면을 클릭하면 현재 위치와 방법을 확인할 수 있습니다.지도 버튼을 누를 때마다 광고를 봐야합니다. \n ---> 각 레벨 미로를 완료하는 데 다른 시간 제한이 있으므로 서둘러야합니다 ... \n ---> 미로에있는 동안 언제든지 게임을 일시 중지하고 레벨에서 메뉴로 이동할 수 있습니다. \n- -> 메뉴 화면에서 클릭하여 옵션으로 이동하고 게임의 음악 및 사운드 설정을 변경할 수 있습니다. \n ---> 메뉴 화면에서이 게임의 개인 정보 보호 정책을 확인하여 개인 정보 보호 정책 버튼을 클릭하십시오. \n ---> 일반 화면의 화면 왼쪽 하단에서 게임을 재설정하는 재설정 버튼을 찾은 다음 처음부터 재생할 수 있습니다. , 그래서 우리는 그것을 모퉁이에 두어 아무도 실수로 그것을 만질 수 없도록합니다. \n ---> 최종 레벨을 완료 한 후에는 게임을 재설정하고 처음부터 다시 플레이 할 수 있습니다. > 그리고 내가 알고 싶은 다른 것들 ... \n이 게임을 해주셔서 감사합니다. Google Playstore에서 더 많은 게임을 확인하십시오. \n \n ALPHA APPS & GAMES";
            desc1.text = "모든 수준의 잠금을 해제";
            desc2.text = "광고 없음";
            unlock.text = "터놓다  다음 미로";
            netwarn.text = "연결  실패";

        }
    }
   
}
