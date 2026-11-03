# C# Summer Work — Coding Exercises

**A-Level Computer Science | Hills Road Sixth Form College**

This repository contains my three C# programming exercises for the Hills Road A-Level Computer Science summer preparation work.

## Exercises

### 1. Greeting

**Focus:** Output & variables

The program should:

* Print a line of text to the console.
* Create a variable containing my name.
* Use the variable to print a personalised greeting.

**Example output:**

```text
Hello! My name is Sam and I’m starting A-Level Computer Science.
```

**Concepts covered:**

* `Console.WriteLine()`
* `string` variables
* Variables
* Joining text

---

### 2. Mini Calculator

**Focus:** Input & arithmetic

The program should:

1. Ask the user to enter two whole numbers.
2. Read the user's input.
3. Convert the input from text into numbers.
4. Display:

   * Sum
   * Difference
   * Product
   * Quotient as a decimal

**Stretch goal:** Handle division by zero without crashing.

**Concepts covered:**

* `Console.ReadLine()`
* `int.Parse()`
* `Convert.ToInt32()`
* Arithmetic operators
* Integer vs decimal types
* User input

---

### 3. Number Checker & Times Table

**Focus:** Selection & iteration

The program should:

1. Ask the user to enter a whole number.
2. Determine whether the number is:

   * Positive
   * Negative
   * Zero
3. If the number is positive, print its times table from 1 to 12.

**Stretch goal:** Ask the user for a second number and use it to determine how far the times table should go.

**Concepts covered:**

* `if`
* `else if`
* `else`
* `for` loops
* Selection
* Iteration
* User input
* Combining logic with loops

---

## Project Structure

```text
CSharp-Summer-Work/
│
├── README.md
│
├── Exercise1-Greeting/
│   └── Program.cs
│
├── Exercise2-Calculator/
│   └── Program.cs
│
└── Exercise3-NumberChecker/
    └── Program.cs
```

Each exercise is a separate C# Console App, as required by the summer work.

## Environment

* **Language:** C#
* **Framework:** .NET
* **Editor:** Visual Studio Code
* **C# Extension:** C# Dev Kit
* **Operating System:** macOS

## Running an Exercise

Navigate into the relevant exercise folder and run:

```bash
dotnet run
```

For example:

```bash
cd Exercise1-Greeting
dotnet run
```

## Progress

* [ ] Exercise 1 — Greeting
* [ ] Exercise 2 — Mini Calculator
* [ ] Exercise 3 — Number Checker & Times Table
* [ ] Stretch challenges attempted
* [ ] All programs tested successfully
* [ ] Code ready to show at the first lesson

## Learning Goal

The aim of these exercises is not simply to produce working programs. They are intended to practise the fundamental programming concepts used throughout A-Level Computer Science:

**Sequence → Selection → Iteration → Input → Variables → Arithmetic → Debugging**
