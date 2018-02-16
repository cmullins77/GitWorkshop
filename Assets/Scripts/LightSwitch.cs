namespace GitWorkshop {
    using UnityEngine;

    //comment!!!!
    public class LightSwitch : MonoBehaviour {

        public GameObject lightSwitch;

        // Update is called once per frame
        void Update() {
            if (this.lightSwitch != null) {
                if (Input.GetKeyUp(KeyCode.Space))
                    this.lightSwitch.SetActive(!this.lightSwitch.activeSelf);
            }
        }
    }
}
