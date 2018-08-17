using System;
using System.Collections.Generic;
using System.Text;
using KiSS4.Gui;
using KiSS4.DB;

namespace KiSS4.Query.MBU
{
    class CtlQueryVmFallgewichtungProduktAktuell : KiSS4.Common.KissQueryControl
    {
        private KiSS4.Gui.KissButtonEdit edtUserID;
        private KiSS4.Gui.KissButtonEdit edtBaPersonID;
        private KiSS4.Gui.KissCheckEdit edtAbweichung;
        private KiSS4.Gui.KissLabel lblSAR;
        private SharpLibrary.WinControls.TabPageEx tpgListe2;
        private KissGrid grdListe2;
        private DevExpress.XtraGrid.Views.Grid.GridView grvVorschlaege;
        private System.ComponentModel.IContainer components;
        private KiSS4.Gui.KissLabel lblMandant;

        #region Constructors

        public CtlQueryVmFallgewichtungProduktAktuell()
        {
            this.InitializeComponent();
        }

        #endregion

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtlQueryVmFallgewichtungProduktAktuell));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.edtUserID = new KiSS4.Gui.KissButtonEdit();
            this.edtBaPersonID = new KiSS4.Gui.KissButtonEdit();
            this.edtAbweichung = new KiSS4.Gui.KissCheckEdit();
            this.lblSAR = new KiSS4.Gui.KissLabel();
            this.lblMandant = new KiSS4.Gui.KissLabel();
            this.tpgListe2 = new SharpLibrary.WinControls.TabPageEx();
            this.grdListe2 = new KiSS4.Gui.KissGrid();
            this.grvVorschlaege = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.qryQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuery1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuery1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xDocument.Properties)).BeginInit();
            this.tabControlSearch.SuspendLayout();
            this.tpgListe.SuspendLayout();
            this.tpgSuchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBaPersonID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtAbweichung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMandant)).BeginInit();
            this.tpgListe2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVorschlaege)).BeginInit();
            this.SuspendLayout();
            // 
            // qryQuery
            // 
            this.qryQuery.SelectStatement = resources.GetString("qryQuery.SelectStatement");
            this.qryQuery.AfterFill += new System.EventHandler(this.qryQuery_AfterFill);
            // 
            // grvQuery1
            // 
            this.grvQuery1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.grvQuery1.Appearance.Empty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvQuery1.Appearance.Empty.Options.UseBackColor = true;
            this.grvQuery1.Appearance.Empty.Options.UseFont = true;
            this.grvQuery1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(215)))));
            this.grvQuery1.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvQuery1.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvQuery1.Appearance.EvenRow.Options.UseFont = true;
            this.grvQuery1.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.Highlight;
            this.grvQuery1.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvQuery1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.grvQuery1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvQuery1.Appearance.FocusedCell.Options.UseFont = true;
            this.grvQuery1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvQuery1.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.grvQuery1.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvQuery1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grvQuery1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvQuery1.Appearance.FocusedRow.Options.UseFont = true;
            this.grvQuery1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvQuery1.Appearance.GroupPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.grvQuery1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvQuery1.Appearance.GroupRow.BackColor = System.Drawing.Color.PeachPuff;
            this.grvQuery1.Appearance.GroupRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.grvQuery1.Appearance.GroupRow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grvQuery1.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvQuery1.Appearance.GroupRow.Options.UseFont = true;
            this.grvQuery1.Appearance.GroupRow.Options.UseForeColor = true;
            this.grvQuery1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Tan;
            this.grvQuery1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Tan;
            this.grvQuery1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.grvQuery1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvQuery1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grvQuery1.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvQuery1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.PowderBlue;
            this.grvQuery1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvQuery1.Appearance.HideSelectionRow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grvQuery1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvQuery1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvQuery1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grvQuery1.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.grvQuery1.Appearance.HorzLine.Options.UseBackColor = true;
            this.grvQuery1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(222)))));
            this.grvQuery1.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvQuery1.Appearance.OddRow.Options.UseBackColor = true;
            this.grvQuery1.Appearance.OddRow.Options.UseFont = true;
            this.grvQuery1.Appearance.Row.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.grvQuery1.Appearance.Row.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvQuery1.Appearance.Row.Options.UseBackColor = true;
            this.grvQuery1.Appearance.Row.Options.UseFont = true;
            this.grvQuery1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(170)))), ((int)(((byte)(74)))));
            this.grvQuery1.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvQuery1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.grvQuery1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvQuery1.Appearance.SelectedRow.Options.UseFont = true;
            this.grvQuery1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grvQuery1.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.grvQuery1.Appearance.VertLine.Options.UseBackColor = true;
            this.grvQuery1.OptionsBehavior.Editable = false;
            this.grvQuery1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.grvQuery1.OptionsNavigation.AutoFocusNewRow = true;
            this.grvQuery1.OptionsNavigation.UseTabKey = false;
            this.grvQuery1.OptionsPrint.AutoWidth = false;
            this.grvQuery1.OptionsPrint.ExpandAllDetails = true;
            this.grvQuery1.OptionsPrint.UsePrintStyles = true;
            this.grvQuery1.OptionsView.ColumnAutoWidth = false;
            this.grvQuery1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvQuery1.OptionsView.ShowGroupPanel = false;
            this.grvQuery1.OptionsView.ShowIndicator = false;
            // 
            // grdQuery1
            // 
            this.grdQuery1.EmbeddedNavigator.Name = "";
            // 
            // xDocument
            // 
            this.xDocument.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.xDocument.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.xDocument.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.xDocument.Properties.Appearance.Options.UseBackColor = true;
            this.xDocument.Properties.Appearance.Options.UseBorderColor = true;
            this.xDocument.Properties.Appearance.Options.UseFont = true;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.Bisque;
            serializableAppearanceObject1.Options.UseBackColor = true;
            this.xDocument.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, ((System.Drawing.Image)(resources.GetObject("xDocument.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Dokument �ffnen")});
            // 
            // ctlGotoFall
            // 
            this.ctlGotoFall.DataMember = "BaPersonID$";
            // 
            // tabControlSearch
            // 
            this.tabControlSearch.Controls.Add(this.tpgListe2);
            this.tabControlSearch.SelectedTabIndex = 1;
            this.tabControlSearch.TabPages.AddRange(new SharpLibrary.WinControls.TabPageEx[] {
            this.tpgListe2});
            this.tabControlSearch.Controls.SetChildIndex(this.tpgSuchen, 0);
            this.tabControlSearch.Controls.SetChildIndex(this.tpgListe2, 0);
            this.tabControlSearch.Controls.SetChildIndex(this.tpgListe, 0);
            // 
            // tpgListe
            // 
            this.tpgListe.Location = new System.Drawing.Point(6, 6);
            // 
            // tpgSuchen
            // 
            this.tpgSuchen.Controls.Add(this.edtUserID);
            this.tpgSuchen.Controls.Add(this.edtBaPersonID);
            this.tpgSuchen.Controls.Add(this.edtAbweichung);
            this.tpgSuchen.Controls.Add(this.lblSAR);
            this.tpgSuchen.Controls.Add(this.lblMandant);
            this.tpgSuchen.Location = new System.Drawing.Point(6, 6);
            this.tpgSuchen.Controls.SetChildIndex(this.searchTitle, 0);
            this.tpgSuchen.Controls.SetChildIndex(this.lblMandant, 0);
            this.tpgSuchen.Controls.SetChildIndex(this.lblSAR, 0);
            this.tpgSuchen.Controls.SetChildIndex(this.edtAbweichung, 0);
            this.tpgSuchen.Controls.SetChildIndex(this.edtBaPersonID, 0);
            this.tpgSuchen.Controls.SetChildIndex(this.edtUserID, 0);
            // 
            // edtUserID
            // 
            this.edtUserID.Location = new System.Drawing.Point(119, 82);
            this.edtUserID.Name = "edtUserID";
            this.edtUserID.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.edtUserID.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtUserID.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtUserID.Properties.Appearance.Options.UseBackColor = true;
            this.edtUserID.Properties.Appearance.Options.UseBorderColor = true;
            this.edtUserID.Properties.Appearance.Options.UseFont = true;
            this.edtUserID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            serializableAppearanceObject2.BackColor = System.Drawing.Color.Bisque;
            serializableAppearanceObject2.Options.UseBackColor = true;
            this.edtUserID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2)});
            this.edtUserID.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.edtUserID.Size = new System.Drawing.Size(200, 24);
            this.edtUserID.TabIndex = 37;
            this.edtUserID.UserModifiedFld += new KiSS4.Gui.UserModifiedFldEventHandler(this.edtUserID_UserModifiedFld);
            // 
            // edtBaPersonID
            // 
            this.edtBaPersonID.Location = new System.Drawing.Point(119, 52);
            this.edtBaPersonID.Name = "edtBaPersonID";
            this.edtBaPersonID.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.edtBaPersonID.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtBaPersonID.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtBaPersonID.Properties.Appearance.Options.UseBackColor = true;
            this.edtBaPersonID.Properties.Appearance.Options.UseBorderColor = true;
            this.edtBaPersonID.Properties.Appearance.Options.UseFont = true;
            this.edtBaPersonID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            serializableAppearanceObject3.BackColor = System.Drawing.Color.Bisque;
            serializableAppearanceObject3.Options.UseBackColor = true;
            this.edtBaPersonID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3)});
            this.edtBaPersonID.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.edtBaPersonID.Size = new System.Drawing.Size(200, 24);
            this.edtBaPersonID.TabIndex = 36;
            this.edtBaPersonID.UserModifiedFld += new KiSS4.Gui.UserModifiedFldEventHandler(this.edtBaPersonID_UserModifiedFld);
            // 
            // edtAbweichung
            // 
            this.edtAbweichung.EditValue = false;
            this.edtAbweichung.Location = new System.Drawing.Point(119, 112);
            this.edtAbweichung.Name = "edtAbweichung";
            this.edtAbweichung.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.edtAbweichung.Properties.Appearance.Options.UseBackColor = true;
            this.edtAbweichung.Properties.Caption = "nur  abweichende, bewilligte Falltypen";
            this.edtAbweichung.Size = new System.Drawing.Size(250, 19);
            this.edtAbweichung.TabIndex = 35;
            // 
            // lblSAR
            // 
            this.lblSAR.Location = new System.Drawing.Point(29, 82);
            this.lblSAR.Name = "lblSAR";
            this.lblSAR.Size = new System.Drawing.Size(130, 24);
            this.lblSAR.TabIndex = 34;
            this.lblSAR.Text = "SAR";
            this.lblSAR.UseCompatibleTextRendering = true;
            // 
            // lblMandant
            // 
            this.lblMandant.Location = new System.Drawing.Point(29, 52);
            this.lblMandant.Name = "lblMandant";
            this.lblMandant.Size = new System.Drawing.Size(130, 24);
            this.lblMandant.TabIndex = 33;
            this.lblMandant.Text = "Mandant";
            this.lblMandant.UseCompatibleTextRendering = true;
            // 
            // tpgListe2
            // 
            this.tpgListe2.Controls.Add(this.grdListe2);
            this.tpgListe2.Location = new System.Drawing.Point(6, 6);
            this.tpgListe2.Name = "tpgListe2";
            this.tpgListe2.Size = new System.Drawing.Size(772, 424);
            this.tpgListe2.TabIndex = 1;
            this.tpgListe2.Title = "Liste2";
            // 
            // grdListe2
            // 
            this.grdListe2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdListe2.DataSource = this.qryQuery;
            this.grdListe2.EmbeddedNavigator.Name = "";
            this.grdListe2.GridStyle = KiSS4.Gui.GridStyleType.ReadOnly;
            this.grdListe2.Location = new System.Drawing.Point(3, 16);
            this.grdListe2.MainView = this.grvVorschlaege;
            this.grdListe2.Name = "grdListe2";
            this.grdListe2.Size = new System.Drawing.Size(766, 392);
            this.grdListe2.TabIndex = 5;
            this.grdListe2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvVorschlaege});
            // 
            // grvVorschlaege
            // 
            this.grvVorschlaege.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.grvVorschlaege.Appearance.Empty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvVorschlaege.Appearance.Empty.Options.UseBackColor = true;
            this.grvVorschlaege.Appearance.Empty.Options.UseFont = true;
            this.grvVorschlaege.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvVorschlaege.Appearance.EvenRow.Options.UseFont = true;
            this.grvVorschlaege.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.Highlight;
            this.grvVorschlaege.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvVorschlaege.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.grvVorschlaege.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvVorschlaege.Appearance.FocusedCell.Options.UseFont = true;
            this.grvVorschlaege.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvVorschlaege.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.grvVorschlaege.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvVorschlaege.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grvVorschlaege.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvVorschlaege.Appearance.FocusedRow.Options.UseFont = true;
            this.grvVorschlaege.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvVorschlaege.Appearance.GroupPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.grvVorschlaege.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvVorschlaege.Appearance.GroupRow.BackColor = System.Drawing.Color.PeachPuff;
            this.grvVorschlaege.Appearance.GroupRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.grvVorschlaege.Appearance.GroupRow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grvVorschlaege.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvVorschlaege.Appearance.GroupRow.Options.UseFont = true;
            this.grvVorschlaege.Appearance.GroupRow.Options.UseForeColor = true;
            this.grvVorschlaege.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Tan;
            this.grvVorschlaege.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Tan;
            this.grvVorschlaege.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.grvVorschlaege.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvVorschlaege.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grvVorschlaege.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvVorschlaege.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.PowderBlue;
            this.grvVorschlaege.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvVorschlaege.Appearance.HideSelectionRow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grvVorschlaege.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvVorschlaege.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvVorschlaege.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grvVorschlaege.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.grvVorschlaege.Appearance.HorzLine.Options.UseBackColor = true;
            this.grvVorschlaege.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvVorschlaege.Appearance.OddRow.Options.UseFont = true;
            this.grvVorschlaege.Appearance.Row.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.grvVorschlaege.Appearance.Row.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvVorschlaege.Appearance.Row.Options.UseBackColor = true;
            this.grvVorschlaege.Appearance.Row.Options.UseFont = true;
            this.grvVorschlaege.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvVorschlaege.Appearance.SelectedRow.Options.UseFont = true;
            this.grvVorschlaege.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.grvVorschlaege.Appearance.VertLine.Options.UseBackColor = true;
            this.grvVorschlaege.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.grvVorschlaege.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.grvVorschlaege.GridControl = this.grdListe2;
            this.grvVorschlaege.Name = "grvVorschlaege";
            this.grvVorschlaege.OptionsBehavior.Editable = false;
            this.grvVorschlaege.OptionsCustomization.AllowFilter = false;
            this.grvVorschlaege.OptionsFilter.UseNewCustomFilterDialog = true;
            this.grvVorschlaege.OptionsNavigation.AutoFocusNewRow = true;
            this.grvVorschlaege.OptionsNavigation.UseTabKey = false;
            this.grvVorschlaege.OptionsView.ColumnAutoWidth = false;
            this.grvVorschlaege.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvVorschlaege.OptionsView.ShowGroupPanel = false;
            this.grvVorschlaege.OptionsView.ShowIndicator = false;
            // 
            // CtlQueryVmFallgewichtungProduktAktuell
            // 
            this.Name = "CtlQueryVmFallgewichtungProduktAktuell";
            ((System.ComponentModel.ISupportInitialize)(this.qryQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuery1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuery1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xDocument.Properties)).EndInit();
            this.tabControlSearch.ResumeLayout(false);
            this.tpgListe.ResumeLayout(false);
            this.tpgSuchen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edtUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBaPersonID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtAbweichung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMandant)).EndInit();
            this.tpgListe2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVorschlaege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #region Private Methods

        private void edtBaPersonID_UserModifiedFld(object sender, KiSS4.Gui.UserModifiedFldEventArgs e)
        {
            string SearchString = edtBaPersonID.Text.Replace("*", "%").Replace("?", "_").Replace(" ", "%");

            if (DBUtil.IsEmpty(SearchString))
            {
                if (e.ButtonClicked)
                {
                    SearchString = "%";
                }
                else
                {
                    edtBaPersonID.EditValue = null;
                    edtBaPersonID.LookupID = null;
                    return;
                }
            }

            KissLookupDialog dlg = new KissLookupDialog();
            e.Cancel = !dlg.SearchData(@"
                select distinct
                    ID = PRS.BaPersonID,
                    Mandant = PRS.NameVorname,
                    Strasse = PRS.WohnsitzStrasseHausNr,
                    Ort     = PRS.WohnsitzPLZOrt
                from FaLeistung FAL
                    inner join vwPerson PRS on PRS.BaPersonID = FAL.BaPersonID
                    left  join XUser BEN on BEN.UserID = FAL.UserID
                where FAL.ModulID = 5
                and FAL.FaProzessCode = 501
                and PRS.NameVorname like {0} + '%'
                order by PRS.NameVorname",
              SearchString,
              e.ButtonClicked, null, null, null);

            if (!e.Cancel)
            {
                edtBaPersonID.EditValue = dlg[1];
                edtBaPersonID.LookupID = dlg[0];
            }
        }

        private void edtUserID_UserModifiedFld(object sender, KiSS4.Gui.UserModifiedFldEventArgs e)
        {
            string SearchString = edtUserID.Text.Replace("*", "%").Replace("?", "_").Replace(" ", "%");

            if (DBUtil.IsEmpty(SearchString))
            {
                if (e.ButtonClicked)
                {
                    SearchString = "%";
                }
                else
                {
                    edtUserID.EditValue = null;
                    edtUserID.LookupID = null;
                    return;
                }
            }

            KissLookupDialog dlg = new KissLookupDialog();
            e.Cancel = !dlg.SearchData(@"
                select ID = UserID, SAR = LastName + isNull(', ' + FirstName,''), [K�rzel] = LogonName
                from   XUser 
                where LastName + isNull(', ' + FirstName,'') like {0} + '%' 
                order by SAR",
              SearchString,
              e.ButtonClicked, null, null, null);

            if (!e.Cancel)
            {
                edtUserID.EditValue = dlg[1];
                edtUserID.LookupID = dlg[0];
            }
        }

        private void qryQuery_AfterFill(object sender, EventArgs e)
        {
            this.grdListe2.DataSource = qryQuery.DataSet.Tables[1];
        }

        #endregion
    }
}