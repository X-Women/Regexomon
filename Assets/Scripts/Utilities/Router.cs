﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;  //allows us to interact with the database

public class Router : MonoBehaviour {

    private static DatabaseReference baseRef = FirebaseDatabase.DefaultInstance.RootReference;

    public static DatabaseReference Questions() {
        return baseRef.Child("Level1-Questions");
    }
    public static DatabaseReference Question(string questId) {
        return baseRef.Child("Level1-Questions").Child(questId);
    }
}