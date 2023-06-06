using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Endlocalization : MonoBehaviour
{

    public Text winlvl;
    public Text time;
    public Text start;
    public TMP_Text map;
    //public TMP_Text seead;
    public Text reset;
    public Text playagin;
    public Text menu;
    public TMP_Text menu1;
    public TMP_Text menu2;
    public TMP_Text timeup;
    public TMP_Text retry;
    public TMP_Text retry1;
    public TMP_Text cont;
    public TMP_Text cont1;
    public Text rate;
    public Text moregames;
    public TMP_Text netwarn;
    int lan;

    private void Awake()
    {
        PlayerPrefs.GetInt("lan", 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        lan = PlayerPrefs.GetInt("lan");
        Lanchangelevel(lan);
    }
    public void Lanchangelevel(int lan)
    {

        if (lan == 0)
        {
            //ENGLISH
            winlvl.text = "Congrats ! You cleared All MAZEs";
            time.text = "Time";
            start.text = "Start";
            map.text = "MAP";
           // seead.text = "see Ad";
            reset.text = "Reset";
            playagin.text = "Play Again";
            menu.text = "Menu";
            menu1.text = "Menu";
            menu2.text = "Menu";
            timeup.text = "Time UP!!!";
            retry.text = "Retry";
            retry1.text = "Retry";
            cont.text = "Continue";
            cont1.text = "Continue";
            moregames.text = "More Games";
            rate.text = "Rate Game";
            netwarn.text = "Slow or Connection Failed";

        }
        if (lan == 1)
        {
            //FRENCH
            winlvl.text = "Félicitations ! Vous avez effacé tous les Mazes";
            time.text = "Temps";
            start.text = "Début";
            map.text = "Carte";
           // seead.text = "Voir l'annonce";
            reset.text = "Réinitialiser";
            playagin.text = "Rejouer";
            menu.text = "Menu";
            menu1.text = "Menu ";
            menu2.text = "Menu ";
            timeup.text = "Temps écoulé";
            retry.text = "Recommencez";
            retry1.text = "Recommencez";
            cont.text = "Continuez";
            cont1.text = "Continuez";
            moregames.text = "Plus de jeux";
            rate.text = "taux jeu";
            netwarn.text = "connexion échec";

        }
        if (lan == 2)
        {
            //SPANISH
            winlvl.text = "Felicidades! Desactivó Todos los laberintos";
            time.text = "reloj";
            start.text = "comienzo";
            map.text = "Mapa";
          //  seead.text = "ver anuncio";
            reset.text = "Reiniciar";
            playagin.text = "Juega de nuevo";
            menu.text = "Menú";
            menu1.text = "Menú";
            menu2.text = "Menú";
            timeup.text = "tiempo hasta";
            retry.text = "Procesar de nuevo";
            retry1.text = "Procesar de nuevo";
            cont.text = "Hacer continuación";
            cont1.text = "Hacer continuación";
            moregames.text = "Más juegos";
            rate.text = "Califica el juego";
            netwarn.text = "conexión  fracaso";

        }
        if (lan == 3)
        {
            //RUSSIAN
            winlvl.text = "Congrats! Вы очистили все лабиринты";
            time.text = "Часы";
            start.text = "Начало";
            map.text = "карта";
          //  seead.text = "смотреть объявление";
            reset.text = "Сброс";
            playagin.text = "Играть снова";
            menu.text = "Меню";
            menu1.text = "Меню";
            menu2.text = "Меню";
            timeup.text = "Время вышло";
            retry.text = "Retry";
            retry1.text = "Retry";
            cont.text = "Продолжить";
            cont1.text = "Продолжить";
            moregames.text = "Больше игр";
            rate.text = "Скорость игры";
            netwarn.text = "соединение  отказ";

        }
        if (lan == 4)
        {
            //PORTUGESE
            winlvl.text = "Parabéns ! Você limpou Todos os labirintos";
            time.text = "relógio";
            start.text = "Começar";
            map.text = "Mapa";
           // seead.text = "ver anúncio";
            reset.text = "Redefinir";
            playagin.text = "Jogar de novo";
            menu.text = "Cardápio";
            menu1.text = "Cardápio";
            menu2.text = "Cardápio";
            timeup.text = "tempo acima";
            retry.text = "Repetir";
            retry1.text = "Repetir";
            cont.text = "Continuar";
            cont1.text = "Continuar";
            moregames.text = "Mais jogos";
            rate.text = "Taxa de jogo";
            netwarn.text = "conexão  fracasso";

        }
        if (lan == 5)
        {
            //GERMAN
            winlvl.text = "Glückwunsch ! Sie klären Alle Labyrinthe";
            time.text = "Uhr";
            start.text = "Anfang";
            map.text = "Karte";
           // seead.text = "siehe Ad";
            reset.text = "Zurücksetzen";
            playagin.text = "Nochmal abspielen";
            menu.text = "Speisekarte";
            menu1.text = "Speisekarte";
            menu2.text = "Speisekarte";
            timeup.text = "Zeit vorbei";
            retry.text = "Wiederholen";
            retry1.text = "Wiederholen";
            cont.text = "Fortsetzen";
            cont1.text = "Fortsetzen";
            moregames.text = "Mehr Spiele";
            rate.text = "Rate Spiel";
            netwarn.text = "Verbindung  Fehler";

        }
        if (lan == 6)
        {
            //ARABIC
            winlvl.text = "مبروك ! يمكنك مسح جميع متاهات ";
            time.text = "ساعة حائط";
            start.text = "بداية";
            map.text = "خريطة";
          //  seead.text = "انظر الإعلان";
            reset.text = "إعادة تعيين";
            playagin.text = "العب مرة أخرى";
            menu.text = "قائمة طعام";
            menu1.text = "قائمة طعام";
            menu2.text = "قائمة طعام";
            timeup.text = "انتهى الوقت";
            retry.text = "إعادة المحاولة";
            retry1.text = "إعادة المحاولة";
            cont.text = "استمر";
            cont1.text = "استمر";
            moregames.text = "المزيد من الألعاب";
            rate.text = "قيم اللعبة";
            netwarn.text = "الإتصال  بالفشل";

        }
        if (lan == 7)
        {
            //JAPANESE
            winlvl.text = "おめでとう！あなたはすべての迷路をクリア";
            time.text = "時計";
            start.text = "開始";
            map.text = "地図";
           // seead.text = "広告を見ます";
            reset.text = "リセット";
            playagin.text = "再びプレー";
            menu.text = "メニュー";
            menu1.text = "メニュー";
            menu2.text = "メニュー";
            timeup.text = "タイムアップ";
            retry.text = "リトライ";
            retry1.text = "リトライ";
            cont.text = "持続する";
            cont1.text = "持続する";
            moregames.text = "他のゲーム";
            rate.text = "レートゲーム";
            netwarn.text = "接続   故障";

        }
        if (lan == 8)
        {
            //CHINESE
            winlvl.text = "恭喜 ！您清除了所有的迷宫";
            time.text = "时钟";
            start.text = "开始";
            map.text = "地图";
           // seead.text = "看到广告";
            reset.text = "重启";
            playagin.text = "再玩一遍";
            menu.text = "菜单";
            menu1.text = "菜单";
            menu2.text = "菜单";
            timeup.text = "时间到";
            retry.text = "重试";
            retry1.text = "重试";
            cont.text = "继续";
            cont1.text = "继续";
            moregames.text = "更多游戏";
            rate.text = "汇率博弈";
            netwarn.text = "连接  失败";

        }
        if (lan == 9)
        {
            //KOREAN
            winlvl.text = "축하! 당신은 모든 미로를 삭제";
            time.text = "시계";
            start.text = "스타트";
            map.text = "지도";
            //seead.text = "광고";
            reset.text = "초기화";
            playagin.text = "다시 재생";
            menu.text = "메뉴";
            menu1.text = "메뉴";
            menu2.text = "메뉴";
            timeup.text = "시간 최대";
            retry.text = "다시 해 보다";
            retry1.text = "다시 해 보다";
            cont.text = "계속하다";
            cont1.text = "계속하다";
            moregames.text = "더많은 게임";
            rate.text = "평가 게임";
            netwarn.text = "연결  실패";

        }

    }

    public void Resetbn()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Menu");
      
    }
    public void Rate()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate");
    }
    public void Moregames()
    {
        Application.OpenURL("https://play.google.com/store/apps/developer?id=Alpha+Apps+%26+Games");
    }


}
