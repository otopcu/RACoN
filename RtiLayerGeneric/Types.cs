﻿/* 
RACoN - RTI abstraction component for MS.NET (RACoN)
https://sites.google.com/site/okantopcu/racon

Copyright © Okan Topçu, 2009-2019
otot.support@outlook.com

This program is free software : you can redistribute it and / or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace Racon.RtiLayer
{
  /// <summary>
  /// The RTI abstraction component for .NET (RACoN).
  /// </summary>

  /// <remarks>RACoN deals with the HLA runtime infrastructure (RTI) level communication in order to access the federation-wide data (actually, the objects and interactions exchanged in federation). RTI is a middleware broker software that manages the federation execution and management, and object exchanges through a federation execution.
  /// The RACoN provides the .NET wrapper classes for the RTI and RTI-specific data structures. As it offers more maintainable, robust, and portable methods, developing an abstraction layer (wrapper) over RTI is a popular approach in many HLA-based projects. 
  /// </remarks>
  /// 
  internal class NamespaceDoc
  {
    // This class is only for documentation of Namespace: RACoN.ObjectModel in Sandcastle
  }
  /*
  /// <summary>
  /// Represents type of RTI library wrapped by RACoN. Default is HLA13_DMSO
  /// </summary>
  public enum RTILibraryType
  {
    /// <summary>
    /// DMSO HLA 1.3 
    /// </summary>
    HLA13_DMSO,
    /// <summary>
    /// Portico HLA 1.3
    /// </summary>
    HLA13_Portico,
    /// <summary>
    /// OpenRti HLA 1.3
    /// </summary>
    HLA13_OpenRti,
    /// <summary>
    ///  Portico HLA Evolved (IEEE 1516-2010)
    /// </summary>
    HLA1516e_Portico,
    /// <summary>
    ///  OpenRti HLA Evolved (IEEE 1516-2010)
    /// </summary>
    HLA1516e_OpenRti,
  };
*/
  /// <summary>
  /// Enum Federation States
  /// Fedexec typical cycle: Initial -> Created -> Initial
  /// </summary>
  public enum FederationExecutionStates
  {
    /// <summary>
    /// Federation is not available (does not exist). Either it is deleted or not created yet.
    /// </summary>
    FEDEX_DOESNOTEXIST,  
    /// <summary>
    ///  Federation is created.
    /// </summary>
    FEDEX_EXISTS 
  } ;
/*
  /// <summary>
  /// Enum Federate States
  /// Federate typical cycle: Initial -> joined -> ready -> running -> Initial
  /// </summary>
  [Flags]
  public enum FederateStates
  {
    /// <summary>
    /// Federate is in initial state, not connected to the RTI
    /// </summary>
    NOTCONNECTED = 1,

    #region CONNECTED
    /// <summary>
    /// Compound state: JOINED + NOTJOINED
    /// </summary>
    CONNECTED = 2,
    #region JOINED
    /// <summary>
    /// Compound state: FREERUN + SCENARIORUN
    /// </summary>
    JOINED = 4,
    /// <summary>
    /// Federate is joined to the federation, but it is not related to a specific scenario
    /// </summary>
    FREERUN = 8, // 
    /// <summary>
    /// Compound state: READY, PLAYING, PAUSED
    /// </summary>
    SCENARIORUN = 16, // 
    /// <summary>
    /// Scenario attributes are received/Updated and federate is ready for the scenario start.
    /// </summary>
    SCENARIORUN_READY = 32, // 
    /// <summary>
    /// Scenario began and the federate is ticking
    /// </summary>
    SCENARIORUN_PLAYING = 64,// 
    /// <summary>
    /// Scenario paused
    /// </summary>
    SCENARIORUN_PAUSED = 128, // 
    #endregion
    /// <summary>
    /// Federate is in initial state, connected to the RTI
    /// </summary>
    NOTJOINED = 256,
    #endregion
  };

  /// <summary>
  /// Enum Ordering Policy
  /// </summary>
  public enum OrderType
  {
    /// <summary>
    /// Receive order = 1 for HLA1516-2010
    /// </summary>
    Receive = 1,
    /// <summary>
    /// TimeStamp = 2 for HLA1516-2010
    /// </summary>
    TimeStamp = 2
  };
*/
}
