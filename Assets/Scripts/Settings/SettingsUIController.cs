using UnityEngine;
using UnityEngine.UI;
using FirstAidGame.Settings;

namespace FirstAidGame.Settings
{
    public class SettingsUIController : MonoBehaviour
    {
        [Header("UI Elemanlarý")]
        public GameObject settingsPanel;
        public Button btnSettings;
        public Button btnClose;
        public Slider musicSlider;
        public Slider sfxSlider;
        public Button btnTR;
        public Button btnEN;
        
        private void Start()
        {
            if(settingsPanel != null)
                settingsPanel.SetActive(false);

            if(SettingsManager.instance != null)
            {
                musicSlider.value = SettingsManager.instance.MusicVolume;
                sfxSlider.value = SettingsManager.instance.SFXVolume;
            }

            btnTR.onClick.AddListener(() => SettingsManager.instance.SetLanguage("TR"));
            btnEN.onClick.AddListener(() => SettingsManager.instance.SetLanguage("EN"));

            btnClose.onClick.AddListener(() => ClosePanel());
            btnSettings.onClick.AddListener(() => TogglePanel());

            musicSlider.onValueChanged.AddListener(SettingsManager.instance.SetMusicVolume);
            sfxSlider.onValueChanged.AddListener(SettingsManager.instance.SetSFXVolume);
        }

        private void ClosePanel()
        {
            if (settingsPanel != null) settingsPanel.SetActive(false);
        }

        private void TogglePanel()
        {
            if (settingsPanel!= null)
            {
                if (settingsPanel.activeSelf)
                {
                    ClosePanel();
                }
                else
                {
                    settingsPanel.SetActive(true);
                    if (SettingsManager.instance != null)
                    {
                        musicSlider.value = SettingsManager.instance.MusicVolume;
                        sfxSlider.value = SettingsManager.instance.SFXVolume;
                    }
                }         
            }
        }
    }
}