package com.magowie.player;
//�eby nie by�o error�w trzeba zainstalowa� t� wtyczk�: e(fx)clipse 
import java.io.File;
import java.net.MalformedURLException;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.layout.StackPane;
import javafx.scene.media.*;
import javafx.scene.paint.Color;
import javafx.stage.Stage;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;

public class Window extends Application
{
//UTF TEST
//sdjfhjdhfjdhfsłłłóóććóóóćóóśóęęĘĘĘĘĘóÓÓÓÓą
	public Window(String[] args) 
	{
		launch(args);
		// TODO Auto-generated constructor stub
	}
	 public Window() {
	}

	@Override
	public void start(Stage primaryStage) throws Exception {
			//Wiadomo do poprawy, to nie jest obiekt�wka :D
			String filename="../../Piosenki/Kalimba.mp3";
			File file = new File(filename);
			String mediaLocation = file.toURI().toURL().toExternalForm();
		    Media media = new Media(mediaLocation);
		    MediaPlayer mediaPlayer = new MediaPlayer(media);
		    if (mediaPlayer != null) {
		        mediaPlayer.play();
		      }  
		
		  	primaryStage.setTitle("MP3Player!");
	        Button btn = new Button();
	        btn.setText("Stop");
	        btn.setOnAction(new EventHandler<ActionEvent>() {
	 
	            @Override
	            public void handle(ActionEvent event) {
	               // System.out.println("Hello World!");
	            	if(btn.getText()=="Stop")
	            	{
	            	mediaPlayer.pause();
	            	btn.setText("Play");
	            	}
	            	else
	            	{
	            	mediaPlayer.play();
	            	btn.setText("Stop");
	            	}
	            }
	        });
	        
	        StackPane root = new StackPane();
	        root.getChildren().add(btn);
	        primaryStage.setScene(new Scene(root, 300, 250));
	        primaryStage.show();
	}

}