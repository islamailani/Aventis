#region Header

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#endregion

using System;
using System.Windows.Forms;
using KiSS4.Common;
using KiSS4.DB;

namespace KiSS4.Inkasso.ZH
{
    public class DlgNeueAnspruchsberechnung : KiSS4.Gui.KissDialog
    {
        #region Fields

        // Letzte Bearbeitung
        // 30.10.2007 : sozheo : neu
        // ------------------------------------------------------------------
        public int FaFallID;
        public KiSS4.Gui.KissTextEdit edtBezeichnung;
        public KiSS4.Gui.KissDateEdit edtDatum;
        public KiSS4.Gui.KissCalcEdit edtLohn1;
        public KiSS4.Gui.KissCalcEdit edtLohn2;
        public KiSS4.Gui.KissLabel lblLohn1;
        public KiSS4.Gui.KissLabel lblLohn2;

        private KiSS4.Gui.KissButton btnCancel;
        private KiSS4.Gui.KissButton btnCopy;
        private KiSS4.Gui.KissLabel lblBezeichnung;
        private KiSS4.Gui.KissLabel lblDatum;
        private KiSS4.Gui.KissLabel lblTitel;

        #endregion

        #region Constructors

        public DlgNeueAnspruchsberechnung()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.edtBezeichnung = new KiSS4.Gui.KissTextEdit();
            this.edtDatum = new KiSS4.Gui.KissDateEdit();
            this.edtLohn1 = new KiSS4.Gui.KissCalcEdit();
            this.lblTitel = new KiSS4.Gui.KissLabel();
            this.edtLohn2 = new KiSS4.Gui.KissCalcEdit();
            this.btnCopy = new KiSS4.Gui.KissButton();
            this.lblBezeichnung = new KiSS4.Gui.KissLabel();
            this.btnCancel = new KiSS4.Gui.KissButton();
            this.lblDatum = new KiSS4.Gui.KissLabel();
            this.lblLohn1 = new KiSS4.Gui.KissLabel();
            this.lblLohn2 = new KiSS4.Gui.KissLabel();
            ((System.ComponentModel.ISupportInitialize)(this.edtBezeichnung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDatum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLohn1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLohn2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBezeichnung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDatum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLohn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLohn2)).BeginInit();
            this.SuspendLayout();
            //
            // edtBezeichnung
            //
            this.edtBezeichnung.Location = new System.Drawing.Point(129, 60);
            this.edtBezeichnung.Name = "edtBezeichnung";
            this.edtBezeichnung.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.edtBezeichnung.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtBezeichnung.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtBezeichnung.Properties.Appearance.Options.UseBackColor = true;
            this.edtBezeichnung.Properties.Appearance.Options.UseBorderColor = true;
            this.edtBezeichnung.Properties.Appearance.Options.UseFont = true;
            this.edtBezeichnung.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.edtBezeichnung.Size = new System.Drawing.Size(334, 24);
            this.edtBezeichnung.TabIndex = 0;
            //
            // edtDatum
            //
            this.edtDatum.EditValue = null;
            this.edtDatum.Location = new System.Drawing.Point(129, 90);
            this.edtDatum.Name = "edtDatum";
            this.edtDatum.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.edtDatum.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.edtDatum.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtDatum.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtDatum.Properties.Appearance.Options.UseBackColor = true;
            this.edtDatum.Properties.Appearance.Options.UseBorderColor = true;
            this.edtDatum.Properties.Appearance.Options.UseFont = true;
            this.edtDatum.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.edtDatum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                        new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtDatum.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.edtDatum.Properties.ShowToday = false;
            this.edtDatum.Size = new System.Drawing.Size(115, 24);
            this.edtDatum.TabIndex = 1;
            //
            // edtLohn1
            //
            this.edtLohn1.Location = new System.Drawing.Point(129, 120);
            this.edtLohn1.Name = "edtLohn1";
            this.edtLohn1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.edtLohn1.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.edtLohn1.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtLohn1.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtLohn1.Properties.Appearance.Options.UseBackColor = true;
            this.edtLohn1.Properties.Appearance.Options.UseBorderColor = true;
            this.edtLohn1.Properties.Appearance.Options.UseFont = true;
            this.edtLohn1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.edtLohn1.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.edtLohn1.Properties.DisplayFormat.FormatString = "N2";
            this.edtLohn1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.edtLohn1.Properties.EditFormat.FormatString = "N2";
            this.edtLohn1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.edtLohn1.Size = new System.Drawing.Size(100, 24);
            this.edtLohn1.TabIndex = 2;
            //
            // lblTitel
            //
            this.lblTitel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitel.LabelStyle = KiSS4.Gui.LabelStyleType.Custom;
            this.lblTitel.Location = new System.Drawing.Point(15, 21);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(387, 23);
            this.lblTitel.TabIndex = 2;
            this.lblTitel.Text = "Neue Anspruchsberechnung";
            this.lblTitel.UseCompatibleTextRendering = true;
            //
            // edtLohn2
            //
            this.edtLohn2.Location = new System.Drawing.Point(129, 150);
            this.edtLohn2.Name = "edtLohn2";
            this.edtLohn2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.edtLohn2.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.edtLohn2.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtLohn2.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtLohn2.Properties.Appearance.Options.UseBackColor = true;
            this.edtLohn2.Properties.Appearance.Options.UseBorderColor = true;
            this.edtLohn2.Properties.Appearance.Options.UseFont = true;
            this.edtLohn2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.edtLohn2.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.edtLohn2.Properties.DisplayFormat.FormatString = "N2";
            this.edtLohn2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.edtLohn2.Properties.EditFormat.FormatString = "N2";
            this.edtLohn2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.edtLohn2.Size = new System.Drawing.Size(100, 24);
            this.edtLohn2.TabIndex = 3;
            //
            // btnCopy
            //
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(129, 194);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(202, 24);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "neue Berechnung erstellen";
            this.btnCopy.UseCompatibleTextRendering = true;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            //
            // lblBezeichnung
            //
            this.lblBezeichnung.Location = new System.Drawing.Point(19, 60);
            this.lblBezeichnung.Name = "lblBezeichnung";
            this.lblBezeichnung.Size = new System.Drawing.Size(100, 23);
            this.lblBezeichnung.TabIndex = 4;
            this.lblBezeichnung.Text = "Bezeichnung";
            this.lblBezeichnung.UseCompatibleTextRendering = true;
            //
            // btnCancel
            //
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(346, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 24);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseCompatibleTextRendering = true;
            this.btnCancel.UseVisualStyleBackColor = false;
            //
            // lblDatum
            //
            this.lblDatum.Location = new System.Drawing.Point(19, 90);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(100, 23);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Berechnung ab";
            this.lblDatum.UseCompatibleTextRendering = true;
            //
            // lblLohn1
            //
            this.lblLohn1.Location = new System.Drawing.Point(19, 120);
            this.lblLohn1.Name = "lblLohn1";
            this.lblLohn1.Size = new System.Drawing.Size(100, 24);
            this.lblLohn1.TabIndex = 16;
            this.lblLohn1.Text = "Lohn 1. Verdiener";
            this.lblLohn1.UseCompatibleTextRendering = true;
            //
            // lblLohn2
            //
            this.lblLohn2.Location = new System.Drawing.Point(19, 150);
            this.lblLohn2.Name = "lblLohn2";
            this.lblLohn2.Size = new System.Drawing.Size(100, 24);
            this.lblLohn2.TabIndex = 17;
            this.lblLohn2.Text = "Lohn 2. Verdiener";
            this.lblLohn2.UseCompatibleTextRendering = true;
            //
            // DlgNeueAnspruchsberechnung
            //
            this.ClientSize = new System.Drawing.Size(484, 241);
            this.Controls.Add(this.lblLohn2);
            this.Controls.Add(this.lblLohn1);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblBezeichnung);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.edtLohn2);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.edtLohn1);
            this.Controls.Add(this.edtDatum);
            this.Controls.Add(this.edtBezeichnung);
            this.Name = "DlgNeueAnspruchsberechnung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.edtBezeichnung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDatum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLohn1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLohn2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBezeichnung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDatum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLohn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLohn2)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        #region Private Methods

        private void btnCopy_Click(object sender, System.EventArgs e)
        {
            // Letzte Bearbeitung
            // 30.10.2007 : sozheo : neu
            // 16.03.2008 : sozheo : Kopieren korrigiert
            // ------------------------------------------------------------------

            if (Utils.ConvertToString(edtBezeichnung.EditValue) == "")
            {
              KissMsg.ShowInfo("Die Bezeichnung darf nicht leer sein.");
              return;
            }

            if (DBUtil.IsEmpty(edtDatum.EditValue))
            {
              KissMsg.ShowInfo("Das Datum darf nicht leer sein.");
              return;
            }

            // Kontrollle, dass jedes Datum nur einmal vorkommt
            /*
            SqlQuery qry = DBUtil.OpenSQL(@"
              select Count(*) as Anzahl from AmAnspruchsberechnung A
                Left outer join FaLeistung L on L.FaLeistungID=A.FaLeistungID
              where L.FaFallID = {0}
                and A.BerechnungDatumAb = {1}",
              FaFallID,
              edtDatum.DateTime);

            int Anzahl = Utils.ConvertToInt(qry["Anzahl"]);
            if (Anzahl > 0)
            {
              KissMsg.ShowInfo("CtlAmAnspruchsberechnung", "BerechnungDatumExistiert",
                "Es existiert bereits eine Anspruchsberechnung mit dem gleichen Berechnung-ab-Datum.\r\n"+
                "W�hlen Sie zuerst ein anderes Datum.");
              return;
            }
            */

            Decimal Betrag = Utils.ConvertToDecimal(edtLohn1.EditValue);
            if (Betrag < 0 && edtLohn1.Visible)
            {
              KissMsg.ShowInfo("Der Lohnbetrag darf nicht negativ sein (1. Verdiener).");
              return;
            }

            Betrag = Utils.ConvertToDecimal(edtLohn2.EditValue);
            if (Betrag < 0 && edtLohn2.Visible)
            {
              KissMsg.ShowInfo("Der Lohnbetrag darf nicht negativ sein (2. Verdiener).");
              return;
            }

            this.DialogResult = DialogResult.OK;
        }

        #endregion
    }
}