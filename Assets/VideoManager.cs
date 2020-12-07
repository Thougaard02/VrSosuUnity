using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour, OVRGrabber.IPickedUp
{
    public List<VideoClip> videos = null;
    public GameObject envoirment;
    public GameObject OptionCanvasPhone;
    public GameObject InfomationCanvasPhone;

    public GameObject OptionCanvasDummy;
    public GameObject InfomationCanvasDummy;

    public GameObject OptionCanvasCoffee;
    public GameObject InfomationCanvasCoffee;


    public GameObject FeedBackCorrectAnswer;
    public GameObject FeedBackInBetweenAnswer;
    public GameObject FeedBackWrongAnswer;

    public GameObject FeedBackCorrectAnswerDummy;
    public GameObject FeedBackInBetweenAnswerDummy;
    public GameObject FeedBackWrongAnswerDummy;

    public GameObject FeedBackCorrectAnswerCoffee;
    public GameObject FeedBackInBetweenAnswerCoffee;
    public GameObject FeedBackWrongAnswerCoffee;

    public GameObject Laser;

    //private int index = 0;
    private VideoPlayer videoPlayer = null;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    void Start()
    {
        OVRGrabber.PickUpManager.AddLisinger(this);
    }
    #region Phone Pick Up

    //Scene 1 Phone Pick Up
    public void PickedUpPhone(GameObject gameObject)
    {
    }
    #region Scene 1
    #region Start Scene 1

    //Scene 1.
    //Playes the into video
    public void StartVideoPhone()
    {
        //Turn off infomationcanvas
        InfomationCanvasPhone.SetActive(false);

        //Selects video 0 in videoManager
        videoPlayer.clip = videos[0];

        //Playes the video
        videoPlayer.Play();

        //Starts coroutine
        StartCoroutine(WaitSecondPhone());
    }
    private IEnumerator WaitSecondPhone()
    {
        //Waits 3 seconds
        yield return new WaitForSeconds(10);

        //Activates optionCanvasPhone
        OptionCanvasPhone.SetActive(true);

        //Stops video
        videoPlayer.Stop();
    }
    #endregion

    #region Correct Answer Phone

    //Playes the correct video, when the canvas is selected
    public void PlayCorrectVideoPhone()
    {
        //Turn off OptionCanvasPhone
        OptionCanvasPhone.SetActive(false);

        //Selects video 1 in videoManager
        videoPlayer.clip = videos[1];

        //Playes the video 1.
        videoPlayer.Play();

        //Starts Coroutine
        StartCoroutine(WaitSecondCorrectAnswer());
    }
    private IEnumerator WaitSecondCorrectAnswer()
    {
        //Waits 3 seconds
        yield return new WaitForSeconds(5);

        //Activates FeedbackCorrect Answer 
        FeedBackCorrectAnswer.SetActive(true);

        //Stops the video
        videoPlayer.Stop();
    }
    #endregion
    #region In Between Answer Phone

    public void PlayInBetweenAnswersPhone()
    {
        //Turn off OptionCanvasPhone
        OptionCanvasPhone.SetActive(false);

        //Selects video 1 in videoManager
        videoPlayer.clip = videos[2];

        //Playes the video 1.
        videoPlayer.Play();

        //Starts Coroutine
        StartCoroutine(WaitSecondInBetweenAnswerPhone());
    }

    private IEnumerator WaitSecondInBetweenAnswerPhone()
    {
        //Waits 3 seconds
        yield return new WaitForSeconds(10);

        //Activates FeedbackCorrect Answer 
        FeedBackInBetweenAnswer.SetActive(true);

        //Stops the video
        videoPlayer.Stop();
    }
    #endregion

    #region Wrong Answer Phone

    public void PlayWrongVideoPhone()
    {
        //Turn off OptionCanvasPhone
        OptionCanvasPhone.SetActive(false);

        //Selects video 1 in videoManager
        videoPlayer.clip = videos[3];

        //Playes the video 1.
        videoPlayer.Play();

        //Starts Coroutine
        StartCoroutine(WaitSecondWrongPhone());
    }

    private IEnumerator WaitSecondWrongPhone()
    {
        //Waits 3 seconds
        yield return new WaitForSeconds(10);

        //Activates FeedbackCorrect Answer 
        FeedBackWrongAnswer.SetActive(true);

        //Stops the video
        videoPlayer.Stop();
    }
    #endregion
    #region EndPhoneScene
    //Ends the scene 1

    public void EndScene()
    {
        MeshRenderer[] meshes = envoirment.GetComponentsInChildren<MeshRenderer>();
        SkinnedMeshRenderer[] skinnedMeshes = envoirment.GetComponentsInChildren<SkinnedMeshRenderer>();

        //Actives MeshRenderer
        foreach (MeshRenderer item in meshes)
        {
            item.enabled = true;
        }
        //Actives SkinnedMeshRenderer
        foreach (SkinnedMeshRenderer item in skinnedMeshes)
        {
            item.enabled = true;
        }
        //Turn of laser
        Laser.SetActive(false);
        //Turn off Feedbackcorrectanswer
        FeedBackCorrectAnswer.SetActive(false);
    }
    #endregion
    #region FeedBackPhone

    public void FeedBackPhone()
    {
        OptionCanvasPhone.SetActive(true);
        FeedBackInBetweenAnswer.SetActive(false);
        FeedBackWrongAnswer.SetActive(false);
    }
    #endregion
    #endregion

    #endregion

    #region Dummy Pick Up

    //Scene 2 Dummy Pick Up
    public void PickedUpDummy(GameObject gameObject)
    {
    }
    #region Scene 2
    #region Start Scene 2

    //Scene 2.
    //Playes the into video
    public void StartVideoDummy()
    {
        //Turn off infomationcanvas
        InfomationCanvasDummy.SetActive(false);

        //Selects video 0 in videoManager
        videoPlayer.clip = videos[0];

        //Playes the video
        videoPlayer.Play();

        //Starts coroutine
        StartCoroutine(WaitSecondDummy());
    }
    private IEnumerator WaitSecondDummy()
    {
        //Waits 3 seconds
        yield return new WaitForSeconds(3);

        //Activates optionCanvasPhone
        OptionCanvasDummy.SetActive(true);

        //Stops video
        videoPlayer.Stop();
    }
    #endregion

    #region Correct Answer Dummy

    //Playes the correct video, when the canvas is selected
    public void PlayCorrectVideoDummy()
    {
        //Turn off OptionCanvasPhone
        OptionCanvasDummy.SetActive(false);

        //Selects video 1 in videoManager
        videoPlayer.clip = videos[0];

        //Playes the video 1.
        videoPlayer.Play();

        //Starts Coroutine
        StartCoroutine(WaitSecondCorrectAnswerDummy());
    }
    private IEnumerator WaitSecondCorrectAnswerDummy()
    {
        //Waits 3 seconds
        yield return new WaitForSeconds(3);

        //Activates FeedbackCorrect Answer 
        FeedBackCorrectAnswerDummy.SetActive(true);

        //Stops the video
        videoPlayer.Stop();
    }
    #endregion
    #region In Between Answer Phone

    public void PlayInBetweenAnswersDummy()
    {
        //Turn off OptionCanvasPhone
        OptionCanvasDummy.SetActive(false);

        //Selects video 1 in videoManager
        videoPlayer.clip = videos[1];

        //Playes the video 1.
        videoPlayer.Play();

        //Starts Coroutine
        StartCoroutine(WaitSecondInBetweenAnswerDummy());
    }

    private IEnumerator WaitSecondInBetweenAnswerDummy()
    {
        //Waits 3 seconds
        yield return new WaitForSeconds(3);

        //Activates FeedbackCorrect Answer 
        FeedBackInBetweenAnswerDummy.SetActive(true);

        //Stops the video
        videoPlayer.Stop();
    }
    #endregion

    #region Wrong Answer Dummy

    public void PlayWrongVideoDummy()
    {
        //Turn off OptionCanvasPhone
        OptionCanvasDummy.SetActive(false);

        //Selects video 1 in videoManager
        videoPlayer.clip = videos[2];

        //Playes the video 1.
        videoPlayer.Play();

        //Starts Coroutine
        StartCoroutine(WaitSecondWrongDummy());
    }

    private IEnumerator WaitSecondWrongDummy()
    {
        //Waits 3 seconds
        yield return new WaitForSeconds(3);

        //Activates FeedbackCorrect Answer 
        FeedBackWrongAnswerDummy.SetActive(true);

        //Stops the video
        videoPlayer.Stop();
    }
    #endregion
    #region EndDummyScene
    //Ends the scene 1

    public void EndDummyscene()
    {
        MeshRenderer[] meshes = envoirment.GetComponentsInChildren<MeshRenderer>();
        SkinnedMeshRenderer[] skinnedMeshes = envoirment.GetComponentsInChildren<SkinnedMeshRenderer>();

        //Actives MeshRenderer
        foreach (MeshRenderer item in meshes)
        {
            item.enabled = true;
        }
        //Actives SkinnedMeshRenderer
        foreach (SkinnedMeshRenderer item in skinnedMeshes)
        {
            item.enabled = true;
        }
        //Turn of laser
        Laser.SetActive(false);
        //Turn off Feedbackcorrectanswer
        FeedBackCorrectAnswerDummy.SetActive(false);
    }
    #endregion
    #region FeedBackDummy

    public void FeedBackDummy()
    {
        OptionCanvasDummy.SetActive(true);
        FeedBackInBetweenAnswerDummy.SetActive(false);
        FeedBackWrongAnswerDummy.SetActive(false);
    }
    #endregion
    #endregion
    #endregion

    #region Coffee Pick Up

    //Scene 2 Cofffee Pick Up
    public void PickedUpCoffee(GameObject gameObject)
    {
    }
    #region Scene 3
    #region Start Scene 3

    //Scene 2.
    //Playes the into video
    public void StartVideoCoffee()
    {
        //Turn off infomationcanvas
        InfomationCanvasCoffee.SetActive(false);

        //Selects video 0 in videoManager
        videoPlayer.clip = videos[0];

        //Playes the video
        videoPlayer.Play();

        //Starts coroutine
        StartCoroutine(WaitSecondCoffee());
    }
    private IEnumerator WaitSecondCoffee()
    {
        //Waits 3 seconds
        yield return new WaitForSeconds(3);

        //Activates optionCanvasPhone
        OptionCanvasCoffee.SetActive(true);

        //Stops video
        videoPlayer.Stop();
    }
    #endregion

    #region Correct Answer Coffee

    //Playes the correct video, when the canvas is selected
    public void PlayCorrectVideoCoffee()
    {
        //Turn off OptionCanvasPhone
        OptionCanvasCoffee.SetActive(false);

        //Selects video 1 in videoManager
        videoPlayer.clip = videos[0];

        //Playes the video 1.
        videoPlayer.Play();

        //Starts Coroutine
        StartCoroutine(WaitSecondCorrectAnswerCoffee());
    }
    private IEnumerator WaitSecondCorrectAnswerCoffee()
    {
        //Waits 3 seconds
        yield return new WaitForSeconds(3);

        //Activates FeedbackCorrect Answer 
        FeedBackCorrectAnswerCoffee.SetActive(true);

        //Stops the video
        videoPlayer.Stop();
    }
    #endregion
    #region In Between Answer Coffee

    public void PlayInBetweenAnswersCoffee()
    {
        //Turn off OptionCanvasCoffee
        OptionCanvasCoffee.SetActive(false);

        //Selects video 1 in videoManager
        videoPlayer.clip = videos[1];

        //Playes the video 1.
        videoPlayer.Play();

        //Starts Coroutine
        StartCoroutine(WaitSecondInBetweenAnswerCoffee());
    }

    private IEnumerator WaitSecondInBetweenAnswerCoffee()
    {
        //Waits 3 seconds
        yield return new WaitForSeconds(3);

        //Activates FeedbackCorrect Answer 
        FeedBackInBetweenAnswerCoffee.SetActive(true);

        //Stops the video
        videoPlayer.Stop();
    }
    #endregion

    #region Wrong Answer Coffee

    public void PlayWrongVideoCoffee()
    {
        //Turn off OptionCanvasCoffee
        OptionCanvasCoffee.SetActive(false);

        //Selects video 1 in videoManager
        videoPlayer.clip = videos[2];

        //Playes the video 1.
        videoPlayer.Play();

        //Starts Coroutine
        StartCoroutine(WaitSecondWrongCoffee());
    }

    private IEnumerator WaitSecondWrongCoffee()
    {
        //Waits 3 seconds
        yield return new WaitForSeconds(3);

        //Activates FeedbackCorrect Answer 
        FeedBackWrongAnswerCoffee.SetActive(true);

        //Stops the video
        videoPlayer.Stop();
    }
    #endregion
    #region EndCoffeeScene
    //Ends the scene 3

    public void EndCoffeescene()
    {
        MeshRenderer[] meshes = envoirment.GetComponentsInChildren<MeshRenderer>();
        SkinnedMeshRenderer[] skinnedMeshes = envoirment.GetComponentsInChildren<SkinnedMeshRenderer>();

        //Actives MeshRenderer
        foreach (MeshRenderer item in meshes)
        {
            item.enabled = true;
        }
        //Actives SkinnedMeshRenderer
        foreach (SkinnedMeshRenderer item in skinnedMeshes)
        {
            item.enabled = true;
        }
        //Turn of laser
        Laser.SetActive(false);
        //Turn off Feedbackcorrectanswer
        FeedBackCorrectAnswerCoffee.SetActive(false);
    }
    #endregion
    #region FeedBackCoffee

    public void FeedBackCoffee()
    {
        OptionCanvasCoffee.SetActive(true);
        FeedBackInBetweenAnswerCoffee.SetActive(false);
        FeedBackWrongAnswerCoffee.SetActive(false);
    }
    #endregion
    #endregion
    #endregion

    public void PickedUp(GameObject _gameObject)
    {
        if (_gameObject.GetComponent<NameOfObject>().ObjectName == "Phone")
        {
            //Phone
            MeshRenderer[] meshes = envoirment.GetComponentsInChildren<MeshRenderer>();
            SkinnedMeshRenderer[] skinnedMeshes = envoirment.GetComponentsInChildren<SkinnedMeshRenderer>();


            foreach (MeshRenderer item in meshes)
            {
                item.enabled = false;
            }
            foreach (SkinnedMeshRenderer item in skinnedMeshes)
            {
                item.enabled = false;
            }
            Laser.SetActive(true);
            InfomationCanvasPhone.SetActive(true);
        }
        else if (_gameObject.GetComponent<NameOfObject>().ObjectName == "Dummy")
        {
            //Dummy
            MeshRenderer[] meshes = envoirment.GetComponentsInChildren<MeshRenderer>();
            SkinnedMeshRenderer[] skinnedMeshes = envoirment.GetComponentsInChildren<SkinnedMeshRenderer>();

            foreach (MeshRenderer item in meshes)
            {
                item.enabled = false;
            }
            foreach (SkinnedMeshRenderer item in skinnedMeshes)
            {
                item.enabled = false;
            }
            Laser.SetActive(true);
            InfomationCanvasDummy.SetActive(true);

        }
        else if (_gameObject.GetComponent<NameOfObject>().ObjectName == "Coffee")
        {
            //Coffee
            MeshRenderer[] meshes = envoirment.GetComponentsInChildren<MeshRenderer>();
            SkinnedMeshRenderer[] skinnedMeshes = envoirment.GetComponentsInChildren<SkinnedMeshRenderer>();

            foreach (MeshRenderer item in meshes)
            {
                item.enabled = false;
            }
            foreach (SkinnedMeshRenderer item in skinnedMeshes)
            {
                item.enabled = false;
            }
            Laser.SetActive(true);
            InfomationCanvasCoffee.SetActive(true);
        }
    }
}