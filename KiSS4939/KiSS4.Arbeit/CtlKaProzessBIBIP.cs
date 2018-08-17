using System;
using System.Drawing;

using KiSS4.DB;
using KiSS4.Gui;

namespace KiSS4.Arbeit
{
    public class CtlKaProzessBIBIP : KiSS4.Gui.KissUserControl
    {
        #region Fields

        #region Private Fields

        private int BaPersonID = 0;
        private int FaLeistungID = 0;
        private KiSS4.Gui.KissButton btnReopen;
        private System.ComponentModel.IContainer components;
        private KiSS4.Gui.KissDateEdit datDatumBis;
        private KiSS4.Gui.KissDateEdit datDatumVon;
        private KiSS4.Gui.KissTextEdit edtAbschluss;
        private KiSS4.Gui.KissLabel edtDatumEroeffnung;
        private KiSS4.Gui.KissTextEdit edtZustaendigKA;
        private KiSS4.Gui.KissLabel lblAbschluss;
        private KiSS4.Gui.KissLabel lblAbschlussGrund;
        private KiSS4.Gui.KissLabel lblDatumAbschluss;
        private KiSS4.Gui.KissLabel lblEroeffnung;
        private System.Windows.Forms.Label lblTitel;
        private KiSS4.Gui.KissLabel lblZustaendigKA;
        private System.Windows.Forms.PictureBox picTitle;
        private KiSS4.DB.SqlQuery qryFaLeistung;

        #endregion

        #endregion

        #region Constructors

        public CtlKaProzessBIBIP()
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtlKaProzessBIBIP));
            this.datDatumVon = new KiSS4.Gui.KissDateEdit();
            this.qryFaLeistung = new KiSS4.DB.SqlQuery(this.components);
            this.edtZustaendigKA = new KiSS4.Gui.KissTextEdit();
            this.datDatumBis = new KiSS4.Gui.KissDateEdit();
            this.edtDatumEroeffnung = new KiSS4.Gui.KissLabel();
            this.lblZustaendigKA = new KiSS4.Gui.KissLabel();
            this.lblDatumAbschluss = new KiSS4.Gui.KissLabel();
            this.lblAbschlussGrund = new KiSS4.Gui.KissLabel();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnReopen = new KiSS4.Gui.KissButton();
            this.edtAbschluss = new KiSS4.Gui.KissTextEdit();
            this.lblEroeffnung = new KiSS4.Gui.KissLabel();
            this.lblAbschluss = new KiSS4.Gui.KissLabel();
            ((System.ComponentModel.ISupportInitialize)(this.datDatumVon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryFaLeistung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtZustaendigKA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDatumBis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDatumEroeffnung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblZustaendigKA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDatumAbschluss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAbschlussGrund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtAbschluss.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEroeffnung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAbschluss)).BeginInit();
            this.SuspendLayout();
            // 
            // datDatumVon
            // 
            this.datDatumVon.DataMember = "DatumVon";
            this.datDatumVon.DataSource = this.qryFaLeistung;
            this.datDatumVon.EditValue = null;
            this.datDatumVon.Location = new System.Drawing.Point(135, 81);
            this.datDatumVon.Name = "datDatumVon";
            this.datDatumVon.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.datDatumVon.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.datDatumVon.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.datDatumVon.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.datDatumVon.Properties.Appearance.Options.UseBackColor = true;
            this.datDatumVon.Properties.Appearance.Options.UseBorderColor = true;
            this.datDatumVon.Properties.Appearance.Options.UseFont = true;
            this.datDatumVon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            serializableAppearanceObject2.BackColor = System.Drawing.Color.Bisque;
            serializableAppearanceObject2.Options.UseBackColor = true;
            this.datDatumVon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 8, true, true, false, DevExpress.Utils.HorzAlignment.Center, ((System.Drawing.Image)(resources.GetObject("datDatumVon.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2)});
            this.datDatumVon.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.datDatumVon.Properties.ShowToday = false;
            this.datDatumVon.Size = new System.Drawing.Size(100, 24);
            this.datDatumVon.TabIndex = 0;
            // 
            // qryFaLeistung
            // 
            this.qryFaLeistung.CanUpdate = true;
            this.qryFaLeistung.HostControl = this;
            this.qryFaLeistung.IsIdentityInsert = false;
            this.qryFaLeistung.SelectStatement = resources.GetString("qryFaLeistung.SelectStatement");
            this.qryFaLeistung.TableName = "FaLeistung";
            this.qryFaLeistung.AfterPost += new System.EventHandler(this.qryFaLeistung_AfterPost);
            this.qryFaLeistung.BeforePost += new System.EventHandler(this.qryFaLeistung_BeforePost);
            // 
            // edtZustaendigKA
            // 
            this.edtZustaendigKA.DataMember = "ZustaendigKA";
            this.edtZustaendigKA.DataSource = this.qryFaLeistung;
            this.edtZustaendigKA.EditMode = Kiss.Interfaces.UI.EditModeType.ReadOnly;
            this.edtZustaendigKA.Location = new System.Drawing.Point(135, 112);
            this.edtZustaendigKA.Name = "edtZustaendigKA";
            this.edtZustaendigKA.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.edtZustaendigKA.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtZustaendigKA.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtZustaendigKA.Properties.Appearance.Options.UseBackColor = true;
            this.edtZustaendigKA.Properties.Appearance.Options.UseBorderColor = true;
            this.edtZustaendigKA.Properties.Appearance.Options.UseFont = true;
            this.edtZustaendigKA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.edtZustaendigKA.Properties.ReadOnly = true;
            this.edtZustaendigKA.Size = new System.Drawing.Size(428, 24);
            this.edtZustaendigKA.TabIndex = 1;
            // 
            // datDatumBis
            // 
            this.datDatumBis.DataMember = "DatumBis";
            this.datDatumBis.DataSource = this.qryFaLeistung;
            this.datDatumBis.EditValue = null;
            this.datDatumBis.Location = new System.Drawing.Point(135, 229);
            this.datDatumBis.Name = "datDatumBis";
            this.datDatumBis.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.datDatumBis.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.datDatumBis.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.datDatumBis.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.datDatumBis.Properties.Appearance.Options.UseBackColor = true;
            this.datDatumBis.Properties.Appearance.Options.UseBorderColor = true;
            this.datDatumBis.Properties.Appearance.Options.UseFont = true;
            this.datDatumBis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.Bisque;
            serializableAppearanceObject1.Options.UseBackColor = true;
            this.datDatumBis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 8, true, true, false, DevExpress.Utils.HorzAlignment.Center, ((System.Drawing.Image)(resources.GetObject("datDatumBis.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1)});
            this.datDatumBis.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.datDatumBis.Properties.ShowToday = false;
            this.datDatumBis.Size = new System.Drawing.Size(100, 24);
            this.datDatumBis.TabIndex = 3;
            // 
            // edtDatumEroeffnung
            // 
            this.edtDatumEroeffnung.Location = new System.Drawing.Point(10, 82);
            this.edtDatumEroeffnung.Name = "edtDatumEroeffnung";
            this.edtDatumEroeffnung.Size = new System.Drawing.Size(100, 23);
            this.edtDatumEroeffnung.TabIndex = 5;
            this.edtDatumEroeffnung.Text = "Datum";
            this.edtDatumEroeffnung.UseCompatibleTextRendering = true;
            // 
            // lblZustaendigKA
            // 
            this.lblZustaendigKA.Location = new System.Drawing.Point(10, 113);
            this.lblZustaendigKA.Name = "lblZustaendigKA";
            this.lblZustaendigKA.Size = new System.Drawing.Size(100, 23);
            this.lblZustaendigKA.TabIndex = 6;
            this.lblZustaendigKA.Text = "Zust�ndig KA";
            this.lblZustaendigKA.UseCompatibleTextRendering = true;
            // 
            // lblDatumAbschluss
            // 
            this.lblDatumAbschluss.Location = new System.Drawing.Point(10, 231);
            this.lblDatumAbschluss.Name = "lblDatumAbschluss";
            this.lblDatumAbschluss.Size = new System.Drawing.Size(100, 23);
            this.lblDatumAbschluss.TabIndex = 7;
            this.lblDatumAbschluss.Text = "Datum";
            this.lblDatumAbschluss.UseCompatibleTextRendering = true;
            // 
            // lblAbschlussGrund
            // 
            this.lblAbschlussGrund.Location = new System.Drawing.Point(10, 199);
            this.lblAbschlussGrund.Name = "lblAbschlussGrund";
            this.lblAbschlussGrund.Size = new System.Drawing.Size(100, 23);
            this.lblAbschlussGrund.TabIndex = 8;
            this.lblAbschlussGrund.Text = "Grund";
            this.lblAbschlussGrund.UseCompatibleTextRendering = true;
            // 
            // picTitle
            // 
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(10, 15);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(15, 20);
            this.picTitle.TabIndex = 518;
            this.picTitle.TabStop = false;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitel.ForeColor = System.Drawing.Color.Black;
            this.lblTitel.Location = new System.Drawing.Point(31, 15);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(30, 18);
            this.lblTitel.TabIndex = 519;
            this.lblTitel.Text = "Titel";
            this.lblTitel.UseCompatibleTextRendering = true;
            // 
            // btnReopen
            // 
            this.btnReopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReopen.Location = new System.Drawing.Point(135, 280);
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(90, 24);
            this.btnReopen.TabIndex = 520;
            this.btnReopen.Text = "wieder �ffnen";
            this.btnReopen.UseCompatibleTextRendering = true;
            this.btnReopen.UseVisualStyleBackColor = false;
            this.btnReopen.Click += new System.EventHandler(this.btnReopen_Click);
            // 
            // edtAbschluss
            // 
            this.edtAbschluss.DataMember = "Abschluss";
            this.edtAbschluss.DataSource = this.qryFaLeistung;
            this.edtAbschluss.EditMode = Kiss.Interfaces.UI.EditModeType.ReadOnly;
            this.edtAbschluss.Location = new System.Drawing.Point(135, 198);
            this.edtAbschluss.Name = "edtAbschluss";
            this.edtAbschluss.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.edtAbschluss.Properties.Appearance.BorderColor = System.Drawing.Color.Linen;
            this.edtAbschluss.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.edtAbschluss.Properties.Appearance.Options.UseBackColor = true;
            this.edtAbschluss.Properties.Appearance.Options.UseBorderColor = true;
            this.edtAbschluss.Properties.Appearance.Options.UseFont = true;
            this.edtAbschluss.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.edtAbschluss.Properties.ReadOnly = true;
            this.edtAbschluss.Size = new System.Drawing.Size(428, 24);
            this.edtAbschluss.TabIndex = 521;
            // 
            // lblEroeffnung
            // 
            this.lblEroeffnung.LabelStyle = KiSS4.Gui.LabelStyleType.TitleLabel;
            this.lblEroeffnung.Location = new System.Drawing.Point(135, 52);
            this.lblEroeffnung.Name = "lblEroeffnung";
            this.lblEroeffnung.Size = new System.Drawing.Size(100, 16);
            this.lblEroeffnung.TabIndex = 522;
            this.lblEroeffnung.Text = "Er�ffnung";
            this.lblEroeffnung.UseCompatibleTextRendering = true;
            // 
            // lblAbschluss
            // 
            this.lblAbschluss.LabelStyle = KiSS4.Gui.LabelStyleType.TitleLabel;
            this.lblAbschluss.Location = new System.Drawing.Point(135, 169);
            this.lblAbschluss.Name = "lblAbschluss";
            this.lblAbschluss.Size = new System.Drawing.Size(100, 16);
            this.lblAbschluss.TabIndex = 523;
            this.lblAbschluss.Text = "Abschluss";
            this.lblAbschluss.UseCompatibleTextRendering = true;
            // 
            // CtlKaProzessBIBIP
            // 
            this.ActiveSQLQuery = this.qryFaLeistung;
            this.AutoScroll = true;
            this.Controls.Add(this.lblAbschluss);
            this.Controls.Add(this.lblEroeffnung);
            this.Controls.Add(this.edtAbschluss);
            this.Controls.Add(this.btnReopen);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.lblAbschlussGrund);
            this.Controls.Add(this.lblDatumAbschluss);
            this.Controls.Add(this.lblZustaendigKA);
            this.Controls.Add(this.edtDatumEroeffnung);
            this.Controls.Add(this.datDatumBis);
            this.Controls.Add(this.edtZustaendigKA);
            this.Controls.Add(this.datDatumVon);
            this.Name = "CtlKaProzessBIBIP";
            this.Size = new System.Drawing.Size(574, 337);
            ((System.ComponentModel.ISupportInitialize)(this.datDatumVon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryFaLeistung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtZustaendigKA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDatumBis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDatumEroeffnung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblZustaendigKA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDatumAbschluss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAbschlussGrund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtAbschluss.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEroeffnung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAbschluss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        #region EventHandlers

        private void btnReopen_Click(object sender, System.EventArgs e)
        {
            if (KissMsg.ShowQuestion("CtlKaProzessBIBIP", "FallWiedereroeffnen", "Soll der geschlossene Fall wieder ge�ffnet werden ?"))
            {
                qryFaLeistung.CanUpdate = true;
                qryFaLeistung["DatumBis"] = DBNull.Value;
                qryFaLeistung.Post();
            }
        }

        private void qryFaLeistung_AfterPost(object sender, System.EventArgs e)
        {
            if (CloseAllgemein())
            {
                DBUtil.ExecSQL(@"UPDATE FaLeistung SET DatumBis = GetDate(), Modifier = {1}, Modified = GetDate() WHERE BaPersonID = {0} AND ModulID = 7 AND FaProzessCode = 700", BaPersonID, DBUtil.GetDBRowCreatorModifier());
            }
            else
            {
                DBUtil.ExecSQL(@"UPDATE FaLeistung SET DatumBis = null, Modifier = {1}, Modified = GetDate() WHERE BaPersonID = {0} AND ModulID = 7 AND FaProzessCode = 700", BaPersonID, DBUtil.GetDBRowCreatorModifier());
            }

            SetEditMode();
            FormController.SendMessage("FrmFall", "Action", "RefreshTree");
        }

        private void qryFaLeistung_BeforePost(object sender, System.EventArgs e)
        {
            DBUtil.CheckNotNullField(datDatumVon, "Er�ffnungsdatum");

            //falls DatumBis erfasst, muss es gr�sser sein als DatumVon
            if (!DBUtil.IsEmpty(qryFaLeistung["DatumBis"]) && (DateTime) qryFaLeistung["DatumVon"] > (DateTime) qryFaLeistung["DatumBis"])
                throw new KissInfoException("Das Er�ffnungsdatum darf nicht nach dem Abschlussdatum sein!");

            //pr�fen, ob DatumVon in eine andere Fallperiode f�llt
            int Count = (int) DBUtil.ExecuteScalarSQL(@"
                select	count(*)
                from	FaLeistung A
                    inner join FaLeistung B on  B.BaPersonID = A.BaPersonID and
                                B.ModulID = 7 and
                                B.FaProzessCode = A.FaProzessCode and
                                B.FaLeistungID <> A.FaLeistungID and
                                {0} between B.DatumVon and B.DatumBis
                where	A.FaLeistungID = {1}",
                qryFaLeistung["DatumVon"],
                FaLeistungID);

            if (Count > 0)
                throw new KissInfoException("Das Er�ffnungsdatum darf nicht mit einem anderen Fall �berschneiden!");

            if (!DBUtil.IsEmpty(qryFaLeistung["DatumBis"]))
            {
                int cnt = 0;

                // all fields have a value in "Vermittlung BI/BIP �bersicht"?
                cnt = Convert.ToInt32(DBUtil.ExecuteScalarSQL(@"SELECT COUNT(*)
                                    FROM KaVermittlungBIBIP
                                    WHERE FaLeistungID = {0}
                                    AND AbschlussDatum IS NOT NULL
                                    AND ((WechselKAIntern = 0 AND DossierRetourAnSD = 1)
                                        OR (WechselKAIntern = 1 AND DossierRetourAnSD = 0))
                                    AND ((WechselKAInternGrundCode IS NULL AND DossierRetourAnSDGrundCode IS NOT NULL)
                                        OR (WechselKAInternGrundCode IS NOT NULL AND DossierRetourAnSDGrundCode IS NULL))"
                                , FaLeistungID));

                if (cnt == 0)
                {
                    datDatumBis.EditValue = null;
                    qryFaLeistung["DatumBis"] = DBNull.Value;
                    throw new KissInfoException("Abschluss nicht m�glich!\r\nNicht alle Felder ausgef�llt in Vermittlung BI/BIP �bersicht!\r\n(Datum Abschluss, Wechsel KA intern, Dossier retour an SD)");
                }

                // exists Eins�tze BIP and are all fields filled?
                cnt = Convert.ToInt32(DBUtil.ExecuteScalarSQL(@"SELECT COUNT(*)
                                    FROM KaVermittlungVorschlag VOR
                                        INNER JOIN KaVermittlungEinsatz EIN ON EIN.KaVermittlungVorschlagID = VOR.KaVermittlungVorschlagID
                                        LEFT JOIN KaEinsatzplatz EIP ON EIP.KaEinsatzplatzID = VOR.KaEinsatzplatzID
                                    WHERE VOR.FaLeistungID = {0}
                                    AND EIP.KaProgrammCode = 4
                                    AND EIN.EinsatzVon IS NOT NULL"
                                , FaLeistungID));

                if (cnt > 0)
                {
                    cnt = Convert.ToInt32(DBUtil.ExecuteScalarSQL(@"SELECT COUNT(*)
                                    FROM KaVermittlungVorschlag VOR
                                        INNER JOIN KaVermittlungEinsatz EIN ON EIN.KaVermittlungVorschlagID = VOR.KaVermittlungVorschlagID
                                        LEFT JOIN KaEinsatzplatz EIP ON EIP.KaEinsatzplatzID = VOR.KaEinsatzplatzID
                                    WHERE VOR.FaLeistungID = {0}
                                    AND (EIN.Abschluss IS NULL
                                        OR EIN.BIBIPSIAbschlussDurchCode IS NULL
                                        OR EIN.BIPAbschlussGrundCode IS NULL)
                                    AND EIP.KaProgrammCode = 4
                                    AND EIN.EinsatzVon IS NOT NULL"
                                , FaLeistungID));

                    if (cnt > 0)
                    {
                        datDatumBis.EditValue = null;
                        qryFaLeistung["DatumBis"] = DBNull.Value;
                        throw new KissInfoException("Abschluss nicht m�glich!\r\nNicht alle Eins�tze korrekt ausgef�llt in Eins�tze BIP\r\n(Datum Stellenende, durch, Grund)");
                    }
                }

                // exists Eins�tze BI and are all fields filled?
                cnt = Convert.ToInt32(DBUtil.ExecuteScalarSQL(@"SELECT COUNT(*)
                                    FROM KaVermittlungVorschlag VOR
                                        INNER JOIN KaVermittlungEinsatz EIN ON EIN.KaVermittlungVorschlagID = VOR.KaVermittlungVorschlagID
                                        LEFT JOIN KaEinsatzplatz EIP ON EIP.KaEinsatzplatzID = VOR.KaEinsatzplatzID
                                    WHERE VOR.FaLeistungID = {0}
                                    AND EIP.KaProgrammCode = 3
                                    AND EIN.EinsatzVon IS NOT NULL"
                                , FaLeistungID));

                if (cnt > 0)
                {
                    cnt = Convert.ToInt32(DBUtil.ExecuteScalarSQL(@"SELECT COUNT(*)
                                    FROM KaVermittlungVorschlag VOR
                                        INNER JOIN KaVermittlungEinsatz EIN ON EIN.KaVermittlungVorschlagID = VOR.KaVermittlungVorschlagID
                                        LEFT JOIN KaEinsatzplatz EIP ON EIP.KaEinsatzplatzID = VOR.KaEinsatzplatzID
                                    WHERE VOR.FaLeistungID = {0}
                                    AND (EIN.Abschluss IS NULL
                                        OR EIN.BIBIPSIAbschlussDurchCode IS NULL
                                        OR EIN.BIAbschlussGrundCode IS NULL)
                                    AND EIP.KaProgrammCode = 3
                                    AND EIN.EinsatzVon IS NOT NULL"
                                , FaLeistungID));

                    if (cnt > 0)
                    {
                        datDatumBis.EditValue = null;
                        qryFaLeistung["DatumBis"] = DBNull.Value;
                        throw new KissInfoException("Abschluss nicht m�glich!\r\nNicht alle Eins�tze korrekt ausgef�llt in Stellen BI\r\n(Datum Stellenende, durch, Grund)");
                    }
                }
            }
        }

        #endregion

        #region Methods

        #region Public Methods

        public void Init(string TitleName, Image TitleImage, int FaLeistungID, int BaPersonID)
        {
            this.lblTitel.Text = TitleName;
            this.picTitle.Image = TitleImage;
            this.FaLeistungID = FaLeistungID;
            this.BaPersonID = BaPersonID;

            qryFaLeistung.Fill(FaLeistungID);

            SetEditMode();
        }

        public override bool OnSaveData()
        {
            bool ret = qryFaLeistung.Post();
            SetEditMode();
            return ret;
        }

        #endregion

        #region Private Methods

        private bool CloseAllgemein()
        {
            bool rslt = false;

            rslt = Convert.ToInt32(
                DBUtil.ExecuteScalarSQL(@"select count(*) from FaLeistung
                                      where BaPersonID = {0}
                                      and   ModulID = 7
                                      and   FaProzessCode BETWEEN 701 AND 720
                                      and   DatumBis is null",
                BaPersonID)) == 0;

            return rslt;
        }

        private void SetEditMode()
        {
            if (qryFaLeistung.Count == 0) return;

            //nur owner oder admin darf abschliessen
            if (Session.User.IsUserAdmin || (int) qryFaLeistung["UserID"] == Session.User.UserID || DBUtil.UserHasRight("CtlKaProzessBIBIP"))
            {
                bool open = DBUtil.IsEmpty(qryFaLeistung["DatumBis"]);
                bool archived = !DBUtil.IsEmpty(qryFaLeistung["FaLeistungArchivID"]);

                qryFaLeistung.CanUpdate = DBUtil.UserHasRight("CtlKaProzessBIBIP", "UI");
                qryFaLeistung.EnableBoundFields(qryFaLeistung.CanUpdate && open);
                btnReopen.Visible = !open && !archived && qryFaLeistung.CanUpdate;
            }
            else
            {
                qryFaLeistung.EnableBoundFields(false);
                btnReopen.Visible = false;
            }
        }

        #endregion

        #endregion
    }
}