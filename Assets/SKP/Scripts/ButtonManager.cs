using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ButtonManager : MonoBehaviour
{
    
    public GameObject VideoManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #region Phone
    public void StartVideoPhone()
    {
        VideoManager.GetComponent<VideoManager>().StartVideoPhone();
    }
    public void CorrectAnswerPhone()
    {
        VideoManager.GetComponent<VideoManager>().PlayCorrectVideoPhone();
    }

    public void PlayInBetweenAnswersPhone()
    {
        VideoManager.GetComponent<VideoManager>().PlayInBetweenAnswersPhone();
    }
    public void WrongAnswerPhone()
    {
        VideoManager.GetComponent<VideoManager>().PlayWrongVideoPhone();
    }

    public void FeedBackPhone()
    {
        VideoManager.GetComponent<VideoManager>().FeedBackPhone();
    }
    public void EndScenePhone()
    {
        VideoManager.GetComponent<VideoManager>().EndScene();        
    }
    #endregion
    #region Dummy

    public void StartVideoDummy()
    {
        VideoManager.GetComponent<VideoManager>().StartVideoDummy();
    }
    public void CorrectAnswerDummy()
    {
        VideoManager.GetComponent<VideoManager>().PlayCorrectVideoDummy();
    }

    public void PlayInBetweenAnswersDummy()
    {
        VideoManager.GetComponent<VideoManager>().PlayInBetweenAnswersDummy();
    }
    public void WrongAnswerDummy()
    {
        VideoManager.GetComponent<VideoManager>().PlayWrongVideoDummy();
    }

    public void FeedBackDummy()
    {
        VideoManager.GetComponent<VideoManager>().FeedBackDummy();
    }
    public void EndSceneDummy()
    {
        VideoManager.GetComponent<VideoManager>().EndDummyscene();
    }
    #endregion

    #region Coffee

    public void StartVideoCoffee()
    {
        VideoManager.GetComponent<VideoManager>().StartVideoCoffee();
    }
    public void CorrectAnswerCoffee()
    {
        VideoManager.GetComponent<VideoManager>().PlayCorrectVideoCoffee();
    }

    public void PlayInBetweenAnswersCoffee()
    {
        VideoManager.GetComponent<VideoManager>().PlayInBetweenAnswersCoffee();
    }
    public void WrongAnswerCoffee()
    {
        VideoManager.GetComponent<VideoManager>().PlayWrongVideoCoffee();
    }

    public void FeedBackCoffee()
    {
        VideoManager.GetComponent<VideoManager>().FeedBackCoffee();
    }
    public void EndSceneCoffee()
    {
        VideoManager.GetComponent<VideoManager>().EndCoffeescene();
    }
    #endregion
}
