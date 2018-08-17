#region Header

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#endregion

using System;

namespace KiSS4.Klientenbuchhaltung
{
    public class DlgAuswahlKbKostenstelle : KiSS4.Gui.KissDialog
    {
        #region Fields

        private KiSS4.Gui.KissButton btnAbbruch;
        private KiSS4.Gui.KissButton btnDebug;
        private KiSS4.Gui.KissButton btnOK;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresse;
        private DevExpress.XtraGrid.Columns.GridColumn colInstitutionName;
        private DevExpress.XtraGrid.Columns.GridColumn colZahlungsweg;
        private System.ComponentModel.IContainer components;
        private KiSS4.Gui.KissTextEdit edtAdressZusatz;
        private KiSS4.Gui.KissTextEdit edtBankkontoNr;
        private KiSS4.Gui.KissTextEdit edtFilter;
        private KiSS4.Gui.KissTextEdit edtName;
        private KiSS4.Gui.KissTextEdit edtPersonId;
        private KiSS4.Gui.KissTextEdit edtPostkontoNr;
        private KiSS4.Gui.KissGrid grdKreditor;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKreditor;
        private KiSS4.Gui.KissLabel kissLabel1;
        private KiSS4.Gui.KissLabel kissLabel13;
        private KiSS4.Gui.KissLabel kissLabel2;
        private KiSS4.Gui.KissLabel kissLabel3;
        private KiSS4.Gui.KissLabel kissLabel4;
        private KiSS4.Gui.KissLabel lblBankkontoNr;
        private KiSS4.Gui.KissLabel lblEinzahlungsschein;
        private KiSS4.Gui.KissLabel lblPostKonto;
        private KiSS4.DB.SqlQuery qryKbKostenstelle;

        bool firsttime = true;

        #endregion

        #region Constructors

        public DlgAuswahlKbKostenstelle()
        {
            this.InitializeComponent();

            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(DlgAuswahlKbKostenstelle_KeyPress);
        }

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgAuswahlKbKostenstelle));
            this.grdKreditor = new KiSS4.Gui.KissGrid();
            this.qryKbKostenstelle = new KiSS4.DB.SqlQuery(this.components);
            this.grvKreditor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInstitutionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZahlungsweg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edtName = new KiSS4.Gui.KissTextEdit();
            this.edtAdressZusatz = new KiSS4.Gui.KissTextEdit();
            this.kissLabel13 = new KiSS4.Gui.KissLabel();
            this.kissLabel1 = new KiSS4.Gui.KissLabel();
            this.edtPersonId = new KiSS4.Gui.KissTextEdit();
            this.edtPostkontoNr = new KiSS4.Gui.KissTextEdit();
            this.edtBankkontoNr = new KiSS4.Gui.KissTextEdit();
            this.lblEinzahlungsschein = new KiSS4.Gui.KissLabel();
            this.lblBankkontoNr = new KiSS4.Gui.KissLabel();
            this.lblPostKonto = new KiSS4.Gui.KissLabel();
            this.kissLabel2 = new KiSS4.Gui.KissLabel();
            this.kissLabel3 = new KiSS4.Gui.KissLabel();
            this.edtFilter = new KiSS4.Gui.KissTextEdit();
            this.kissLabel4 = new KiSS4.Gui.KissLabel();
            this.btnOK = new KiSS4.Gui.KissButton();
            this.btnAbbruch = new KiSS4.Gui.KissButton();
            this.btnDebug = new KiSS4.Gui.KissButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdKreditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryKbKostenstelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKreditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtAdressZusatz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kissLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kissLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPersonId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPostkontoNr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBankkontoNr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEinzahlungsschein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBankkontoNr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPostKonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kissLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kissLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kissLabel4)).BeginInit();
            this.SuspendLayout();
            // 
            // grdKreditor
            // 
            this.grdKreditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grdKreditor.DataSource = this.qryKbKostenstelle;
            this.grdKreditor.EmbeddedNavigator.Name = "";
            this.grdKreditor.GridStyle = KiSS4.Gui.GridStyleType.ReadOnly;
            this.grdKreditor.Location = new System.Drawing.Point(5, 5);
            this.grdKreditor.MainView = this.grvKreditor;
            this.grdKreditor.Name = "grdKreditor";
            this.grdKreditor.Size = new System.Drawing.Size(766, 257);
            this.grdKreditor.TabIndex = 1;
            this.grdKreditor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKreditor});
            this.grdKreditor.DoubleClick += new System.EventHandler(this.grdKreditor_DoubleClick);
            // 
            // qryKbKostenstelle
            // 
            this.qryKbKostenstelle.HostControl = this;
            this.qryKbKostenstelle.SelectStatement = resources.GetString("qryKbKostenstelle.SelectStatement");
            // 
            // grvKreditor
            // 
            this.grvKreditor.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.grvKreditor.Appearance.Empty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvKreditor.Appearance.Empty.Options.UseBackColor = true;
            this.grvKreditor.Appearance.Empty.Options.UseFont = true;
            this.grvKreditor.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvKreditor.Appearance.EvenRow.Options.UseFont = true;
            this.grvKreditor.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.Highlight;
            this.grvKreditor.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvKreditor.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.grvKreditor.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvKreditor.Appearance.FocusedCell.Options.UseFont = true;
            this.grvKreditor.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvKreditor.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.grvKreditor.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvKreditor.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grvKreditor.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvKreditor.Appearance.FocusedRow.Options.UseFont = true;
            this.grvKreditor.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvKreditor.Appearance.GroupPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.grvKreditor.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvKreditor.Appearance.GroupRow.BackColor = System.Drawing.Color.PeachPuff;
            this.grvKreditor.Appearance.GroupRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.grvKreditor.Appearance.GroupRow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grvKreditor.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvKreditor.Appearance.GroupRow.Options.UseFont = true;
            this.grvKreditor.Appearance.GroupRow.Options.UseForeColor = true;
            this.grvKreditor.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Tan;
            this.grvKreditor.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Tan;
            this.grvKreditor.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.grvKreditor.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvKreditor.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grvKreditor.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvKreditor.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.PowderBlue;
            this.grvKreditor.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvKreditor.Appearance.HideSelectionRow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grvKreditor.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvKreditor.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvKreditor.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grvKreditor.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.grvKreditor.Appearance.HorzLine.Options.UseBackColor = true;
            this.grvKreditor.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvKreditor.Appearance.OddRow.Options.UseFont = true;
            this.grvKreditor.Appearance.Row.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.grvKreditor.Appearance.Row.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvKreditor.Appearance.Row.Options.UseBackColor = true;
            this.grvKreditor.Appearance.Row.Options.UseFont = true;
            this.grvKreditor.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grvKreditor.Appearance.SelectedRow.Options.UseFont = true;
            this.grvKreditor.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.grvKreditor.Appearance.VertLine.Options.UseBackColor = true;
            this.grvKreditor.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.grvKreditor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInstitutionName,
            this.colAdresse,
            this.colZahlungsweg});
            this.grvKreditor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.grvKreditor.GridControl = this.grdKreditor;
            this.grvKreditor.Name = "grvKreditor";
            this.grvKreditor.OptionsBehavior.Editable = false;
            this.grvKreditor.OptionsCustomization.AllowFilter = false;
            this.grvKreditor.OptionsFilter.UseNewCustomFilterDialog = true;
            this.grvKreditor.OptionsNavigation.AutoFocusNewRow = true;
            this.grvKreditor.OptionsNavigation.UseTabKey = false;
            this.grvKreditor.OptionsView.ColumnAutoWidth = false;
            this.grvKreditor.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvKreditor.OptionsView.ShowGroupPanel = false;
            this.grvKreditor.OptionsView.ShowIndicator = false;
            // 
            // colInstitutionName
            // 
            this.colInstitutionName.Caption = "Name";
            this.colInstitutionName.FieldName = "Name";
            this.colInstitutionName.Name = "colInstitutionName";
            this.colInstitutionName.Visible = true;
            this.colInstitutionName.VisibleIndex = 0;
            this.colInstitutionName.Width = 181;
            // 
            // colAdresse
            // 
            this.colAdresse.Caption = "Vorname";
            this.colAdresse.FieldName = "Vorname";
            this.colAdresse.Name = "colAdresse";
            this.colAdresse.Visible = true;
            this.colAdresse.VisibleIndex = 1;
            this.colAdresse.Width = 198;
            // 
            // colZahlungsweg
            // 
            this.colZahlungsweg.Caption = "ID";
            this.colZahlungsweg.FieldName = "ID";
            this.colZahlungsweg.Name = "colZahlungsweg";
            this.colZahlungsweg.Visible = true;
            this.colZahlungsweg.VisibleIndex = 2;
            this.colZahlungsweg.Width = 364;
            // 
            // edtName
            // 
            this.edtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtName.DataMember = "KbKostenStelleID";
            this.edtName.DataSource = this.qryKbKostenstelle;
            this.edtName.EditMode = Kiss.Interfaces.UI.EditModeType.ReadOnly;
            this.edtName.Location = new System.Drawing.Point(90, 294);
            this.edtName.Name = "edtName";
            this.edtName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.edtName.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtName.Properties.Appearance.Options.UseBackColor = true;
            this.edtName.Properties.Appearance.Options.UseBorderColor = true;
            this.edtName.Properties.Appearance.Options.UseFont = true;
            this.edtName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.edtName.Properties.MaxLength = 100;
            this.edtName.Properties.Name = "editName.Properties";
            this.edtName.Properties.ReadOnly = true;
            this.edtName.Size = new System.Drawing.Size(270, 24);
            this.edtName.TabIndex = 569;
            // 
            // edtAdressZusatz
            // 
            this.edtAdressZusatz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtAdressZusatz.DataMember = "Nr";
            this.edtAdressZusatz.DataSource = this.qryKbKostenstelle;
            this.edtAdressZusatz.EditMode = Kiss.Interfaces.UI.EditModeType.ReadOnly;
            this.edtAdressZusatz.Location = new System.Drawing.Point(90, 317);
            this.edtAdressZusatz.Name = "edtAdressZusatz";
            this.edtAdressZusatz.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.edtAdressZusatz.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtAdressZusatz.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtAdressZusatz.Properties.Appearance.Options.UseBackColor = true;
            this.edtAdressZusatz.Properties.Appearance.Options.UseBorderColor = true;
            this.edtAdressZusatz.Properties.Appearance.Options.UseFont = true;
            this.edtAdressZusatz.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.edtAdressZusatz.Properties.MaxLength = 200;
            this.edtAdressZusatz.Properties.Name = "kissTextEdit12.Properties";
            this.edtAdressZusatz.Properties.ReadOnly = true;
            this.edtAdressZusatz.Size = new System.Drawing.Size(270, 24);
            this.edtAdressZusatz.TabIndex = 570;
            // 
            // kissLabel13
            // 
            this.kissLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kissLabel13.Location = new System.Drawing.Point(5, 317);
            this.kissLabel13.Name = "kissLabel13";
            this.kissLabel13.Size = new System.Drawing.Size(80, 24);
            this.kissLabel13.TabIndex = 582;
            this.kissLabel13.Text = "Nummer";
            this.kissLabel13.UseCompatibleTextRendering = true;
            // 
            // kissLabel1
            // 
            this.kissLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kissLabel1.Location = new System.Drawing.Point(5, 294);
            this.kissLabel1.Name = "kissLabel1";
            this.kissLabel1.Size = new System.Drawing.Size(80, 24);
            this.kissLabel1.TabIndex = 583;
            this.kissLabel1.Text = "ID";
            this.kissLabel1.UseCompatibleTextRendering = true;
            // 
            // edtPersonId
            // 
            this.edtPersonId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtPersonId.DataMember = "PersonID";
            this.edtPersonId.DataSource = this.qryKbKostenstelle;
            this.edtPersonId.EditMode = Kiss.Interfaces.UI.EditModeType.ReadOnly;
            this.edtPersonId.Location = new System.Drawing.Point(481, 293);
            this.edtPersonId.Name = "edtPersonId";
            this.edtPersonId.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.edtPersonId.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtPersonId.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtPersonId.Properties.Appearance.Options.UseBackColor = true;
            this.edtPersonId.Properties.Appearance.Options.UseBorderColor = true;
            this.edtPersonId.Properties.Appearance.Options.UseFont = true;
            this.edtPersonId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.edtPersonId.Properties.MaxLength = 20;
            this.edtPersonId.Properties.Name = "kissTextEdit14.Properties";
            this.edtPersonId.Properties.ReadOnly = true;
            this.edtPersonId.Size = new System.Drawing.Size(290, 24);
            this.edtPersonId.TabIndex = 587;
            // 
            // edtPostkontoNr
            // 
            this.edtPostkontoNr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtPostkontoNr.DataMember = "Name";
            this.edtPostkontoNr.DataSource = this.qryKbKostenstelle;
            this.edtPostkontoNr.EditMode = Kiss.Interfaces.UI.EditModeType.ReadOnly;
            this.edtPostkontoNr.Location = new System.Drawing.Point(481, 316);
            this.edtPostkontoNr.Name = "edtPostkontoNr";
            this.edtPostkontoNr.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.edtPostkontoNr.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtPostkontoNr.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtPostkontoNr.Properties.Appearance.Options.UseBackColor = true;
            this.edtPostkontoNr.Properties.Appearance.Options.UseBorderColor = true;
            this.edtPostkontoNr.Properties.Appearance.Options.UseFont = true;
            this.edtPostkontoNr.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.edtPostkontoNr.Properties.MaxLength = 20;
            this.edtPostkontoNr.Properties.Name = "kissTextEdit14.Properties";
            this.edtPostkontoNr.Properties.ReadOnly = true;
            this.edtPostkontoNr.Size = new System.Drawing.Size(290, 24);
            this.edtPostkontoNr.TabIndex = 587;
            // 
            // edtBankkontoNr
            // 
            this.edtBankkontoNr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtBankkontoNr.DataMember = "Vorname";
            this.edtBankkontoNr.DataSource = this.qryKbKostenstelle;
            this.edtBankkontoNr.EditMode = Kiss.Interfaces.UI.EditModeType.ReadOnly;
            this.edtBankkontoNr.Location = new System.Drawing.Point(481, 339);
            this.edtBankkontoNr.Name = "edtBankkontoNr";
            this.edtBankkontoNr.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.edtBankkontoNr.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtBankkontoNr.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtBankkontoNr.Properties.Appearance.Options.UseBackColor = true;
            this.edtBankkontoNr.Properties.Appearance.Options.UseBorderColor = true;
            this.edtBankkontoNr.Properties.Appearance.Options.UseFont = true;
            this.edtBankkontoNr.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.edtBankkontoNr.Properties.MaxLength = 50;
            this.edtBankkontoNr.Properties.Name = "kissTextEdit13.Properties";
            this.edtBankkontoNr.Properties.ReadOnly = true;
            this.edtBankkontoNr.Size = new System.Drawing.Size(208, 24);
            this.edtBankkontoNr.TabIndex = 588;
            // 
            // lblEinzahlungsschein
            // 
            this.lblEinzahlungsschein.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEinzahlungsschein.Location = new System.Drawing.Point(379, 294);
            this.lblEinzahlungsschein.Name = "lblEinzahlungsschein";
            this.lblEinzahlungsschein.Size = new System.Drawing.Size(100, 23);
            this.lblEinzahlungsschein.TabIndex = 594;
            this.lblEinzahlungsschein.Text = "ID";
            this.lblEinzahlungsschein.UseCompatibleTextRendering = true;
            // 
            // lblBankkontoNr
            // 
            this.lblBankkontoNr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBankkontoNr.Location = new System.Drawing.Point(379, 340);
            this.lblBankkontoNr.Name = "lblBankkontoNr";
            this.lblBankkontoNr.Size = new System.Drawing.Size(100, 23);
            this.lblBankkontoNr.TabIndex = 596;
            this.lblBankkontoNr.Text = "Vorname";
            this.lblBankkontoNr.UseCompatibleTextRendering = true;
            // 
            // lblPostKonto
            // 
            this.lblPostKonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPostKonto.Location = new System.Drawing.Point(379, 317);
            this.lblPostKonto.Name = "lblPostKonto";
            this.lblPostKonto.Size = new System.Drawing.Size(100, 23);
            this.lblPostKonto.TabIndex = 597;
            this.lblPostKonto.Text = "Name";
            this.lblPostKonto.UseCompatibleTextRendering = true;
            // 
            // kissLabel2
            // 
            this.kissLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kissLabel2.LabelStyle = KiSS4.Gui.LabelStyleType.DataView;
            this.kissLabel2.Location = new System.Drawing.Point(90, 269);
            this.kissLabel2.Name = "kissLabel2";
            this.kissLabel2.Size = new System.Drawing.Size(100, 16);
            this.kissLabel2.TabIndex = 600;
            this.kissLabel2.Text = "Kostenstelle";
            this.kissLabel2.UseCompatibleTextRendering = true;
            // 
            // kissLabel3
            // 
            this.kissLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kissLabel3.LabelStyle = KiSS4.Gui.LabelStyleType.DataView;
            this.kissLabel3.Location = new System.Drawing.Point(481, 269);
            this.kissLabel3.Name = "kissLabel3";
            this.kissLabel3.Size = new System.Drawing.Size(100, 16);
            this.kissLabel3.TabIndex = 601;
            this.kissLabel3.Text = "Person";
            this.kissLabel3.UseCompatibleTextRendering = true;
            // 
            // edtFilter
            // 
            this.edtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtFilter.Location = new System.Drawing.Point(481, 439);
            this.edtFilter.Name = "edtFilter";
            this.edtFilter.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.edtFilter.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtFilter.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtFilter.Properties.Appearance.Options.UseBackColor = true;
            this.edtFilter.Properties.Appearance.Options.UseBorderColor = true;
            this.edtFilter.Properties.Appearance.Options.UseFont = true;
            this.edtFilter.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.edtFilter.Properties.MaxLength = 50;
            this.edtFilter.Properties.Name = "kissTextEdit16.Properties";
            this.edtFilter.Size = new System.Drawing.Size(290, 24);
            this.edtFilter.TabIndex = 602;
            this.edtFilter.TabStop = false;
            this.edtFilter.EditValueChanged += new System.EventHandler(this.edtFilter_EditValueChanged);
            this.edtFilter.Click += new System.EventHandler(this.edtFilter_Click);
            // 
            // kissLabel4
            // 
            this.kissLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kissLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.kissLabel4.LabelStyle = KiSS4.Gui.LabelStyleType.Custom;
            this.kissLabel4.Location = new System.Drawing.Point(379, 439);
            this.kissLabel4.Name = "kissLabel4";
            this.kissLabel4.Size = new System.Drawing.Size(100, 24);
            this.kissLabel4.TabIndex = 603;
            this.kissLabel4.Text = "Filter (Name)";
            this.kissLabel4.UseCompatibleTextRendering = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(585, 478);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 24);
            this.btnOK.TabIndex = 604;
            this.btnOK.Text = "OK";
            this.btnOK.UseCompatibleTextRendering = true;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbruch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbbruch.Location = new System.Drawing.Point(681, 478);
            this.btnAbbruch.Name = "btnAbbruch";
            this.btnAbbruch.Size = new System.Drawing.Size(90, 24);
            this.btnAbbruch.TabIndex = 605;
            this.btnAbbruch.Text = "Abbruch";
            this.btnAbbruch.UseCompatibleTextRendering = true;
            this.btnAbbruch.UseVisualStyleBackColor = true;
            // 
            // btnDebug
            // 
            this.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebug.Location = new System.Drawing.Point(32, 464);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(90, 24);
            this.btnDebug.TabIndex = 606;
            this.btnDebug.Text = "D E B U G";
            this.btnDebug.UseCompatibleTextRendering = true;
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Visible = false;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // DlgAuswahlKbKostenstelle
            // 
            this.AcceptButton = this.btnOK;
            this.ActiveSQLQuery = this.qryKbKostenstelle;
            this.CancelButton = this.btnAbbruch;
            this.ClientSize = new System.Drawing.Size(778, 507);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnAbbruch);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.kissLabel4);
            this.Controls.Add(this.edtFilter);
            this.Controls.Add(this.kissLabel3);
            this.Controls.Add(this.kissLabel2);
            this.Controls.Add(this.lblPostKonto);
            this.Controls.Add(this.lblBankkontoNr);
            this.Controls.Add(this.lblEinzahlungsschein);
            this.Controls.Add(this.edtBankkontoNr);
            this.Controls.Add(this.edtPostkontoNr);
            this.Controls.Add(this.edtPersonId);
            this.Controls.Add(this.kissLabel1);
            this.Controls.Add(this.kissLabel13);
            this.Controls.Add(this.edtAdressZusatz);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.grdKreditor);
            this.Name = "DlgAuswahlKbKostenstelle";
            this.Text = "Auswahl Kostenstelle";
            ((System.ComponentModel.ISupportInitialize)(this.grdKreditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryKbKostenstelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKreditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtAdressZusatz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kissLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kissLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPersonId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPostkontoNr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBankkontoNr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEinzahlungsschein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBankkontoNr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPostKonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kissLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kissLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kissLabel4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        #region Dispose

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if ((components != null))
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion

        #region Public Properties

        public int Count
        {
            get { return qryKbKostenstelle.Count; }
        }

        public object this[string ColumnName]
        {
            get
            {
                return qryKbKostenstelle[ColumnName];
            }
        }

        #endregion

        #region Public Methods

        //public void SucheBaZahlungsweg(Belegleser beleg)
        //{
        //    qryKbKostenstelle.Fill(qryBaZahlungsweg.SelectStatement,beleg.KontoNummer.Replace('-','%'));
        //}
        public void SucheKostenstelle(String suchbegriff)
        {
            grdKreditor.DataSource = null;
            qryKbKostenstelle.Fill(qryKbKostenstelle.SelectStatement, suchbegriff.Replace(' ','%') + "%");
            qryKbKostenstelle.DataTable.DefaultView.RowFilter = "Name1 like '%'";
            grdKreditor.DataSource = qryKbKostenstelle;
        }

        #endregion

        #region Private Methods

        private void DlgAuswahlKbKostenstelle_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (firsttime && edtFilter.Text == "")
            {
                firsttime = false;
                edtFilter.Text = e.KeyChar.ToString();
                edtFilter.Focus();
                edtFilter.SelectionStart = 1;
            }
        }

        private void btnDebug_Click(object sender, System.EventArgs e)
        {
            SucheKostenstelle("a");
        }

        private void edtFilter_Click(object sender, System.EventArgs e)
        {
            firsttime = false;
        }

        private void edtFilter_EditValueChanged(object sender, System.EventArgs e)
        {
            string filterText = edtFilter.Text;

            if(!String.IsNullOrEmpty(filterText))
            {
                qryKbKostenstelle.DataTable.DefaultView.RowFilter = "Name1 like '%" + filterText + "%'";
            }
        }

        private void grdKreditor_DoubleClick(object sender, System.EventArgs e)
        {
            if (qryKbKostenstelle.Count > 1)
            {
                btnOK.PerformClick();
            }
        }

        #endregion
    }
}