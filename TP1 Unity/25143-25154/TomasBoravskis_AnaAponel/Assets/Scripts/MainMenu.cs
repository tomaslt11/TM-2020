﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
	{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);	
	}
	   public void SelectLevel()
	{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);	
	}
	
		   public void Level1()
	{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);	
	}
		   public void Level2()
	{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);	
	}
			   public void Back()
	{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);	
	}
	
	public void QuitGame()
	{
		Application.Quit();
	}
}
