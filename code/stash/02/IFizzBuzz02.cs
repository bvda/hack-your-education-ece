using System.Collections.Generic;

namespace FizzBuzz {
  public interface IFizzBuzz02 {
    IEnumerable<string> Calculate(int start, int end);
    void Print(IEnumerable<string> list);
  }
}