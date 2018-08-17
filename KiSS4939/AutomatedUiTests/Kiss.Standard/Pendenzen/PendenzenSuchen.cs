﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace AutomatedUiTests.Pendenzen
{
    /// <summary>
    /// The PendenzenSuchen recording.
    /// </summary>
    [TestModule("795175b8-5f54-4dc4-8ff2-c48d64f8601f", ModuleType.Recording, 1)]
    public partial class PendenzenSuchen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutomatedUiTests.AutomatedUiTestsRepository repository.
        /// </summary>
        public static AutomatedUiTests.AutomatedUiTestsRepository repo = AutomatedUiTests.AutomatedUiTestsRepository.Instance;

        static PendenzenSuchen instance = new PendenzenSuchen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PendenzenSuchen()
        {
            varCreator = "biag_admin";
            varReceiver = "biag_admin";
            varSubject = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PendenzenSuchen Instance
        {
            get { return instance; }
        }

#region Variables

        string _varCreator;

        /// <summary>
        /// Gets or sets the value of variable varCreator.
        /// </summary>
        [TestVariable("3cee39e6-e089-4548-848a-bccccf6032ee")]
        public string varCreator
        {
            get { return _varCreator; }
            set { _varCreator = value; }
        }

        string _varReceiver;

        /// <summary>
        /// Gets or sets the value of variable varReceiver.
        /// </summary>
        [TestVariable("8031a252-c0a7-4875-99fe-97faa860b188")]
        public string varReceiver
        {
            get { return _varReceiver; }
            set { _varReceiver = value; }
        }

        string _varSubject;

        /// <summary>
        /// Gets or sets the value of variable varSubject.
        /// </summary>
        [TestVariable("f671f0c0-f309-4913-a76e-a7b93709737a")]
        public string varSubject
        {
            get { return _varSubject; }
            set { _varSubject = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "4.1.4")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "4.1.4")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KiSS.PendenzenSuchen' at Center.", repo.KiSS.PendenzenSuchenInfo, new RecordItemIndex(0));
            repo.KiSS.PendenzenSuchen.Click(100);
            Delay.Milliseconds(0);
            
            SelectTabSuchen();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KiSS.CtlPendenzenVerwaltung.edtSucheSubject' at Center.", repo.KiSS.CtlPendenzenVerwaltung.edtSucheSubjectInfo, new RecordItemIndex(2));
            repo.KiSS.CtlPendenzenVerwaltung.edtSucheSubject.Click(100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable $varSubject with focus on 'KiSS.CtlPendenzenVerwaltung.edtSucheSubject'.", repo.KiSS.CtlPendenzenVerwaltung.edtSucheSubjectInfo, new RecordItemIndex(3));
            repo.KiSS.CtlPendenzenVerwaltung.edtSucheSubject.PressKeys(varSubject);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KiSS.CtlPendenzenVerwaltung.edtSucheSenderID' at Center.", repo.KiSS.CtlPendenzenVerwaltung.edtSucheSenderIDInfo, new RecordItemIndex(4));
            repo.KiSS.CtlPendenzenVerwaltung.edtSucheSenderID.Click(100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable $varCreator with focus on 'KiSS.CtlPendenzenVerwaltung.edtSucheSenderID'.", repo.KiSS.CtlPendenzenVerwaltung.edtSucheSenderIDInfo, new RecordItemIndex(5));
            repo.KiSS.CtlPendenzenVerwaltung.edtSucheSenderID.PressKeys(varCreator);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KiSS.CtlPendenzenVerwaltung.edtSucheReceiverID' at Center.", repo.KiSS.CtlPendenzenVerwaltung.edtSucheReceiverIDInfo, new RecordItemIndex(6));
            repo.KiSS.CtlPendenzenVerwaltung.edtSucheReceiverID.Click(100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable $varReceiver with focus on 'KiSS.CtlPendenzenVerwaltung.edtSucheReceiverID'.", repo.KiSS.CtlPendenzenVerwaltung.edtSucheReceiverIDInfo, new RecordItemIndex(7));
            repo.KiSS.CtlPendenzenVerwaltung.edtSucheReceiverID.PressKeys(varReceiver);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F3}' with focus on 'KiSS.CtlPendenzenVerwaltung.TabControlSearch'.", repo.KiSS.CtlPendenzenVerwaltung.TabControlSearchInfo, new RecordItemIndex(8));
            repo.KiSS.CtlPendenzenVerwaltung.TabControlSearch.PressKeys("{F3}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'KiSS.CtlPendenzenVerwaltung.SubjectRow1'.", repo.KiSS.CtlPendenzenVerwaltung.SubjectRow1Info, new RecordItemIndex(9));
            Validate.Exists(repo.KiSS.CtlPendenzenVerwaltung.SubjectRow1Info);
            Delay.Milliseconds(0);
            
            ValidateSubject();
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
}