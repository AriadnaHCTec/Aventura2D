using System;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;

/*
    Este codigo crea un archivo binario donde se
    alamacenará toda la información requerida del juego
    y no podrá ser modificada por el usuario.

    Autor: Miguel Ángel Pérez López
*/


public class GuardarDatos
{   
    //public string pathJugador = "/" + MenuInicioSesion.instance.nombreUsuario + ".game";

    public static void GuardarInfo(SaludPersonaje sPersonaje){
        string pathRelativo = Application.persistentDataPath + "/usuario.txt";
        string texto = System.IO.File.ReadAllText(pathRelativo);
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/" + texto + ".game";//"/mike.game";
        FileStream stream = new FileStream(path, FileMode.Create);

        Personaje data = new Personaje(sPersonaje);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static Personaje CargarInfo(){
        string pathRelativo = Application.persistentDataPath + "/usuario.txt";
        string texto = System.IO.File.ReadAllText(pathRelativo);
        string path = Application.persistentDataPath + "/" + texto + ".game";
        if(File.Exists(path)){
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Personaje data = formatter.Deserialize(stream) as Personaje;
            stream.Close();
            return data;
        }else{
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
