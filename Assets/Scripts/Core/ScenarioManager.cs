using UnityEngine;
using UnityEngine.UI;
using FirstAidGame.Scenarios;
using FirstAidGame.Audio;
using TMPro;
using System.Collections.Generic;

namespace FirstAidGame.Core
{
    public class ScenarioManager : MonoBehaviour
    {
        [Header("UI Connections")]
        public Image backgroundImage;
        public TextMeshProUGUI storyText;
        public Button prevButton;
        public Button nextButton;

        [Header("Starting Scene")]
        public ScenarioStepSO firstScene;
        private ScenarioStepSO currentScene;
        private Stack<ScenarioStepSO> pastScenes = new Stack<ScenarioStepSO>();

        private void Start()
        {
            if (nextButton != null)
                nextButton.onClick.AddListener(GoToNextStep);

            if (prevButton != null)
                prevButton.onClick.AddListener(GoToPrevStep);

            if (firstScene != null)
            {
                if (prevButton != null) prevButton.gameObject.SetActive(false);

                LoadScene(firstScene);
            }
        }

        public void LoadScene(ScenarioStepSO scene)
        {
            currentScene = scene;

            if (scene.sceneImage != null)
                backgroundImage.sprite = scene.sceneImage;
            
            if (storyText != null)
                storyText.text = scene.dialogueText;

            if (AudioManager.instance != null)
            {
                if (scene.voiceClip != null)
                    AudioManager.instance.PlayVoice(scene.voiceClip);

                if (scene.sfxClip != null)
                    AudioManager.instance.PlaySFX(scene.sfxClip);
            }
        }

        public void GoToPrevStep()
        {
            if (pastScenes.Count > 0)
            {
                ScenarioStepSO previousScene = pastScenes.Pop();
                LoadScene(previousScene);

                if (pastScenes.Count == 0 && prevButton != null)
                {
                    prevButton.gameObject.SetActive(false);
                }
            }
        }

        public void GoToNextStep()
        {
            if (currentScene != null && currentScene.nextStep != null)
            {
                pastScenes.Push(currentScene);
                if (prevButton != null) prevButton.gameObject.SetActive(true);
                LoadScene(currentScene.nextStep);
            }
            else
            {
                Debug.Log("End of scenario");
            }
        }
    }
}