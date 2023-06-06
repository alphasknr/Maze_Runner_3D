using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Levellocalization : MonoBehaviour
{

    public Text winlvl;
    public Text time;
    public Text start;
    public TMP_Text map;
    public Text next;
    public Text playagin;
    public Text menu;
    public TMP_Text menu1;
    public TMP_Text menu2;
    public TMP_Text timeup;
    public TMP_Text retry;
    public TMP_Text retry1;
    public TMP_Text cont;
    public TMP_Text cont1;
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
            winlvl.text = "Now You Are Out Of The Maze";
            time.text = "Time";
            start.text = "START";
            map.text = "MAP";
            next.text = "Next Maze";
            playagin.text = "Play Again";
            menu.text = "Menu";
            menu1.text = "Menu";
            menu2.text = "Menu";
            timeup.text = "Time UP!!!";
            retry.text = "Retry";
            retry1.text = "Retry";
            cont.text = "Continue";
            cont1.text = "Continue";
            netwarn.text = "Slow or Connection Failed";

        }
        if (lan == 1)
        {
            //FRENCH
            winlvl.text = "Maintenant, vous êtes hors du labyrinthe";
            time.text = "Temps";
            start.text = "Début";
            map.text = "Carte";
            next.text = "Suivant Maze";
            playagin.text = "Rejouer";
            menu.text = "Menu";
            menu1.text = "Menu ";
            menu2.text = "Menu ";
            timeup.text = "Temps écoulé";
            retry.text = "Recommencez";
            retry1.text = "Recommencez";
            cont.text = "Continuez";
            cont1.text = "Continuez";
            netwarn.text = "connexion échec";

        }
        if (lan == 2)
        {
            //SPANISH
            winlvl.text = "Ahora usted está fuera del laberinto";
            time.text = "reloj";
            start.text = "comienzo";
            map.text = "Mapa";
            next.text = "Siguiente Maze";
            playagin.text = "Juega de nuevo";
            menu.text = "Menú";
            menu1.text = "Menú";
            menu2.text = "Menú";
            timeup.text = "tiempo hasta";
            retry.text = "Procesar de nuevo";
            retry1.text = "Procesar de nuevo";
            cont.text = "Hacer continuación";
            cont1.text = "Hacer continuación";
            netwarn.text = "conexión  fracaso";

        }
        if (lan == 3)
        {
            //RUSSIAN
            winlvl.text = "Теперь вы вышли из лабиринта";
            time.text = "Часы";
            start.text = "Начало";
            map.text = "карта";
            next.text = "Следующие Maze";
            playagin.text = "Играть снова";
            menu.text = "Меню";
            menu1.text = "Меню";
            menu2.text = "Меню";
            timeup.text = "Время вышло";
            retry.text = "Retry";
            retry1.text = "Retry";
            cont.text = "Продолжить";
            cont1.text = "Продолжить";
            netwarn.text = "соединение  отказ";

        }
        if (lan == 4)
        {
            //PORTUGESE
            winlvl.text = "Agora você está fora do labirinto";
            time.text = "relógio";
            start.text = "Começar";
            map.text = "Mapa";
            next.text = "próxima Maze";
            playagin.text = "Jogar de novo";
            menu.text = "Cardápio";
            menu1.text = "Cardápio";
            menu2.text = "Cardápio";
            timeup.text = "tempo acima";
            retry.text = "Repetir";
            retry1.text = "Repetir";
            cont.text = "Continuar";
            cont1.text = "Continuar";
            netwarn.text = "conexão  fracasso";

        }
        if (lan == 5)
        {
            //GERMAN
            winlvl.text = "Jetzt sind Sie aus dem Labyrinth";
            time.text = "Uhr";
            start.text = "Anfang";
            map.text = "Karte";
            next.text = "Weiter Maze";
            playagin.text = "Nochmal abspielen";
            menu.text = "Speisekarte";
            menu1.text = "Speisekarte";
            menu2.text = "Speisekarte";
            timeup.text = "Zeit vorbei";
            retry.text = "Wiederholen";
            retry1.text = "Wiederholen";
            cont.text = "Fortsetzen";
            cont1.text = "Fortsetzen";
            netwarn.text = "Verbindung  Fehler";

        }
        if (lan == 6)
        {
            //ARABIC
            winlvl.text = "أنت الآن للخروج من المتاهة";
            time.text = "ساعة حائط";
            start.text = "بداية";
            map.text = "خريطة";
            next.text = "المتاهة التالي";
            playagin.text = "العب مرة أخرى";
            menu.text = "قائمة طعام";
            menu1.text = "قائمة طعام";
            menu2.text = "قائمة طعام";
            timeup.text = "انتهى الوقت";
            retry.text = "إعادة المحاولة";
            retry1.text = "إعادة المحاولة";
            cont.text = "استمر";
            cont1.text = "استمر";
            netwarn.text = "الإتصال  بالفشل";

        }
        if (lan == 7)
        {
            //JAPANESE
            winlvl.text = "今、あなたは迷路から出ています";
            time.text = "時計";
            start.text = "開始";
            map.text = "地図";
            next.text = "次の迷路";
            playagin.text = "再びプレー";
            menu.text = "メニュー";
            menu1.text = "メニュー";
            menu2.text = "メニュー";
            timeup.text = "タイムアップ";
            retry.text = "リトライ";
            retry1.text = "リトライ";
            cont.text = "持続する";
            cont1.text = "持続する";
            netwarn.text = "接続   故障";

        }
        if (lan == 8)
        {
            //CHINESE
            winlvl.text = "现在，你是迷宫的出";
            time.text = "时钟";
            start.text = "开始";
            map.text = "地图";
            next.text = "接下来迷宫";
            playagin.text = "再玩一遍";
            menu.text = "菜单";
            menu1.text = "菜单";
            menu2.text = "菜单";
            timeup.text = "时间到";
            retry.text = "重试";
            retry1.text = "重试";
            cont.text = "继续";
            cont1.text = "继续";
            netwarn.text = "连接  失败";

        }
        if (lan == 9)
        {
            //KOREAN
            winlvl.text = "지금 당신은 미로의 밖으로";
            time.text = "시계";
            start.text = "스타트";
            map.text = "지도";
            next.text = "다음 미로";
            playagin.text = "다시 재생";
            menu.text = "메뉴";
            menu1.text = "메뉴";
            menu2.text = "메뉴";
            timeup.text = "시간 최대";
            retry.text = "다시 해 보다";
            retry1.text = "다시 해 보다";
            cont.text = "계속하다";
            cont1.text = "계속하다";
            netwarn.text = "연결  실패";

        }

    }


}
