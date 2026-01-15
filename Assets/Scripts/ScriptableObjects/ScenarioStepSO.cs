using UnityEngine;
using System.Collections.Generic;

namespace FirstAidGame.Scenarios
{
    [CreateAssetMenu(menuName = "FirstAid/Scenario Step")]
    public class ScenarioStepSO : ScriptableObject
    {
        public Sprite sceneImage;
        [TextArea] public string dialogueText;
        public AudioClip voiceClip;
        public AudioClip sfxClip;

        public ScenarioStepSO nextStep;
    }
}