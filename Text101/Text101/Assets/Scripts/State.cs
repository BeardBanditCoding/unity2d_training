using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

    // 14 determines the min size of our field 
    // 10 is the min lines before scroll
   [TextArea(10,14)] [SerializeField] string storyText;
   [SerializeField] State[] nextStates;

    public string GetStateStory() {
        return storyText;
    }

    public State[] GetNextStates() {

        return nextStates;

    }


}
