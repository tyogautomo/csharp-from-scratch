using System;

namespace controlFlow.Exercise {

  public class challengeThree {

    public int width;
    public int height;

    public string checkImageCategory() {
      string result = width > height ? "Landscape" : "Portrait";
      return result;
    }

  }

}