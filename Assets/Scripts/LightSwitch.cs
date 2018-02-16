namespace GitWorkshop {
    using UnityEngine;

    public class LightSwitch : MonoBehaviour {

        public GameObject gameObj;

        // Update is called once per frame
        void Update() {
            if (this.gameObj != null) {
                if (Input.GetKeyUp(KeyCode.Space))
                    this.gameObj.SetActive(!this.gameObj.activeSelf);
            }
        }
    }
}
