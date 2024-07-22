using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayFabManager : MonoBehaviour
{
    public InputField SEmailIP, SPasswordIP, SConformPasswordIP, SUsername;
    public InputField LUsername, LPasswordIP;
    public InputField REmailIP;
    public GameObject LoginPage, SignInPage, ForgotPasswordPage, ErrorPage, Animation;
    public Text ErrorTitle, ErrorBody;


    public void OpenLoginPage()
    {
        LoginPage.SetActive(true);
        SignInPage.SetActive(false);
        ForgotPasswordPage.SetActive(false);
    }
    public void OpenSignInPage()
    {
        LoginPage.SetActive(false);
        SignInPage.SetActive(true);
        ForgotPasswordPage.SetActive(false);
    }
    
    public void OpenForgotPasswordPage()
    {
        LoginPage.SetActive(false);
        SignInPage.SetActive(false);
        ForgotPasswordPage.SetActive(true);
    }
    public void showError(string t, string m)
    {
        ErrorTitle.text = "" + t;
        ErrorBody.text = "" + m;

        ErrorPage.SetActive(true);
    }



    public void RegisterButton()
    {
        if (SPasswordIP.text == SConformPasswordIP.text)
        {
            var request = new RegisterPlayFabUserRequest
            {
                Username = SUsername.text,
                Email = SEmailIP.text,
                Password = SPasswordIP.text
            };
            PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
        }
        else
        {
            showError("Error", "Password amd confirm password shall match!!!!!");
        }
    }
    public void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        showError("Success", "Login Successful");
    }





    public void LoginButton()
    {
        var request = new LoginWithPlayFabRequest()
        {
            Username = LUsername.text,
            Password = LPasswordIP.text
        };
        PlayFabClientAPI.LoginWithPlayFab(request, OnLoginSuccess, OnError);
    }

    public void OnLoginSuccess(LoginResult result)
    {
        showError("Success", "Login Successful");
        SceneManager.LoadScene("Loding");
    }




    public void ResetPasswordButton()
    {
        var request = new SendAccountRecoveryEmailRequest()
        {
            Email = REmailIP.text,
            TitleId = "CD1D7"
        };
        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnPasswordReset, OnError);
    }

    void OnPasswordReset(SendAccountRecoveryEmailResult result)
    {
        showError("Reset", "Password Reset Email Sent!");
    }




    public void close()
    {
        ErrorPage.SetActive(false);
    }




    void OnError(PlayFabError error)
    {
        Debug.Log("Error While Logging In/Creating Login!");
        Debug.Log(error.GenerateErrorReport());
        showError("Error While Logging In/Creating Login!", error.GenerateErrorReport());
    }
}