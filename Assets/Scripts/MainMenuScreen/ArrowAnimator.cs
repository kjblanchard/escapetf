using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ArrowAnimator : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text textToModify;

    private readonly string arrowString = "-->";
    
    // Start is called before the first frame update
    void Start()
    {
        textToModify.text = "";
        StartCoroutine(DrawArrowCo());
    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator DrawArrowCo()
    {
        textToModify.text = DetermineWhatToDisplay();
        yield return new WaitForSeconds(1);
        StartCoroutine(DrawArrowCo());
    }

    private string DetermineWhatToDisplay()
    {
        var currentString = textToModify.text;
        if (textToModify.text.Length == arrowString.Length)
            return "";
        return arrowString.Substring(0, textToModify.text.Length + 1);
    }
}
