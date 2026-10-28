# Object-Oriented Programming (OOP) Portfolio
**A Persona 5-Themed VB.NET Application**

![VB.NET](https://img.shields.io/badge/Language-VB.NET-00599C?style=for-the-badge&logo=visualstudio&logoColor=white)
![Framework](https://img.shields.io/badge/Framework-.NET%20Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)

---

## Project Overview

This repository contains a comprehensive academic portfolio developed for an Object-Oriented Programming (OOP) coursework. Moving beyond traditional, disconnected console applications, this project consolidates a full semester of weekly programming lessons into a unified desktop client. 

To demonstrate proficiency in custom UI/UX engineering within the constraints of Windows Forms, the entire application is styled with a high-contrast, dynamic aesthetic inspired by the user interface of the game *Persona 5*.

## Key Features

* **Weekly Lesson Modules**: Interactive environments designed to demonstrate core OOP methodologies, including class inheritance, encapsulation, polymorphism, error handling, and ADO.NET database architectures.
* **Custom Thematic Interface**: Extensive use of GDI+, double-buffered rendering, and programmatic formatting to override native OS controls and achieve a cohesive, stylized aesthetic.
* **3-Level Animation Game**: A custom-built, interactive mini-game integrated directly into the portfolio. It demonstrates advanced event-driven programming, boundary collision, and state management.
* **Interactive Diagnostic Tools**: Functional visualizers for truth-table generation, runtime exception tracing, CLR (Common Language Runtime) execution simulation, and SQL data-reader pipelines.

---

## Visual Showcase

<p align="center">
  <img src="Portfolio%20assets/git1.png" width="48%" alt="Module Interface 1" />
  <img src="Portfolio%20assets/git2.png" width="48%" alt="Module Interface 2" />
</p>
<p align="center">
  <img src="Portfolio%20assets/git3.png" width="48%" alt="Module Interface 3" />
  <img src="Portfolio%20assets/git4.png" width="48%" alt="Module Interface 4" />
</p>
<p align="center">
  <img src="Portfolio%20assets/git5.png" width="48%" alt="Module Interface 5" />
  <img src="Portfolio%20assets/git6.png" width="48%" alt="Module Interface 6" />
</p>

---

## Technical Architecture

* **Core Logic**: Built strictly in VB.NET, utilizing object-oriented principles such as abstract base classes (`MustInherit`), constructors, and structured exception handling (`Try...Catch...Finally`).
* **Data Management**: Implements ADO.NET architectures, utilizing disconnected `DataTable` and `DataSet` objects to simulate CRUD operations and three-valued logic evaluations without requiring a live backend server.
* **UI Engineering**: 
  * Replaces standard Multiple Document Interface (MDI) behaviors with custom panel-bound user controls and form lifecycle management to prevent memory leaks.
  * Utilizes Regular Expressions (`System.Text.RegularExpressions`) to programmatically inject syntax highlighting into read-only documentation panels at runtime, avoiding reliance on heavy third-party text editors.

---

## Installation and Execution

1. **Clone the Repository**:
   ```bash
   git clone [https://github.com/your-username/your-repo-name.git](https://github.com/your-username/your-repo-name.git)
