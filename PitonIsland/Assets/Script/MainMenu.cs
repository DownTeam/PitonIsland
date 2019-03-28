using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
 
 //Меню - главное
 public bool PlayGame = false;
 public bool SetsGame = false;
 public bool ExitGame = false;
  
 public Camera Camera1;
 public Camera Camera2;
 
 //Меню - настроек
 public bool BackMenu = false;
 //Графика
 public bool Low = false;
 public bool Medium = false;
 public bool High = false;
 public bool Fantastic = false;
 
 // Use this for initialization
 void Start () {

 }
 
 // Update is called once per frame
 void Update () {
 
 }
 
 void OnMouseEnter() {
  GetComponent<Renderer>().material.color = Color.red;
 }
 
 void OnMouseExit() {
  GetComponent<Renderer>().material.color = Color.white;
 }

 void OnMouseUp() {
 if(PlayGame == true) {
  Application.LoadLevel(1);
 }
 if(SetsGame == true) {
  Camera1.enabled = false;
  Camera2.enabled = true;
 }
 if(ExitGame == true) {
   Application.Quit();
 }
 //===============
 if(BackMenu == true) {
  Camera1.enabled = true;
  Camera2.enabled = false;
 }
 if(Low == true){
  QualitySettings.currentLevel = QualityLevel.Simple;
 }
 if(Medium == true){
  QualitySettings.currentLevel = QualityLevel.Good;
 }
 if(High == true){
  QualitySettings.currentLevel = QualityLevel.Beautiful;
 }
 if(Fantastic == true){
  QualitySettings.currentLevel = QualityLevel.Fantastic;
 }
 //
 if(BackMenu == true) {
  Application.LoadLevel(0);
 }
 }
}﻿