using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;

public class CertificateMenu : EditorWindow{

    public static string SceneFolder = "Assets/Scenes/Game Scenes/";
    public static string CertSceneFolder = "Assets/Scenes/Game Scenes/Certificate Scenes/";
    public static string UnityType = ".unity";
    private const string NameOfMenu = "Audiokinetic";
    private const int priority_gameScenes = 2;
    private const int priority_website = 1337;
    private const int priority_certification = 3;

    [MenuItem(NameOfMenu+"/Website",false, priority_website)]
    public static void OpenScene_AK()
    {
        Application.OpenURL("https://www.audiokinetic.com/");
    }

    [MenuItem(NameOfMenu + "/Certification/Certification Page", false, priority_certification)]
    public static void OpenScene_CertificatePage()
    {
        Application.OpenURL("https://www.audiokinetic.com/");
    }


    [MenuItem(NameOfMenu + "/Game Scenes/Main", false, priority_gameScenes)]
    public static void OpenScene_MainScene()
    {
        EditorSceneManager.OpenScene(SceneFolder+"Main Scene.unity");
    }

    [MenuItem(NameOfMenu + "/Game Scenes/Title Screen", false, priority_gameScenes)]
    public static void OpenScene_TitleScreen()
    {
        EditorSceneManager.OpenScene(SceneFolder + "Title Screen.unity");
    }
    [MenuItem(NameOfMenu + "/Game Scenes/Credits", false, priority_gameScenes)]
    public static void OpenScene_Credits()
    {
        EditorSceneManager.OpenScene(SceneFolder + "Credits.unity");
    }

    ///////////////////////// LESSON SCENES
    [MenuItem(NameOfMenu + "/Certification/251/Lesson 1/Profiler Scene",false, priority_certification)]
    public static void OpenScene_L1_13()
    {
        EditorSceneManager.OpenScene(CertSceneFolder + "Lesson 1.1 - The Profiler"+UnityType);
    }
    [MenuItem(NameOfMenu + "/Certification/251/Lesson 1/Voice Monitor Scene",false, priority_certification)]
    public static void OpenScene_L1_24()
    {
        EditorSceneManager.OpenScene(CertSceneFolder + "Lesson 1.2 - Voice Monitor" + UnityType);
    }

    [MenuItem(NameOfMenu + "/Certification/251/Lesson 2/Main Scene",false, priority_certification)]
    public static void OpenScene_L2_X()
    {
        EditorSceneManager.OpenScene(SceneFolder + "Main Scene" + UnityType);
    }
    [MenuItem(NameOfMenu + "/Certification/251/Lesson 3/Understanding Virtual Voices",false, priority_certification)]
    public static void OpenScene_L3_X()
    {
        EditorSceneManager.OpenScene(CertSceneFolder + "Lesson 3.1 - Understanding Virtual Voices" + UnityType);
    }
    [MenuItem(NameOfMenu + "/Certification/251/Lesson 3/Verify your Virtual Voices",false, priority_certification)]
    public static void OpenScene_L3_2()
    {
        EditorSceneManager.OpenScene(CertSceneFolder + "Lesson 3.2 - Verify your Virtual Voices" + UnityType);
    }
    [MenuItem(NameOfMenu + "/Certification/251/Lesson 3/Mass Evil Head",false, priority_certification)]
    public static void OpenScene_L3_3()
    {
        EditorSceneManager.OpenScene(CertSceneFolder + "Lesson 3.3 - Mass Evil Head" + UnityType);
    }

    [MenuItem(NameOfMenu + "/Certification/251/Lesson 4/Slow Motion",false, priority_certification)]
    public static void OpenScene_L4_2()
    {
        EditorSceneManager.OpenScene(CertSceneFolder + "Lesson 4.2 - Slow Motion" + UnityType);
    }

    [MenuItem(NameOfMenu + "/Certification/251/Lesson 5/Main Scene",false, priority_certification)]
    public static void OpenScene_L5_X()
    {
        EditorSceneManager.OpenScene(SceneFolder + "Main Scene" + UnityType);
    }
    [MenuItem(NameOfMenu + "/Certification/251/Lesson 6/All In One",false, priority_certification)]
    public static void OpenScene_L6_allInOne()
    {
        EditorSceneManager.OpenScene(CertSceneFolder + "Lesson 6.1 - All In One" + UnityType);
    }
    [MenuItem(NameOfMenu + "/Certification/251/Lesson 6/Loading Region SoundBanks",false, priority_certification)]
    public static void OpenScene_L6_LRS()
    {
        EditorSceneManager.OpenScene(CertSceneFolder + "Lesson 6.2 - Loading Region SoundBanks" + UnityType);
    }
    [MenuItem(NameOfMenu + "/Certification/251/Lesson 6/Desert SoundBank Scenes",false,priority_certification)]
    public static void OpenScene_L6_DSS()
    {
        EditorSceneManager.OpenScene(CertSceneFolder + "Lesson 6.3 - Desert Audio Environment" + UnityType);
    }
    [MenuItem(NameOfMenu + "/Certification/251/Lesson 6/Quest SoundBanks",false, priority_certification)]
    public static void OpenScene_L6_QS()
    {
        EditorSceneManager.OpenScene(CertSceneFolder + "Lesson 6.4 - Quest SoundBanks" + UnityType);
    }

    [MenuItem(NameOfMenu + "/Certification/251/Lesson 7/Memory Pools Scene",false, priority_certification)]
    public static void OpenScene_L7_X()
    {
        EditorSceneManager.OpenScene(CertSceneFolder + "Lesson 7.1 - Memory Pool Scene" + UnityType);
    }





}
