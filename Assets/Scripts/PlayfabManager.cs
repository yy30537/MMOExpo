using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using Newtonsoft.Json;
using System;
using UnityEngine.SceneManagement;

public class PlayfabManager : MonoBehaviour
{

    [Header("UI")]
    public Text messageText;
    public InputField emailInput;
    public InputField passwordInput;
    public InputField nicknameInput;

    public Button LoginButton;
    public Button RegisterButton;
    public Button ResetPasswordButton;

    public Button ContinueButton;
    public Button QuitButton;

    bool newAccount;

    // Start is called before the first frame update
    void Start()
    {
        LoginButton.gameObject.SetActive(true);
        RegisterButton.gameObject.SetActive(true);
        ResetPasswordButton.gameObject.SetActive(true);

        emailInput.gameObject.SetActive(true);
        passwordInput.gameObject.SetActive(true);

        ContinueButton.gameObject.SetActive(false);
        QuitButton.gameObject.SetActive(true);

        nicknameInput.gameObject.SetActive(false);

        // set login, register, reset buttons listeners
        Button Loginbtn = LoginButton.GetComponent<Button>();
        Loginbtn.onClick.AddListener(LoginButtonFunc);

        Button Registerbtn = RegisterButton.GetComponent<Button>();
        Registerbtn.onClick.AddListener(RegisterButtonFunc);

        Button Resetbtn = ResetPasswordButton.GetComponent<Button>();
        Resetbtn.onClick.AddListener(ResetPasswordButtonFunc);

        Button Continuebtn = ContinueButton.GetComponent<Button>();
        Continuebtn.onClick.AddListener(continueToNextScene);

        Button Quitbtn = QuitButton.GetComponent<Button>();
        Quitbtn.onClick.AddListener(QuitGame);

        newAccount = false;

    }


    public void LoginButtonFunc()
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text
        };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnError);
    }

    void OnLoginSuccess(LoginResult result)
    {
        messageText.text = "Logged In";

        LoginButton.gameObject.SetActive(false);
        RegisterButton.gameObject.SetActive(false);
        ResetPasswordButton.gameObject.SetActive(false);

        emailInput.gameObject.SetActive(false);
        passwordInput.gameObject.SetActive(false);

        ContinueButton.gameObject.SetActive(true);

    }

    public void RegisterButtonFunc()
    {
        if (passwordInput.text.Length < 6)
        {
            messageText.text = "WARNING: Password length less than 6";
            return;
        }


        var request = new RegisterPlayFabUserRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
    }

    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        messageText.text = "Successfully Registered & Logged In";

        LoginButton.gameObject.SetActive(false);
        RegisterButton.gameObject.SetActive(false);
        ResetPasswordButton.gameObject.SetActive(false);

        emailInput.gameObject.SetActive(false);
        passwordInput.gameObject.SetActive(false);

        ContinueButton.gameObject.SetActive(true);

        newAccount = true;
        nicknameInput.gameObject.SetActive(true);


    }

    public void ResetPasswordButtonFunc()
    {
        var request = new SendAccountRecoveryEmailRequest
        {
            Email = emailInput.text,
            TitleId = "81ABC"
        };
        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnPasswordReset, OnError);
    }

    public void OnPasswordReset(SendAccountRecoveryEmailResult result)
    {
        messageText.text = "Password Reset Email Sent";
    }

    private void OnError(PlayFabError error)
    {
        Debug.Log(error.GenerateErrorReport());
        messageText.text = error.ErrorMessage;
    }


    private void continueToNextScene()
    {
        
        if (newAccount == true)
        {
            var request = new UpdateUserTitleDisplayNameRequest
            {
                DisplayName = nicknameInput.text
            };
            PlayFabClientAPI.UpdateUserTitleDisplayName(request, OnNameUpdateSuccess, OnError);
        }

        /*
         * 
         * Load "RegisterScene" with 1 "Select Avatar" (btn to select avatar scene) and 
         *                           2 "Enter World" (btn to ExpoMainScene)
         * 
         * 
         * then do photon things, join lobby connect server and stuff
         * 
         */

        SceneManager.LoadScene("RegisterScene", LoadSceneMode.Single);
    }

    private void OnNameUpdateSuccess(UpdateUserTitleDisplayNameResult result)
    {
        Debug.Log("Updated Display name");
    }

    private void QuitGame()
    {
        Application.Quit();
    }

}
