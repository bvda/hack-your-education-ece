<!-- .slide: data-background="#003d73" -->
## Problem solving + Basic skills

![AU Logo](./../img/HACK_LOGO.png "AU Logo") <!-- .element style="width: 200px; position: fixed; bottom: 50px; left: 50px" -->

----

### What to do from here on out?

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
* Sofware design
* Data structures

----

### Learn you editor?

* Shortcuts ([VS Code](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-windows.pdf), [VS 2019](https://visualstudiomagazine.com/articles/2019/06/06/visual-studio-productivity.aspx), [Rider](https://www.jetbrains.com/help/rider/mastering_keyboard_shortcuts.html))
* Views
* Plugins / extensions

----

### Toolchains

* Do you use any other tools?
    * Cross compiling, linting, obfuscating, etc.?
    * Are errors comming from these?

TODO: example with JS/reveal and cross compiling to multiple device/embedded device


----

### What is good code?

* Correct indention?
* Readability?
* Cohesion and coupling
* 

----

### When is it good enough?

* Does it work?
* Any known bugs?
* TODO: 

---

## Problem solving

* _Always_ have a plan
* Restate problem
* Divide the problem
* Start with what you know
* Reduce the problem

---

## Lets slice an elephant

![Slicing](./img/meat.jpg "Meat slicer") <!-- .element style="width: 400px" -->

----

### User stories

We will use this definition:

**Story**: vertical, testable, user valued.

* Vertical: Cut accross multiple layers in architectual layers
* Testable: Should be test either by code or manually
* User valued: Should bring value to end user.

----

### User story - how big?

From minutes to months.

----

### Why small stories?

* Problem is divided into smaller sections
* Easier to make a plan
* Easier to find simular parts
* Easier to recognise known parts

---

### Exercise

* Divide into 2-3 persons groups
    * Try meeting new people
* 15 breaking down problem into user stories
* If time allows
    * Start implementing in 8 minute development sprints

----

### Product

#### User input:
* How many items
* Price per item
* 2-letter state code

#### Output:
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