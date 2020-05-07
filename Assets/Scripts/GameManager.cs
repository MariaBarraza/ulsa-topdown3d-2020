using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    [SerializeField]
    Player player;

    bool isInCombat;

    [SerializeField]
    GameAudio gameAudio;


    public Player Player { get => player; }
    public bool IsInCombat { get => isInCombat; set => isInCombat = value;}
    public GameAudio GameAudio { get => gameAudio; }

    void Start()
    {
        gameAudio.Aud = GetComponent<AudioSource>();
        gameAudio.PlayBGMusic();
    }

    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }else{
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void StartCombat()
    {
        player.Anim.SetLayerWeight(1,1);
        player.WeaponVisible(true);
        gameAudio.PlayBattleMusic();
    }
    
    public void StopCombat()
    {
        player.Anim.SetLayerWeight(0,1);
        player.Anim.SetLayerWeight(1,0);
        player.WeaponVisible(false);
        gameAudio.PlayBGMusic();
    }
}
