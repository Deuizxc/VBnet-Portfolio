# Object-Oriented Programming (OOP) Portfolio
**A Persona 5-themed Windows Forms application built with VB.NET**

![VB.NET](https://img.shields.io/badge/Language-VB.NET-00599C?style=for-the-badge&logo=visualstudio&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)

---

## Project Overview

An academic portfolio for an Object-Oriented Programming course. Instead of a folder of disconnected console exercises, a full semester of weekly lessons is packaged into one desktop client, styled after the menu system of *Persona 5* (high-contrast red, black, and gold, skewed HUD bars, animated hover states, and sound on every interaction).

It has three parts: a **profile section**, a **lessons library** covering Weeks 2 to 15 (one interactive form per topic, from classes and inheritance through error handling and ADO.NET), and a **three-level game** that applies the same event-driven ideas in playable form.

---

## Key Features

* **Interactive lesson modules**: Around 55 forms, most with a live demo next to the written explanation, such as a truth-table generator, a compile-error toggle, an exception tracer, and simulated SQL and `DataReader` output.
* **Persona 5-style interface**: Custom GDI+ painting, double-buffered forms, and skewed health bars, applied consistently across every screen.
* **Three-level mini-game**: Built from scratch with timers, `Async`/`Await` animation, and custom rendering.
* **Centralized audio system**: One module attaches hover and click sounds to every form and plays looping music on a separate channel.

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
  <img src="Portfolio%20assets/git7.png" width="48%" alt="Module Interface 6" />
</p>

---

## The Game

| Level | Concept | What it demonstrates |
| :-- | :-- | :-- |
| **1** | River-crossing puzzle | Two-seat boat, 60-second countdown, move counter. Dictionaries track each character's bank and seat; `Async` movement animations and custom hit-testing. |
| **2** | Code-cracking terminal | Guess a secret 3-digit code of unique random digits within limited attempts. Arrays, input validation, and a color-coded log. |
| **3** | Turn-based boss battle | Attack, Persona (costs SP), and Defend against a 1000 HP boss, with critical hits. A turn state machine, async boss turn, and custom-painted HP and SP meters. |

---

## Technical Architecture

**Structure.** A .NET 9 Windows Forms project with hub-and-spoke navigation:

```
Portfolio (home)
 ├── Profile ── Cert, Confidant1 ── Confidant2
 └── Lessons (hub)
      ├── Week2Selector … Week9Selector   → topic forms (Show / Hide)
      ├── Week10, 11-12, 13, 14-15 Selectors → topic forms as MDI children
      └── Menu ── Level1, Level2, Level3
```

Weeks 2 to 9 switch screens by showing the next form and hiding the current one. Weeks 10 to 15 use an **MDI container pattern**: each selector's `OpenChildForm` closes any open child, hides its own controls to prevent bleed-through, and docks the lesson as a borderless, fill-docked child.

**Audio.** `AudioManager` is a single `Module`. UI sounds are preloaded with `SoundPlayer` and debounced to 180 ms. Music and effects run through `winmm.dll` (`mciSendString` via P/Invoke) on named aliases, so looping music never mutes UI sounds. `AttachSounds` walks a form's control tree recursively and removes existing handlers first, so it never stacks duplicates.

**Rendering and documentation panels.** Forms use double buffering and `OnPaint` overrides (Level 3 draws its entire HUD with GDI+). Lesson text is styled at load time with `System.Text.RegularExpressions`, which finds bullet labels and headers and restyles them, avoiding third-party editor controls.

**Simulated data layer.** No database or server is needed. The database lessons use in-memory `DataTable` and `DataSet` objects, and `DataAdapter.Update()` and `DataReader` steps play out as color-coded terminal output.

---

## Installation and Execution

**Requirements:** Windows 10/11 (audio uses `winmm.dll`), the .NET 9 SDK, and optionally Visual Studio 2022 with the *.NET desktop development* workload.

```bash
git clone https://github.com/your-username/your-repo-name.git
cd your-repo-name
dotnet run --project "Project Portfolio Bacani.vbproj"
```

Or open `Project Portfolio Bacani.vbproj` in Visual Studio and press **F5**. The `Sounds`, `Resources`, and `Animation Assets` folders are copied to the build output, so keep them in the repository.

---
