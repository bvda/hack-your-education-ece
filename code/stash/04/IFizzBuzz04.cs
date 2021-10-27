using System.Collections.Generic;

namespace FizzBuzz {
  public interface IFizzBuzz04 {
    IEnumerable<string> Calculate(int start, int end);
    void Print(IEnumerable<string> list);   
    void WriteToFile(IEnumerable<string> list);
  }
}