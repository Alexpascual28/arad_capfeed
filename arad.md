<p align="center">
  <img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" width="100" alt="project-logo">
</p>
<p align="center">
    <h1 align="center">ARAD Cap feeder system</h1>
</p>
<p align="center">
    <em><code>Demo cap feeder system for bottle capping industrial robot. Increased throughput by improving the control process state machine. Using .NET WPF, C# and XAML.</code></em>
</p>

<br><!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary><br>

- [ Overview](#-overview)
- [ Features](#-features)
- [ Repository Structure](#-repository-structure)
- [ Modules](#-modules)
- [ Getting Started](#-getting-started)
  - [ Installation](#-installation)
  - [ Usage](#-usage)
  - [ Tests](#-tests)
- [ Project Roadmap](#-project-roadmap)
- [ Contributing](#-contributing)
- [ License](#-license)
- [ Acknowledgments](#-acknowledgments)
</details>
<hr>

##  Overview

<code>This project contains the control software for a demo cap feeder system in an industrial setting, designed specifically for a bottle capping robot. The system is developed using .NET with Windows Presentation Foundation (WPF) and XAML for the user interface, along with C# for backend operations. The application controls a robot for optimal cap feeding and placement with improved throughput by refining the control process state machine.</code>

---

##  Application Components

**Application Template**

- App.xaml: Contains the application startup logic.
- Processes: Handles the various states of the bottle capping process.
- Hardware: Manages communication with the hardware modules necessary for cap feeding and placement.

**Hardware Modules**

The hardware modules interface includes components for controlling robotic arms, conveyors, and sensor arrays to detect and manage bottle and cap positions. The Hardware directory contains the code to interface with these components.

*Included Modules*

- CapClassifier.cs: Identifies and sorts caps based on type and size.
- CapLifter.cs: Elevates the sorted caps to the application point.
- Conveyor.cs: Manages the conveyor that moves bottles into position under the cap application mechanism.

Further explanation can be found in [Code Explanation](#code-explanation)

**Processes**

The Processes directory contains classes representing different states of the bottle capping process. It includes initialization, cap picking, cap feeding, placing, and error handling states.

*Included Modules*

- CapFeedingProcess.cs: Controls the cap feeding mechanism.
- CapMarshallingProcess.cs: Manages the organization and delivery of caps to the classifier.

Further explanation can be found in [Code Explanation](#code-explanation)

---

##  Repository Structure

```sh
└── arad_capfeed/
    ├── Database
    │   └── Create Merlin Database MySQL.sql
    ├── External References
    │   ├── BouncyCastle.Crypto
    │   ├── Devart
    │   ├── Merlin
    │   ├── Microsoft Ribbon for WPF
    │   ├── MySQL
    │   ├── PCAN
    │   ├── Traciot
    │   └── er
    ├── LOG
    ├── README.md
    ├── Source Code
    │   ├── ARAD_CAPFEED.sln
    │   ├── ApplicationTemplate
    │   ├── NuGet.config
    │   ├── Source Code
    │   └── labman.ruleset
    └── packages
        ├── CommonServiceLocator.2.0.4
        ├── EmguCV.3.1.0.1
        ├── Google.Apis.1.49.0
        ├── Google.Apis.Auth.1.49.0
        ├── Google.Apis.Core.1.49.0
        ├── MvvmLight.5.4.1.1
        ├── MvvmLightLibs.5.4.1.1
        ├── Newtonsoft.Json.12.0.3
        ├── OpenTK.1.1.2225.0
        ├── OpenTK.GLControl.1.1.2225.0
        ├── StyleCop.Analyzers.1.1.118
        ├── ZedGraph.5.1.5
        └── packages
```

---

##  Modules

<details closed><summary>packages</summary>

| File                                                                                        | Summary                         |
| ---                                                                                         | ---                             |
| [packages](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/packages) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>packages.OpenTK.1.1.2225.0.content</summary>

| File                                                                                                                                    | Summary                         |
| ---                                                                                                                                     | ---                             |
| [OpenTK.dll.config](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/OpenTK.1.1.2225.0/content/OpenTK.dll.config) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>packages.StyleCop.Analyzers.1.1.118</summary>

| File                                                                                                                                                 | Summary                         |
| ---                                                                                                                                                  | ---                             |
| [THIRD-PARTY-NOTICES.txt](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/StyleCop.Analyzers.1.1.118/THIRD-PARTY-NOTICES.txt) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>packages.EmguCV.3.1.0.1.build</summary>

| File                                                                                                                         | Summary                         |
| ---                                                                                                                          | ---                             |
| [EmguCV.props](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/EmguCV.3.1.0.1/build/EmguCV.props)     | <code>► INSERT-TEXT-HERE</code> |
| [EmguCV.targets](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/EmguCV.3.1.0.1/build/EmguCV.targets) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>packages.ZedGraph.5.1.5</summary>

| File                                                                                                                       | Summary                         |
| ---                                                                                                                        | ---                             |
| [License-LGPL.txt](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/ZedGraph.5.1.5/License-LGPL.txt) | <code>► INSERT-TEXT-HERE</code> |
| [readme.txt](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/ZedGraph.5.1.5/readme.txt)             | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>packages.ZedGraph.5.1.5.lib</summary>

| File                                                                                                                   | Summary                         |
| ---                                                                                                                    | ---                             |
| [ZedGraph.XML](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/ZedGraph.5.1.5/lib/ZedGraph.XML) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>packages.MvvmLight.5.4.1.1.Content.ViewModel</summary>

| File                                                                                                                                                        | Summary                         |
| ---                                                                                                                                                         | ---                             |
| [MainViewModel.cs.pp](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLight.5.4.1.1/Content/ViewModel/MainViewModel.cs.pp)       | <code>► INSERT-TEXT-HERE</code> |
| [ViewModelLocator.cs.pp](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLight.5.4.1.1/Content/ViewModel/ViewModelLocator.cs.pp) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>packages.MvvmLightLibs.5.4.1.1</summary>

| File                                                                                                                                        | Summary                         |
| ---                                                                                                                                         | ---                             |
| [MvvmLightLibs.5.4.1.1](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLightLibs.5.4.1.1/MvvmLightLibs.5.4.1.1) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>packages.MvvmLightLibs.5.4.1.1.lib</summary>

| File                                                                                                        | Summary                         |
| ---                                                                                                         | ---                             |
| [lib](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLightLibs.5.4.1.1/lib/lib) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>packages.MvvmLightLibs.5.4.1.1.lib.portable-net45+wp8+wpa81+netcore45+monoandroid1+xamarin.ios10</summary>

| File                                                                                                                                                                                                                          | Summary                         |
| ---                                                                                                                                                                                                                           | ---                             |
| [GalaSoft.MvvmLight.XML](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLightLibs.5.4.1.1/lib/portable-net45+wp8+wpa81+netcore45+monoandroid1+xamarin.ios10/GalaSoft.MvvmLight.XML)               | <code>► INSERT-TEXT-HERE</code> |
| [GalaSoft.MvvmLight.Extras.XML](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLightLibs.5.4.1.1/lib/portable-net45+wp8+wpa81+netcore45+monoandroid1+xamarin.ios10/GalaSoft.MvvmLight.Extras.XML) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>packages.MvvmLightLibs.5.4.1.1.lib.xamarin.ios10</summary>

| File                                                                                                                                                                              | Summary                         |
| ---                                                                                                                                                                               | ---                             |
| [GalaSoft.MvvmLight.Platform.XML](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLightLibs.5.4.1.1/lib/xamarin.ios10/GalaSoft.MvvmLight.Platform.XML) | <code>► INSERT-TEXT-HERE</code> |
| [GalaSoft.MvvmLight.XML](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLightLibs.5.4.1.1/lib/xamarin.ios10/GalaSoft.MvvmLight.XML)                   | <code>► INSERT-TEXT-HERE</code> |
| [GalaSoft.MvvmLight.Extras.XML](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLightLibs.5.4.1.1/lib/xamarin.ios10/GalaSoft.MvvmLight.Extras.XML)     | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>packages.MvvmLightLibs.5.4.1.1.lib.wpa81</summary>

| File                                                                                                                                                                      | Summary                         |
| ---                                                                                                                                                                       | ---                             |
| [GalaSoft.MvvmLight.Platform.XML](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLightLibs.5.4.1.1/lib/wpa81/GalaSoft.MvvmLight.Platform.XML) | <code>► INSERT-TEXT-HERE</code> |
| [GalaSoft.MvvmLight.XML](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLightLibs.5.4.1.1/lib/wpa81/GalaSoft.MvvmLight.XML)                   | <code>► INSERT-TEXT-HERE</code> |
| [GalaSoft.MvvmLight.Extras.XML](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLightLibs.5.4.1.1/lib/wpa81/GalaSoft.MvvmLight.Extras.XML)     | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>packages.MvvmLightLibs.5.4.1.1.lib.monoandroid1</summary>

| File                                                                                                                                                                             | Summary                         |
| ---                                                                                                                                                                              | ---                             |
| [GalaSoft.MvvmLight.Platform.XML](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLightLibs.5.4.1.1/lib/monoandroid1/GalaSoft.MvvmLight.Platform.XML) | <code>► INSERT-TEXT-HERE</code> |
| [GalaSoft.MvvmLight.XML](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLightLibs.5.4.1.1/lib/monoandroid1/GalaSoft.MvvmLight.XML)                   | <code>► INSERT-TEXT-HERE</code> |
| [GalaSoft.MvvmLight.Extras.XML](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/packages/MvvmLightLibs.5.4.1.1/lib/monoandroid1/GalaSoft.MvvmLight.Extras.XML)     | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>LOG</summary>

| File                                                                                                                                         | Summary                         |
| ---                                                                                                                                          | ---                             |
| [Log_Process_2022_11_28.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Process_2022_11_28.html)                 | <code>► INSERT-TEXT-HERE</code> |
| [Log_UserActivityLog_2022_09_22.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_UserActivityLog_2022_09_22.html) | <code>► INSERT-TEXT-HERE</code> |
| [Log_UserActivityLog_2022_11_24.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_UserActivityLog_2022_11_24.html) | <code>► INSERT-TEXT-HERE</code> |
| [Log_System_2022_09_28.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_System_2022_09_28.html)                   | <code>► INSERT-TEXT-HERE</code> |
| [Log_Debug_2022_09_28.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Debug_2022_09_28.html)                     | <code>► INSERT-TEXT-HERE</code> |
| [Log_Process_2022_11_21.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Process_2022_11_21.html)                 | <code>► INSERT-TEXT-HERE</code> |
| [Log_Process_2022_11_23.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Process_2022_11_23.html)                 | <code>► INSERT-TEXT-HERE</code> |
| [Log_System_2022_11_23.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_System_2022_11_23.html)                   | <code>► INSERT-TEXT-HERE</code> |
| [Log_Process_2022_11_22.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Process_2022_11_22.html)                 | <code>► INSERT-TEXT-HERE</code> |
| [Log_Process_2022_09_19.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Process_2022_09_19.html)                 | <code>► INSERT-TEXT-HERE</code> |
| [Log_UserActivityLog_2023_01_13.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_UserActivityLog_2023_01_13.html) | <code>► INSERT-TEXT-HERE</code> |
| [Log_Debug_2022_09_27.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Debug_2022_09_27.html)                     | <code>► INSERT-TEXT-HERE</code> |
| [Log_Debug_2022_09_22.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Debug_2022_09_22.html)                     | <code>► INSERT-TEXT-HERE</code> |
| [Log_Process_2023_01_13.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Process_2023_01_13.html)                 | <code>► INSERT-TEXT-HERE</code> |
| [Log_Debug_2022_11_21.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Debug_2022_11_21.html)                     | <code>► INSERT-TEXT-HERE</code> |
| [Log_Process_2022_11_24.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Process_2022_11_24.html)                 | <code>► INSERT-TEXT-HERE</code> |
| [Log_Process_2022_09_22.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Process_2022_09_22.html)                 | <code>► INSERT-TEXT-HERE</code> |
| [Log_UserActivityLog_2022_11_22.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_UserActivityLog_2022_11_22.html) | <code>► INSERT-TEXT-HERE</code> |
| [Log_Process_2022_09_21.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Process_2022_09_21.html)                 | <code>► INSERT-TEXT-HERE</code> |
| [Log_Debug_2022_11_28.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Debug_2022_11_28.html)                     | <code>► INSERT-TEXT-HERE</code> |
| [Log_Process_2022_09_16.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Process_2022_09_16.html)                 | <code>► INSERT-TEXT-HERE</code> |
| [Log_Debug_2022_11_22.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Debug_2022_11_22.html)                     | <code>► INSERT-TEXT-HERE</code> |
| [Log_UserActivityLog_2022_11_28.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_UserActivityLog_2022_11_28.html) | <code>► INSERT-TEXT-HERE</code> |
| [Log_System_2022_11_21.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_System_2022_11_21.html)                   | <code>► INSERT-TEXT-HERE</code> |
| [Log_Debug_2022_11_24.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Debug_2022_11_24.html)                     | <code>► INSERT-TEXT-HERE</code> |
| [Log_System_2022_09_15.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_System_2022_09_15.html)                   | <code>► INSERT-TEXT-HERE</code> |
| [Log_System_2022_09_22.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_System_2022_09_22.html)                   | <code>► INSERT-TEXT-HERE</code> |
| [Log_System_2022_09_16.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_System_2022_09_16.html)                   | <code>► INSERT-TEXT-HERE</code> |
| [Log_UserActivityLog_2022_11_21.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_UserActivityLog_2022_11_21.html) | <code>► INSERT-TEXT-HERE</code> |
| [Log_Process_2022_09_15.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Process_2022_09_15.html)                 | <code>► INSERT-TEXT-HERE</code> |
| [Log_UserActivityLog_2022_11_23.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_UserActivityLog_2022_11_23.html) | <code>► INSERT-TEXT-HERE</code> |
| [Log_Debug_2023_01_13.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Debug_2023_01_13.html)                     | <code>► INSERT-TEXT-HERE</code> |
| [Log_System_2022_11_22.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_System_2022_11_22.html)                   | <code>► INSERT-TEXT-HERE</code> |
| [Log_UserActivityLog_2022_09_28.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_UserActivityLog_2022_09_28.html) | <code>► INSERT-TEXT-HERE</code> |
| [Log_Debug_2022_09_16.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Debug_2022_09_16.html)                     | <code>► INSERT-TEXT-HERE</code> |
| [Log_UserActivityLog_2022_09_16.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_UserActivityLog_2022_09_16.html) | <code>► INSERT-TEXT-HERE</code> |
| [Log_Debug_2022_09_19.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Debug_2022_09_19.html)                     | <code>► INSERT-TEXT-HERE</code> |
| [Log_System_2022_11_28.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_System_2022_11_28.html)                   | <code>► INSERT-TEXT-HERE</code> |
| [Log_Process_2022_09_28.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Process_2022_09_28.html)                 | <code>► INSERT-TEXT-HERE</code> |
| [Log_UserActivityLog_2022_09_21.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_UserActivityLog_2022_09_21.html) | <code>► INSERT-TEXT-HERE</code> |
| [Log_UserActivityLog_2022_09_19.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_UserActivityLog_2022_09_19.html) | <code>► INSERT-TEXT-HERE</code> |
| [Log_System_2022_11_24.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_System_2022_11_24.html)                   | <code>► INSERT-TEXT-HERE</code> |
| [Log_UserActivityLog_2022_09_27.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_UserActivityLog_2022_09_27.html) | <code>► INSERT-TEXT-HERE</code> |
| [Log_Process_2022_09_27.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Process_2022_09_27.html)                 | <code>► INSERT-TEXT-HERE</code> |
| [Log_Debug_2022_11_23.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Debug_2022_11_23.html)                     | <code>► INSERT-TEXT-HERE</code> |
| [Log_System_2022_09_21.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_System_2022_09_21.html)                   | <code>► INSERT-TEXT-HERE</code> |
| [Log_Debug_2022_09_21.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Debug_2022_09_21.html)                     | <code>► INSERT-TEXT-HERE</code> |
| [Log_System_2022_09_27.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_System_2022_09_27.html)                   | <code>► INSERT-TEXT-HERE</code> |
| [Log_System_2022_09_19.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_System_2022_09_19.html)                   | <code>► INSERT-TEXT-HERE</code> |
| [Log_System_2023_01_13.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_System_2023_01_13.html)                   | <code>► INSERT-TEXT-HERE</code> |
| [Log_Debug_2022_09_15.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_Debug_2022_09_15.html)                     | <code>► INSERT-TEXT-HERE</code> |
| [Log_UserActivityLog_2022_09_15.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/LOG/Log_UserActivityLog_2022_09_15.html) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Database</summary>

| File                                                                                                                                        | Summary                         |
| ---                                                                                                                                         | ---                             |
| [Create Merlin Database MySQL.sql](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Database/Create Merlin Database MySQL.sql) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References</summary>

| File                                                                                       | Summary                         |
| ---                                                                                        | ---                             |
| [er](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/er) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References.Devart.dotConnect.Linq</summary>

| File                                                                                                                                  | Summary                         |
| ---                                                                                                                                   | ---                             |
| [History.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/History.html) | <code>► INSERT-TEXT-HERE</code> |
| [Readme.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Readme.html)   | <code>► INSERT-TEXT-HERE</code> |
| [License.rtf](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/License.rtf)   | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References.Devart.dotConnect.Linq.Samples</summary>

| File                                                                                                                                        | Summary                         |
| ---                                                                                                                                         | ---                             |
| [Readme.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/Readme.html) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References.Devart.dotConnect.Linq.Samples.LinqConnect</summary>

| File                                                                                                                                                                                        | Summary                         |
| ---                                                                                                                                                                                         | ---                             |
| [crm_demo_mysql.sql](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/crm_demo_mysql.sql)                       | <code>► INSERT-TEXT-HERE</code> |
| [CrmDataMappingSQLite.lqml](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CrmDataMappingSQLite.lqml)         | <code>► INSERT-TEXT-HERE</code> |
| [CrmDataMappingMySql.lqml](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CrmDataMappingMySql.lqml)           | <code>► INSERT-TEXT-HERE</code> |
| [crm_demo_postgresql.sql](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/crm_demo_postgresql.sql)             | <code>► INSERT-TEXT-HERE</code> |
| [VBasicLinqDemo.sln](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VBasicLinqDemo.sln)                       | <code>► INSERT-TEXT-HERE</code> |
| [CrmDataMappingOracle.lqml](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CrmDataMappingOracle.lqml)         | <code>► INSERT-TEXT-HERE</code> |
| [CSharpLinqDemo.sln](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CSharpLinqDemo.sln)                       | <code>► INSERT-TEXT-HERE</code> |
| [App.Config](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/App.Config)                                       | <code>► INSERT-TEXT-HERE</code> |
| [CrmDataMappingPostgreSql.lqml](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CrmDataMappingPostgreSql.lqml) | <code>► INSERT-TEXT-HERE</code> |
| [crm_demo_sql.sql](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/crm_demo_sql.sql)                           | <code>► INSERT-TEXT-HERE</code> |
| [CrmDataMappingSqlClient.lqml](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CrmDataMappingSqlClient.lqml)   | <code>► INSERT-TEXT-HERE</code> |
| [crm_demo_oracle.sql](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/crm_demo_oracle.sql)                     | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References.Devart.dotConnect.Linq.Samples.LinqConnect.CS</summary>

| File                                                                                                                                                                                         | Summary                         |
| ---                                                                                                                                                                                          | ---                             |
| [BaseControl.Designer.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/BaseControl.Designer.cs)           | <code>► INSERT-TEXT-HERE</code> |
| [ConnectionDialog.resx](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/ConnectionDialog.resx)               | <code>► INSERT-TEXT-HERE</code> |
| [AssemblyInfo.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/AssemblyInfo.cs)                           | <code>► INSERT-TEXT-HERE</code> |
| [CrmDataContext.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/CrmDataContext.cs)                       | <code>► INSERT-TEXT-HERE</code> |
| [BaseControl.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/BaseControl.cs)                             | <code>► INSERT-TEXT-HERE</code> |
| [LinqDemo.csproj](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/LinqDemo.csproj)                           | <code>► INSERT-TEXT-HERE</code> |
| [ConnectionDialog.Designer.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/ConnectionDialog.Designer.cs) | <code>► INSERT-TEXT-HERE</code> |
| [MainForm.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/MainForm.cs)                                   | <code>► INSERT-TEXT-HERE</code> |
| [Program.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/Program.cs)                                     | <code>► INSERT-TEXT-HERE</code> |
| [MainForm.Designer.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/MainForm.Designer.cs)                 | <code>► INSERT-TEXT-HERE</code> |
| [MainForm.resx](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/MainForm.resx)                               | <code>► INSERT-TEXT-HERE</code> |
| [ConnectionDialog.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/ConnectionDialog.cs)                   | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References.Devart.dotConnect.Linq.Samples.LinqConnect.CS.SubmitChanges</summary>

| File                                                                                                                                                                                                               | Summary                         |
| ---                                                                                                                                                                                                                | ---                             |
| [SubmitChangesControl.Designer.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/SubmitChanges/SubmitChangesControl.Designer.cs) | <code>► INSERT-TEXT-HERE</code> |
| [SubmitChangesControl.resx](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/SubmitChanges/SubmitChangesControl.resx)               | <code>► INSERT-TEXT-HERE</code> |
| [SubmitChangesControl.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/SubmitChanges/SubmitChangesControl.cs)                   | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References.Devart.dotConnect.Linq.Samples.LinqConnect.CS.Queries</summary>

| File                                                                                                                                                                                             | Summary                         |
| ---                                                                                                                                                                                              | ---                             |
| [QueriesControl.resx](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/Queries/QueriesControl.resx)               | <code>► INSERT-TEXT-HERE</code> |
| [QueriesControl.Designer.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/Queries/QueriesControl.Designer.cs) | <code>► INSERT-TEXT-HERE</code> |
| [QueriesControl.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/Queries/QueriesControl.cs)                   | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References.Devart.dotConnect.Linq.Samples.LinqConnect.CS.MasterDetail</summary>

| File                                                                                                                                                                                                            | Summary                         |
| ---                                                                                                                                                                                                             | ---                             |
| [MasterDetailControl.Designer.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/MasterDetail/MasterDetailControl.Designer.cs) | <code>► INSERT-TEXT-HERE</code> |
| [MasterDetailControl.resx](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/MasterDetail/MasterDetailControl.resx)               | <code>► INSERT-TEXT-HERE</code> |
| [MasterDetailControl.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/CS/MasterDetail/MasterDetailControl.cs)                   | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References.Devart.dotConnect.Linq.Samples.LinqConnect.VB</summary>

| File                                                                                                                                                                                         | Summary                         |
| ---                                                                                                                                                                                          | ---                             |
| [ConnectionDialog.resx](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/ConnectionDialog.resx)               | <code>► INSERT-TEXT-HERE</code> |
| [Application.myapp](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/Application.myapp)                       | <code>► INSERT-TEXT-HERE</code> |
| [MainForm.Designer.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/MainForm.Designer.vb)                 | <code>► INSERT-TEXT-HERE</code> |
| [BaseControl.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/BaseControl.vb)                             | <code>► INSERT-TEXT-HERE</code> |
| [MainForm.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/MainForm.vb)                                   | <code>► INSERT-TEXT-HERE</code> |
| [ConnectionDialog.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/ConnectionDialog.vb)                   | <code>► INSERT-TEXT-HERE</code> |
| [BaseControl.Designer.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/BaseControl.Designer.vb)           | <code>► INSERT-TEXT-HERE</code> |
| [MainForm.resx](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/MainForm.resx)                               | <code>► INSERT-TEXT-HERE</code> |
| [AssemblyInfo.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/AssemblyInfo.vb)                           | <code>► INSERT-TEXT-HERE</code> |
| [LinqDemo.vbproj](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/LinqDemo.vbproj)                           | <code>► INSERT-TEXT-HERE</code> |
| [CrmDataContext.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/CrmDataContext.vb)                       | <code>► INSERT-TEXT-HERE</code> |
| [ConnectionDialog.Designer.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/ConnectionDialog.Designer.vb) | <code>► INSERT-TEXT-HERE</code> |
| [Application.Designer.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/Application.Designer.vb)           | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References.Devart.dotConnect.Linq.Samples.LinqConnect.VB.SubmitChanges</summary>

| File                                                                                                                                                                                                               | Summary                         |
| ---                                                                                                                                                                                                                | ---                             |
| [SubmitChangesControl.Designer.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/SubmitChanges/SubmitChangesControl.Designer.vb) | <code>► INSERT-TEXT-HERE</code> |
| [SubmitChangesControl.resx](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/SubmitChanges/SubmitChangesControl.resx)               | <code>► INSERT-TEXT-HERE</code> |
| [SubmitChangesControl.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/SubmitChanges/SubmitChangesControl.vb)                   | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References.Devart.dotConnect.Linq.Samples.LinqConnect.VB.Queries</summary>

| File                                                                                                                                                                                             | Summary                         |
| ---                                                                                                                                                                                              | ---                             |
| [QueriesControl.Designer.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/Queries/QueriesControl.Designer.vb) | <code>► INSERT-TEXT-HERE</code> |
| [QueriesControl.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/Queries/QueriesControl.vb)                   | <code>► INSERT-TEXT-HERE</code> |
| [QueriesControl.resx](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/Queries/QueriesControl.resx)               | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References.Devart.dotConnect.Linq.Samples.LinqConnect.VB.MasterDetail</summary>

| File                                                                                                                                                                                                            | Summary                         |
| ---                                                                                                                                                                                                             | ---                             |
| [MasterDetailControl.Designer.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/MasterDetail/MasterDetailControl.Designer.vb) | <code>► INSERT-TEXT-HERE</code> |
| [MasterDetailControl.vb](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/MasterDetail/MasterDetailControl.vb)                   | <code>► INSERT-TEXT-HERE</code> |
| [MasterDetailControl.resx](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Samples/LinqConnect/VB/MasterDetail/MasterDetailControl.resx)               | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References.Devart.dotConnect.Linq.Doc</summary>

| File                                                                                                                                              | Summary                         |
| ---                                                                                                                                               | ---                             |
| [LinqConnect.HxC](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Doc/LinqConnect.HxC)   | <code>► INSERT-TEXT-HERE</code> |
| [LinqConnectK.HxK](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Doc/LinqConnectK.HxK) | <code>► INSERT-TEXT-HERE</code> |
| [LinqConnectF.HxK](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Doc/LinqConnectF.HxK) | <code>► INSERT-TEXT-HERE</code> |
| [product1.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Doc/product1.html)       | <code>► INSERT-TEXT-HERE</code> |
| [LinqConnectN.HxK](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Doc/LinqConnectN.HxK) | <code>► INSERT-TEXT-HERE</code> |
| [LinqConnect.HxA](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Doc/LinqConnect.HxA)   | <code>► INSERT-TEXT-HERE</code> |
| [book2.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Doc/book2.html)             | <code>► INSERT-TEXT-HERE</code> |
| [book1.html](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Doc/book1.html)             | <code>► INSERT-TEXT-HERE</code> |
| [LinqConnect.HxT](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/Linq/Doc/LinqConnect.HxT)   | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>External References.Devart.dotConnect.SQLite</summary>

| File                                                                                                                                  | Summary                         |
| ---                                                                                                                                   | ---                             |
| [sqlite3.def](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/External References/Devart/dotConnect/SQLite/sqlite3.def) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code</summary>

| File                                                                                                           | Summary                         |
| ---                                                                                                            | ---                             |
| [Source Code](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/Source%20Code)           | <code>► INSERT-TEXT-HERE</code> |
| [labman.ruleset](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/labman.ruleset)     | <code>► INSERT-TEXT-HERE</code> |
| [ARAD_CAPFEED.sln](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ARAD_CAPFEED.sln) | <code>► INSERT-TEXT-HERE</code> |
| [NuGet.config](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/NuGet.config)         | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate</summary>

| File                                                                                                                                                                           | Summary                         |
| ---                                                                                                                                                                            | ---                             |
| [Copyright Notices.txt](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Copyright Notices.txt)                                   | <code>► INSERT-TEXT-HERE</code> |
| [App.xaml.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/App.xaml.cs)                                                       | <code>► INSERT-TEXT-HERE</code> |
| [ApplicationTemplate](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/ApplicationTemplate)                                       | <code>► INSERT-TEXT-HERE</code> |
| [ARAD_CAPFEED.csproj.user](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/ARAD_CAPFEED.csproj.user)                             | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate.csproj](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Labman.ApplicationTemplate.csproj)           | <code>► INSERT-TEXT-HERE</code> |
| [ARAD_CAPFEED.csproj](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/ARAD_CAPFEED.csproj)                                       | <code>► INSERT-TEXT-HERE</code> |
| [App.xaml](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/App.xaml)                                                             | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate.csproj.user](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Labman.ApplicationTemplate.csproj.user) | <code>► INSERT-TEXT-HERE</code> |
| [packages.config](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/packages.config)                                               | <code>► INSERT-TEXT-HERE</code> |
| [stylecop.json](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/stylecop.json)                                                   | <code>► INSERT-TEXT-HERE</code> |
| [app.config](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/app.config)                                                         | <code>► INSERT-TEXT-HERE</code> |
| [OpenTK.dll.config](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/OpenTK.dll.config)                                           | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate.Database</summary>

| File                                                                                                                                                | Summary                         |
| ---                                                                                                                                                 | ---                             |
| [ParametersAutoGen.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Database/ParametersAutoGen.cs) | <code>► INSERT-TEXT-HERE</code> |
| [ParametersAutoGen.tt](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Database/ParametersAutoGen.tt) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate.Hardware</summary>

| File                                                                                                                                                                            | Summary                         |
| ---                                                                                                                                                                             | ---                             |
| [EntranceGateNotClosingException.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Hardware/EntranceGateNotClosingException.cs) | <code>► INSERT-TEXT-HERE</code> |
| [RobotHardwareAutoGen.tt](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Hardware/RobotHardwareAutoGen.tt)                       | <code>► INSERT-TEXT-HERE</code> |
| [Conveyor.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Hardware/Conveyor.cs)                                               | <code>► INSERT-TEXT-HERE</code> |
| [CapLifter.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Hardware/CapLifter.cs)                                             | <code>► INSERT-TEXT-HERE</code> |
| [RobotHardwareAutoGen.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Hardware/RobotHardwareAutoGen.cs)                       | <code>► INSERT-TEXT-HERE</code> |
| [CapClassifier.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Hardware/CapClassifier.cs)                                     | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate.Actions</summary>

| File                                                                                                                                 | Summary                         |
| ---                                                                                                                                  | ---                             |
| [TestCycles.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Actions/TestCycles.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate.Processes</summary>

| File                                                                                                                                                         | Summary                         |
| ---                                                                                                                                                          | ---                             |
| [CapFeedingProcess.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Processes/CapFeedingProcess.cs)         | <code>► INSERT-TEXT-HERE</code> |
| [CapMarshallingProcess.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Processes/CapMarshallingProcess.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate.Messaging.Messages</summary>

| File                                                                                                                                                                              | Summary                         |
| ---                                                                                                                                                                               | ---                             |
| [CapFeederDataChangedMessage.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Messaging/Messages/CapFeederDataChangedMessage.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate.Properties</summary>

| File                                                                                                                                                    | Summary                         |
| ---                                                                                                                                                     | ---                             |
| [Resources.resx](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Properties/Resources.resx)               | <code>► INSERT-TEXT-HERE</code> |
| [AssemblyInfo.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Properties/AssemblyInfo.cs)             | <code>► INSERT-TEXT-HERE</code> |
| [Settings.settings](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Properties/Settings.settings)         | <code>► INSERT-TEXT-HERE</code> |
| [Resources.Designer.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Properties/Resources.Designer.cs) | <code>► INSERT-TEXT-HERE</code> |
| [Settings.Designer.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/Properties/Settings.Designer.cs)   | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate.obj.Debug</summary>

| File                                                                                                                                                                                                                     | Summary                         |
| ---                                                                                                                                                                                                                      | ---                             |
| [Labman.ApplicationTemplate_MarkupCompile.lref.r2103](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/Labman.ApplicationTemplate_MarkupCompile.lref.r2103)       | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate_Content.g.i.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/Labman.ApplicationTemplate_Content.g.i.cs)                           | <code>► INSERT-TEXT-HERE</code> |
| [ARAD_CAPFEED.csproj.CoreCompileInputs.cache.mine](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/ARAD_CAPFEED.csproj.CoreCompileInputs.cache.mine)             | <code>► INSERT-TEXT-HERE</code> |
| [ARAD_CAPFEED.csproj.CoreCompileInputs.cache.r2106](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/ARAD_CAPFEED.csproj.CoreCompileInputs.cache.r2106)           | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate.csproj.CopyComplete](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/Labman.ApplicationTemplate.csproj.CopyComplete)                 | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate_MarkupCompile.cache.r2106](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/Labman.ApplicationTemplate_MarkupCompile.cache.r2106)     | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate_MarkupCompile.i.lref](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/Labman.ApplicationTemplate_MarkupCompile.i.lref)               | <code>► INSERT-TEXT-HERE</code> |
| [ARAD_CAPFEED.csproj.FileListAbsolute.txt](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/ARAD_CAPFEED.csproj.FileListAbsolute.txt)                             | <code>► INSERT-TEXT-HERE</code> |
| [App.g.i.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/App.g.i.cs)                                                                                         | <code>► INSERT-TEXT-HERE</code> |
| [GeneratedInternalTypeHelper.g.i.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/GeneratedInternalTypeHelper.g.i.cs)                                         | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate_MarkupCompile.lref.r2106](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/Labman.ApplicationTemplate_MarkupCompile.lref.r2106)       | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate_Content.g.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/Labman.ApplicationTemplate_Content.g.cs)                               | <code>► INSERT-TEXT-HERE</code> |
| [ARAD_CAPFEED.csproj.CopyComplete](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/ARAD_CAPFEED.csproj.CopyComplete)                                             | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate.csproj.FileListAbsolute.txt](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/Labman.ApplicationTemplate.csproj.FileListAbsolute.txt) | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate_MarkupCompile.cache.r2103](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/Labman.ApplicationTemplate_MarkupCompile.cache.r2103)     | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate_MarkupCompile.lref.mine](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/Labman.ApplicationTemplate_MarkupCompile.lref.mine)         | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate_MarkupCompile.lref](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/Labman.ApplicationTemplate_MarkupCompile.lref)                   | <code>► INSERT-TEXT-HERE</code> |
| [ARAD_CAPFEED.csproj.CoreCompileInputs.cache.r2103](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/ARAD_CAPFEED.csproj.CoreCompileInputs.cache.r2103)           | <code>► INSERT-TEXT-HERE</code> |
| [GeneratedInternalTypeHelper.g.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/GeneratedInternalTypeHelper.g.cs)                                             | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate_MarkupCompile.cache.mine](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/Labman.ApplicationTemplate_MarkupCompile.cache.mine)       | <code>► INSERT-TEXT-HERE</code> |
| [App.g.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/App.g.cs)                                                                                             | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate.obj.Debug.UserInterface</summary>

| File                                                                                                                                                         | Summary                         |
| ---                                                                                                                                                          | ---                             |
| [MainWindow.g.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/UserInterface/MainWindow.g.cs)     | <code>► INSERT-TEXT-HERE</code> |
| [MainWindow.g.i.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/UserInterface/MainWindow.g.i.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate.obj.Debug.UserInterface.UserControlViews</summary>

| File                                                                                                                                                                                              | Summary                         |
| ---                                                                                                                                                                                               | ---                             |
| [CapFeederUserControl.g.i.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/UserInterface/UserControlViews/CapFeederUserControl.g.i.cs) | <code>► INSERT-TEXT-HERE</code> |
| [Process1UserControl.g.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/UserInterface/UserControlViews/Process1UserControl.g.cs)       | <code>► INSERT-TEXT-HERE</code> |
| [Process1UserControl.g.i.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/UserInterface/UserControlViews/Process1UserControl.g.i.cs)   | <code>► INSERT-TEXT-HERE</code> |
| [Process3UserControl.g.i.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/obj/Debug/UserInterface/UserControlViews/Process3UserControl.g.i.cs)   | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate.bin</summary>

| File                                                                                                                                                                                                                   | Summary                         |
| ---                                                                                                                                                                                                                    | ---                             |
| [Copyright Notices.txt](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/bin/Copyright Notices.txt)                                                                       | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate.vshost.exe.manifest](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/bin/Labman.ApplicationTemplate.vshost.exe.manifest)                     | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate.exe.config](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/bin/Labman.ApplicationTemplate.exe.config)                                       | <code>► INSERT-TEXT-HERE</code> |
| [bin](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/bin/bin)                                                                                                           | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate.vshost.exe.config](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/bin/Labman.ApplicationTemplate.vshost.exe.config)                         | <code>► INSERT-TEXT-HERE</code> |
| [Labman.ApplicationTemplate.exe.lastcodeanalysissucceeded](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/bin/Labman.ApplicationTemplate.exe.lastcodeanalysissucceeded) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate.UserInterface</summary>

| File                                                                                                                                                             | Summary                         |
| ---                                                                                                                                                              | ---                             |
| [MainWindow.xaml](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/UserInterface/MainWindow.xaml)                   | <code>► INSERT-TEXT-HERE</code> |
| [MainWindow.xaml.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/UserInterface/MainWindow.xaml.cs)             | <code>► INSERT-TEXT-HERE</code> |
| [PreRunChecksHelpers.xaml](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/UserInterface/PreRunChecksHelpers.xaml) | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate.UserInterface.ViewModels</summary>

| File                                                                                                                                                                                      | Summary                         |
| ---                                                                                                                                                                                       | ---                             |
| [Process1UserControlViewModel.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/UserInterface/ViewModels/Process1UserControlViewModel.cs) | <code>► INSERT-TEXT-HERE</code> |
| [MainWindowViewModel.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/UserInterface/ViewModels/MainWindowViewModel.cs)                   | <code>► INSERT-TEXT-HERE</code> |

</details>

<details closed><summary>Source Code.ApplicationTemplate.UserInterface.UserControlViews</summary>

| File                                                                                                                                                                                    | Summary                         |
| ---                                                                                                                                                                                     | ---                             |
| [Process1UserControl.xaml](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/UserInterface/UserControlViews/Process1UserControl.xaml)       | <code>► INSERT-TEXT-HERE</code> |
| [Process1UserControl.xaml.cs](https://github.com/Alexpascual28/arad_capfeed.git/blob/master/Source%20Code/ApplicationTemplate/UserInterface/UserControlViews/Process1UserControl.xaml.cs) | <code>► INSERT-TEXT-HERE</code> |

</details>

---

##  Getting Started

**System Requirements**

Windows 10 or later
.NET Framework 4.7.2 or later
Visual Studio 2019 or newer (with the .NET desktop development workload installed)

**Libraries and Packages**

The project uses several NuGet packages:

- OpenTK: Used for 3D rendering of the cap feeder setup in simulations.
- EntityFramework: For managing database interactions if required.

Refer to **packages.config** for a complete list of dependencies.

###  Cloning the Repository

<h4>From <code>source</code></h4>

> 1. Clone this repository to your local machine using Visual Studio or any Git client::
>
> ```console
> $ git clone https://github.com/Alexpascual28/arad_capfeed.git
> ```
>
> 2. Change to the project directory:
> ```console
> $ cd arad_capfeed
> ```


###  Usage

**Setup**

1. Open the Solution: Navigate to the cloned directory and open ARAD_CAPFEED.sln in Visual Studio.
2. Restore NuGet Packages: Ensure all necessary NuGet packages are restored by right-clicking the solution in Solution Explorer and selecting "Restore NuGet Packages".

**Build and Run**

* Build the Project: Build the solution by pressing **Ctrl+Shift+B** or by selecting "Build Solution" from the "Build" menu.
* Run the Application: Start the application by pressing **F5** or selecting "Start Debugging" from the "Debug" menu.

---

##  Code Explanation

### Hardware Modules

**Cap Classifier**

The CapClassifier.cs script is key in ensuring that caps are correctly oriented and ready for application to bottles. The file is written in C# and is used to control the cap classifier module which sorts caps based on their orientation before they are applied to bottles.

The system uses a combination of sensors to detect cap orientation and pneumatic actuators to physically sort the caps based on these detections. The logic includes robust error handling to deal with mechanical failures or misalignments, making it a critical component of the cap feeding system in an industrial bottling setup. The use of logging ensures that the system's operation can be monitored and troubleshot effectively.

*Namespace and Dependencies*

The CapClassifier class is contained within the Labman.Hardware namespace, suggesting its role in interfacing with physical hardware components. It uses various classes and libraries for input/output control (Labman.Hardware.IODevices), logging (Labman.Logging), and possibly other operations under Labman.IO.

*Class Description*

Class CapClassifier: Defined as a static class, which means it doesn't require an instance to invoke its methods. It is designed to process actions related to cap sorting, including managing how caps are marshalled and sorted.

Public Properties
SortedCaps: Static integer tracking the number of caps successfully sorted.
RejectedCaps: Static integer tracking the number of caps identified as unsuitable and rejected.

Private Properties
These involve hardware interfaces, specifically sensors and actuators:
SideSensor: Checks the presence of a cap.
TopSensor: Determines if a cap is placed inverted (upside down).
SortingCylinder, MarshalEntranceCylinder, and MarshalExitCylinder: Actuators that manage the movement of caps through the sorting mechanism.

Methods

MarshalCap()
This method orchestrates the sorting of a single cap through the classifier system:

It begins by checking if the system is in simulation mode, in which case it exits early.
It then uses the TopSensor to check if the cap is facing the correct way.
It controls the entrance and exit cylinders to manage the flow of caps into and out of the sorting area.
It contains logic to handle retry attempts if a marshalling gate fails to close.
Depending on the cap's orientation, it either allows the cap to pass through or activates the SortingCylinder to reject the cap.
Logs are generated for each sorted or rejected cap.
ResetMarshallingGates() and CloseMarshallingGates()
These methods manage the state of the marshalling gates to prepare for the next operation or to reset the system to a known state.

OpenMarshallingGates()
This method opens all gates, presumably to clear the path or prepare the system for maintenance or non-operational modes.

IsCapFed()
Returns a boolean indicating whether a cap is ready to be processed. This might also involve checking the orientation of the cap, though the current implementation checks only for presence.

**Cap Lifter**

**Conveyor**

---