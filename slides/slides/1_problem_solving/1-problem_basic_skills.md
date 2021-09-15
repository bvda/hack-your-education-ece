<!-- .slide: data-background="#003d73" -->
## Problem solving + Basic skills

![AU Logo](./../img/HACK_LOGO.png "AU Logo") <!-- .element style="width: 200px; position: fixed; bottom: 50px; left: 50px" -->

----

### What to do from here on out?


TODO: something
<!-- This first workshop will focus on problem-solving and basic skills. Here we will help you break down projects into small manageable tasks, helping you to spend your time wisely. This workshop will serve as the foundation for the rest of the workshops. -->

<!--
Problemløsning
  Hvordan går man igang med en opgave
Grundlæggende færdigheder
  Opsætning og konfiguration af toolchains
  Opsætning og konfiguration af editors
  Hvad er god kode?
  Hvornår er noget godt nok?
  RTFM
-->


---

## Basic skills

* Programing language
  * control flow, function/methods
* Data structures
  * List, queue, stack, tree
* Sofware design / Architecture

----

### Learn you editor?

* Shortcuts ([VS Code](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-windows.pdf), [VS 2019](https://visualstudiomagazine.com/articles/2019/06/06/visual-studio-productivity.aspx), [Rider](https://www.jetbrains.com/help/rider/mastering_keyboard_shortcuts.html))
* Views
* Plugins / extensions

----

#### C#

* Visual Studio does everything
* Command line (CMD) compiling
  * .Net Core: `dotnet build`
  * .Net: `csc.exe`

----

#### Javascript

* Javascript files can be 'executed' directly in browser.
* Typescript (Superset of Javascript)
  * Must be transpiled to Javascript
* Tool chain tools e.g. Gulp

```javascript
gulp.task('serve', () => {
    connect.server({
      root: root, port: port,
      host: '0.0.0.0', livereload: true
    })

    gulp.watch(['*.html', '*.md'], gulp.series('reload'))
    ...
```
<!-- .element: class="fragment" data-fragment-index="1" -->

----

### Toolchains

* Do you use any other tools?
    * Cross compiling, linting, obfuscating, etc.?
    * Are errors comming from these?

----

### What is good code?

* Correct indention
* Readability
* Cohesion and coupling

----

```csharp
public class TennisGame3 : ITennisGame {
  private int p2; private int p1;
  private string p1N; private string p2N;

  public TennisGame3(string player1Name, string player2Name) {
    this.p1N = player1Name;
    this.p2N = player2Name;
  }

  public string GetScore() {
    string s;
    if ((p1 < 4 && p2 < 4) && (p1 + p2 < 6)) {
      string[] p = { "Love", "Fifteen", "Thirty", "Forty" };
      s = p[p1];
      return (p1 == p2) ? s + "-All" : s + "-" + p[p2];
    }
    else {
      if (p1 == p2)
        return "Deuce";
      s = p1 > p2 ? p1N : p2N;
      return ((p1 - p2) * (p1 - p2) == 1) ? "Advantage " + s : "Win for " + s;
    }
  }
  public void WonPoint(string playerName) {
    if (playerName == "player1")
      this.p1 += 1;
    else
      this.p2 += 1;
  }
}
```


----

### When is it good enough?

* Does it solve the problem?
  * Look at problem statement / exercise desciption
* Any known bugs? <!-- .element: class="fragment" data-fragment-index="1" -->
  * Small cosmetic errors?
  * Big functional errors?
* Do you know how to solve these? <!-- .element: class="fragment" data-fragment-index="2" -->

TODO: 

---

## Problem solving

* _Always_ have a plan
* Restate problem
* Divide the problem
* Start with what you know
* Reduce the problem

----

TODO: Example on problem solving

---

## Lets slice an elephant

![Slicing](./img/meat.jpg "Meat slicer") <!-- .element style="width: 400px" -->

----

### User stories

We will use this definition:

**User story**: vertical, testable, user valued.


----

### User stories

* Vertical:
  * Cut accross multiple layers in architectual layers
* Testable:
  * Should be testable either by code or manually
* User valued:
  * Should bring value to end user.

----

### User stories examples

* Removing `Console.WriteLine("Hello World")`? 
* Adding a button to UI?<!-- .element: class="fragment" -->
* Setting up project architecture? <!-- .element: class="fragment" -->

----

### User story size

* Effort
* Complexity
* Unknowns

----

### User story - how big?

From minutes to months.

![https://media.giphy.com/media/3xz2BXmsnwlfAyuJGM/giphy.gif](https://media.giphy.com/media/3xz2BXmsnwlfAyuJGM/giphy.gif)

----

### Why small stories?

* Problem is divided into smaller sections
* Easier to make a plan
* Easier to recognise known parts

---

### Exercise

* Divide into 2-3 persons groups
    * Try meeting new people :-)
* 15 min for breaking down problem into user stories
* If time allows
    * Start implementing in 8 minute development sprints

----

### Product

* **User input:**
  * How many items
  * Price per item
  * 2-letter state code
* **Output:**
  * Total price
      * Discount based on total price
      * Add state tax based on state and discounted price

----

| Order value | Discount rate| * | State | Tax Rate |
| ---- | ---- | ---- | ---- | ---- |
| 1.000 | 3% | * | UT | 6.85% |
| 5.000 | 5% | * | NV | 8.00% |
| 7.000 | 7% | * | TX | 6.25% |
| 10.000 | 10% | * | AL | 4.00% |
| 50.000 | 15% | * | CA | 8.25% |

---

## Reference

* Hackers guide
* 
TODO: