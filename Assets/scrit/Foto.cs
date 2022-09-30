using System.Collections;
using TMPro;
using UnityEngine;

public class Foto : MonoBehaviour
{
	public TextMeshProUGUI texto;
	public TextMeshProUGUI AndroidPath;
	public GameObject[] UIApp;
	public GameObject FrameVertical;
	public GameObject FrameHorizontal;
	public void SaveImage()
    {
		Debug.Log("started");
		//texto.text = "Started";
		//Apagar todo
		for (int i = 0; i < UIApp.Length; i++)
		{
			UIApp[i].SetActive(false);
		}
		if (Screen.orientation == ScreenOrientation.Portrait)
		{
			FrameVertical.SetActive(true);
		}
		else
		{
			FrameHorizontal.SetActive(true);
		}
		StartCoroutine(TakeScreenshotAndSave());
		//Encender todo
		//texto.text = "Saved";
	}
	private IEnumerator TakeScreenshotAndSave()
	{
		//Esperar un Frame
		Debug.Log("frame");
		yield return new WaitForEndOfFrame();
		//Tomar captura de la pantalla la vuelve una textura y toma dimensiones de pantalla
		Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
		//los convierte en pixeles y luego aplica
		ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
		ss.Apply();

		/*
		Pasa la textura a bytes
		Pasa la textura al folder
		Asigna la textura en bytes con su nombre
		Si se guarda, devuelve la ruta donde se guardó
		 */
		NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(ss, "GalleryTest", "Image.png", (success, path) =>
        {
            Debug.Log("Media save result: " + success + " " + path);
			//AndroidPath.text = path;
        });
		Debug.Log("Permission result: " + permission);

		// To avoid memory leaks
		Destroy(ss);
		for (int i = 0; i < UIApp.Length; i++)
		{
			UIApp[i].SetActive(true);
		}
		FrameHorizontal.SetActive(false);
		FrameVertical.SetActive(false);
		Debug.Log("Desactivando frames");
	}
}
