#region Header

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.832
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#endregion

using System;
using KiSS4.DB;
using KiSS4.Gui;

namespace KiSS4.Common.ZH
{
    public class CtlFallFusion : KiSS4.Gui.KissUserControl
    {
        #region Fields

        private KiSS4.Gui.KissButton btnFusionieren;
        private KiSS4.Gui.KissButtonEdit edtQuellfall;
        private KiSS4.Gui.KissButtonEdit edtZielfall;
        private KiSS4.Gui.KissLabel lblQuellfall;
        private KiSS4.Gui.KissLabel lblZielfall;

        #endregion

        #region Constructors

        public CtlFallFusion()
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.edtQuellfall = new KiSS4.Gui.KissButtonEdit();
            this.lblQuellfall = new KiSS4.Gui.KissLabel();
            this.edtZielfall = new KiSS4.Gui.KissButtonEdit();
            this.lblZielfall = new KiSS4.Gui.KissLabel();
            this.btnFusionieren = new KiSS4.Gui.KissButton();
            ((System.ComponentModel.ISupportInitialize)(this.edtQuellfall.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuellfall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtZielfall.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblZielfall)).BeginInit();
            this.SuspendLayout();
            //
            // edtQuellfall
            //
            this.edtQuellfall.Location = new System.Drawing.Point(71, 25);
            this.edtQuellfall.Name = "edtQuellfall";
            this.edtQuellfall.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.edtQuellfall.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtQuellfall.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtQuellfall.Properties.Appearance.Options.UseBackColor = true;
            this.edtQuellfall.Properties.Appearance.Options.UseBorderColor = true;
            this.edtQuellfall.Properties.Appearance.Options.UseFont = true;
            this.edtQuellfall.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.edtQuellfall.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                        new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtQuellfall.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.edtQuellfall.Size = new System.Drawing.Size(323, 24);
            this.edtQuellfall.TabIndex = 0;
            this.edtQuellfall.UserModifiedFld += new KiSS4.Gui.UserModifiedFldEventHandler(this.edtQuellfall_UserModifiedFld);
            //
            // lblQuellfall
            //
            this.lblQuellfall.Location = new System.Drawing.Point(13, 25);
            this.lblQuellfall.Name = "lblQuellfall";
            this.lblQuellfall.Size = new System.Drawing.Size(52, 24);
            this.lblQuellfall.TabIndex = 1;
            this.lblQuellfall.Text = "Quell-Fall";
            this.lblQuellfall.UseCompatibleTextRendering = true;
            //
            // edtZielfall
            //
            this.edtZielfall.Location = new System.Drawing.Point(573, 25);
            this.edtZielfall.Name = "edtZielfall";
            this.edtZielfall.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.edtZielfall.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtZielfall.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtZielfall.Properties.Appearance.Options.UseBackColor = true;
            this.edtZielfall.Properties.Appearance.Options.UseBorderColor = true;
            this.edtZielfall.Properties.Appearance.Options.UseFont = true;
            this.edtZielfall.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.Bisque;
            serializableAppearanceObject1.Options.UseBackColor = true;
            this.edtZielfall.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                        new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1)});
            this.edtZielfall.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.edtZielfall.Size = new System.Drawing.Size(323, 24);
            this.edtZielfall.TabIndex = 2;
            this.edtZielfall.UserModifiedFld += new KiSS4.Gui.UserModifiedFldEventHandler(this.edtZielfall_UserModifiedFld);
            //
            // lblZielfall
            //
            this.lblZielfall.Location = new System.Drawing.Point(515, 25);
            this.lblZielfall.Name = "lblZielfall";
            this.lblZielfall.Size = new System.Drawing.Size(52, 24);
            this.lblZielfall.TabIndex = 3;
            this.lblZielfall.Text = "Ziel-Fall";
            this.lblZielfall.UseCompatibleTextRendering = true;
            //
            // btnFusionieren
            //
            this.btnFusionieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFusionieren.IconID = 13;
            this.btnFusionieren.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFusionieren.Location = new System.Drawing.Point(410, 25);
            this.btnFusionieren.Name = "btnFusionieren";
            this.btnFusionieren.Size = new System.Drawing.Size(99, 24);
            this.btnFusionieren.TabIndex = 4;
            this.btnFusionieren.Text = "Fusionieren";
            this.btnFusionieren.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFusionieren.UseCompatibleTextRendering = true;
            this.btnFusionieren.UseVisualStyleBackColor = false;
            this.btnFusionieren.Click += new System.EventHandler(this.btnFusionieren_Click);
            //
            // CtlFallFusion
            //
            this.Controls.Add(this.btnFusionieren);
            this.Controls.Add(this.lblZielfall);
            this.Controls.Add(this.edtZielfall);
            this.Controls.Add(this.lblQuellfall);
            this.Controls.Add(this.edtQuellfall);
            this.Name = "CtlFallFusion";
            this.Size = new System.Drawing.Size(908, 389);
            ((System.ComponentModel.ISupportInitialize)(this.edtQuellfall.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuellfall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtZielfall.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblZielfall)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        #region Private Methods

        private void btnFusionieren_Click(object sender, System.EventArgs e)
        {
            if( DBUtil.IsEmpty(edtQuellfall.LookupID) || DBUtil.IsEmpty(edtZielfall.LookupID) )
            {
                KissMsg.ShowError("CtlFallFusion", "FallLeer", "Bitte Quell- und Zielfall ausw�hlen");
                return;
            }

            if( !KissMsg.ShowQuestion("CtlFallFusion", "PersonWirklichL�schen", "Wollen Sie die den Fall {0} in den Fall {1} fusionieren?", 0, 0, true, edtQuellfall.LookupID, edtZielfall.LookupID) )
                return;

            try
            {
                Session.BeginTransaction();
                DBUtil.ExecSQLThrowingException("exec [spFaFallFusion] {0}, {1}, {2}, {3}", edtQuellfall.LookupID, edtZielfall.LookupID, Session.User.UserID, Session.User["OrgUnitId"]);
                Session.Commit();
                edtQuellfall.LookupID = DBNull.Value;
                edtQuellfall.EditValue = DBNull.Value;
            }
            catch(Exception ex)
            {
                if (Session.Transaction != null)
                {
                    Session.Rollback();
                }
                KissMsg.ShowError("CtlFallFusion", "FallNichtFusionierbar", "Fehler beim Fusionieren", ex);
            }
        }

        private void edtQuellfall_UserModifiedFld(object sender, KiSS4.Gui.UserModifiedFldEventArgs e)
        {
            string SearchString = edtQuellfall.EditValue.ToString().Replace("*", "%").Replace("?", "_").Replace(" ", "%");

            int? searchNr = null;
            int tmp;
            if( int.TryParse(edtQuellfall.EditValue.ToString(), out tmp) )
                searchNr = tmp;

            if (DBUtil.IsEmpty(SearchString))
            {
                if (e.ButtonClicked)
                {
                    SearchString = "%";
                }
                else
                {
                    edtQuellfall.EditValue = DBNull.Value;
                    edtQuellfall.LookupID  = DBNull.Value;
                }
            }

            KissLookupDialog dlg = new KissLookupDialog();
            e.Cancel = !dlg.SearchData(@"
              SELECT FallNr              = FAL.FaFallID,
                     Falltr�ger          = PRS.NameVorname,
                     Wohnsitz            = PRS.Wohnsitz,
                     DisplayText$        = 'Fall ' + CAST(FAL.FaFallID AS varchar) + ' - FT ' + PRS.NameVorname
              FROM   FaFall         FAL
                INNER JOIN vwPerson PRS ON PRS.BaPersonID = FAL.BaPersonID
              WHERE  PRS.NameVorname LIKE '%' + {0} + '%'
                OR FAL.FaFallID = {1}
              ORDER BY PRS.NameVorname",
              SearchString,
              e.ButtonClicked,searchNr,null,null);

            if (!e.Cancel)
            {
                    edtQuellfall.EditValue = dlg["DisplayText$"];
                edtQuellfall.LookupID  = dlg["FallNr"];
            }
        }

        private void edtZielfall_UserModifiedFld(object sender, KiSS4.Gui.UserModifiedFldEventArgs e)
        {
            string SearchString = edtZielfall.EditValue.ToString().Replace("*", "%").Replace("?", "_").Replace(" ", "%");

            int? searchNr = null;
            int tmp;
            if( int.TryParse(edtZielfall.EditValue.ToString(), out tmp) )
                searchNr = tmp;

            if (DBUtil.IsEmpty(SearchString))
            {
                if (e.ButtonClicked)
                {
                    SearchString = "%";
                }
                else
                {
                    edtZielfall.EditValue = DBNull.Value;
                    edtZielfall.LookupID  = DBNull.Value;
                }
            }

            KissLookupDialog dlg = new KissLookupDialog();
            e.Cancel = !dlg.SearchData(@"
              SELECT FallNr              = FAL.FaFallID,
                     Falltr�ger          = PRS.NameVorname,
                     Wohnsitz            = PRS.Wohnsitz,
                     DisplayText$        = 'Fall ' + CAST(FAL.FaFallID AS varchar) + ' - FT ' + PRS.NameVorname
              FROM   FaFall         FAL
                INNER JOIN vwPerson PRS ON PRS.BaPersonID = FAL.BaPersonID
              WHERE  PRS.NameVorname LIKE '%' + {0} + '%'
                OR FAL.FaFallID = {1}
              ORDER BY PRS.NameVorname",
              SearchString,
              e.ButtonClicked,searchNr,null,null);

            if (!e.Cancel)
            {
                    edtZielfall.EditValue = dlg["DisplayText$"];
                edtZielfall.LookupID  = dlg["FallNr"];
            }
        }

        #endregion
    }
}