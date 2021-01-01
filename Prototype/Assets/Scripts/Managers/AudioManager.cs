using ProjectCondensed.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace ProjectCondensed.Managers
{
    public class AudioManager : MonoBehaviour
    {
        #region Singleton
        public static AudioManager singleton;
        private void Awake()
        {
            if (singleton == null)
            {
                singleton = this;
            }
        }
        #endregion

        [SerializeField] private List<SoundEffect> SoundEffects = new List<SoundEffect>();
        private AudioSource source;

        private void Start()
        {
            source = GetComponent<AudioSource>();
        }

        public static void PlaySoundEffect(string ID)
        {
            AudioSource _source = singleton.source;
            SoundEffect _sfx = GetSoundEffect(ID);
            _source.PlayOneShot(_sfx.clip, _sfx.volume);
        }

        public static SoundEffect GetSoundEffect(string ID)
        {
            SoundEffect sfx = new SoundEffect();
            List<SoundEffect> SoundEffectList = singleton.SoundEffects;
            for (int i = 0; i < SoundEffectList.Count; i++)
            {
                if (SoundEffectList[i].ID == ID)
                {
                    sfx = SoundEffectList[i];
                }
            }
            return sfx;
        }
    }
}

namespace ProjectCondensed.Data
{
    [System.Serializable]
    public struct SoundEffect
    {
        public string ID;
        public AudioClip clip;
        public float volume;
    }
}