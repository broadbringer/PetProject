# Bini.3rdParty.I2

Changelog
-----------------------------------------------------------------------------------------

### [1.2.0+2.8.13] - 2020-06-03

#### Отключить возврат к предыдущему языку при превью локализации в редакторе (устранение проблемы с постобработкой текстов у Paint Team; [TT-205](https://jira.binibambini.io/browse/TT-205)).

File: LocalizationEditor_Terms_Description.cs  
Class: LocalizationEditor  
Method: OnGUI_Keys_LanguageTranslations, line 439

Changed

From:
```C#
LocalizationManager.PreviewLanguage(PreviousLanguage);
```

To:
```C#
// LocalizationManager.PreviewLanguage(PreviousLanguage);
```