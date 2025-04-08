using BeatSaberMarkupLanguage.Components;
using BeatSaberMarkupLanguage.GameplaySetup;
using BeatSaberMarkupLanguage.Settings;
using BeatSaberMarkupLanguage.Util;
using UnityEngine;

namespace ChzzkChat.UI
{
    internal class UIManager : MainMenuAwaiter
    {
        public static UIManager Instance = new UIManager();

        private SettingsController SettingsMenuInstance { get;} = new SettingsController();
        public LeftPanelController LeftPanelControllerInstance { get;} = new LeftPanelController();

        public void AddSettingsMenu() => BSMLSettings.Instance?.AddSettingsMenu(nameof(ChzzkChat), "ChzzkChat.UI.settings.bsml", SettingsMenuInstance);
        public void AddLeftPanel() => GameplaySetup.Instance?.AddTab(nameof(ChzzkChat), "ChzzkChat.UI.leftPanel.bsml", LeftPanelControllerInstance);

        public void RemoveSettingsMenu() => BSMLSettings.Instance?.RemoveSettingsMenu(SettingsMenuInstance);
        public void RemoveLeftPanel() => GameplaySetup.Instance?.RemoveTab(nameof(ChzzkChat));

        public void UpdateList() => LeftPanelControllerInstance?.ListUpdate();
    }
    
}
