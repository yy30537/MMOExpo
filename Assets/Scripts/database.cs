using UnityEngine;
using System.Collections;
using UnityEngine.Networking;


public class database : MonoBehaviour 
{
    public static string user = "", name = "";
    private string password = "", rePass = "", message = "";

    private bool register = false;

    private void OnGUI()
    {
        if (message != "")
            GUILayout.Box(message);

        if (register)
        {
            GUILayout.Label("Username");
            user = GUILayout.TextField(user);
            GUILayout.Label("Name");
            name = GUILayout.TextField(name);
            GUILayout.Label("password");
            password = GUILayout.PasswordField(password, "*"[0]);
            GUILayout.Label("Re-password");
            rePass = GUILayout.PasswordField(rePass, "*"[0]);

            GUILayout.BeginHorizontal();
             
            if (GUILayout.Button("Back"))
                register = false;

            if (GUILayout.Button("Register"))
            {
                message = "";

                if (user == "" || name == "" || password == "")
                    message += "Please enter all the fields \n";
                else
                {
                    if (password == rePass)
                    {
                        WWWForm form = new WWWForm();
                        form.AddField("user", user);
                        form.AddField("name", name);
                        form.AddField("password", password);
                        //UnityWebRequest w = new WWW("https://osummoexpo.mygamesonline.org/register.php", form);

                        UnityWebRequest w  = UnityWebRequest.Post("https://osummoexpo.mygamesonline.org/register.php", form);

                        // exmaple http://osummoexpo.mygamesonline.org/register.php?user=abcd&name=yang1&password=123451

                        //StartCoroutine(registerFunc(w));
                    }
                    else
                        message += "Your Password does not match \n";
                }
            }

            GUILayout.EndHorizontal();
        }

        /*
        else
        {
            GUILayout.Label("User:");
            user = GUILayout.TextField(user);
            GUILayout.Label("Password:");
            password = GUILayout.PasswordField(password, "*"[0]);

            GUILayout.BeginHorizontal();

            if (GUILayout.Button("Login"))
            {
                message = "";

                if (user == "" || password == "")
                    message += "Please enter all the fields \n";
                else
                {
                    WWWForm form = new WWWForm();
                    form.AddField("user", user);
                    form.AddField("password", password);
                    WWW w = new WWW("https://osummoexpo.mygamesonline.org/login.php", form);
                    //StartCoroutine(loginFunc(w));
                }
            }

            if (GUILayout.Button("Register"))
                register = true;

            GUILayout.EndHorizontal();
        }
        */
    }

    /*
    IEnumerator loginFunc(UnityWebRequest w)
    {
        yield return w;
        if (w.error == null)
        {
            if (w.text == "login-SUCCESS")
            {
                print("WOOOOOOOOOOOOOOO!");
            }
            else
                message += w.text;
        }
        else
        {
            message += "In database.cs LoginFunc(WWW w)  - ERROR: " + w.error + "\n";
        }
    }

    IEnumerator registerFunc(UnityWebRequest w)
    {
        yield return w;
        if (w.error == null)
        {
            message += w.text;
        }
        else
        {
            message += "In database.cs registerFunc(WWW w)  - ERROR: " + w.error + "\n";
        }
    }
    */
}
