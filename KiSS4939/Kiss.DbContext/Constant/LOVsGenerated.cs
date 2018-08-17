
// ============================================================
//   This code was generated by the tool [DBToClass].
//   
//   Changes to this file may result in incorrect behavior
//   and will be lost when the code is regenerated.
// ============================================================
//   ServerName:  chbehvs005.chbe01.local
//   DBName:      KiSS_MBU_Prod_R5000
//   MachineName: CHBEHVS006
//   UserName:    kissservice
//   DateTime:    28.09.2011 16:03:21
//   Version:     2.0.0.19696
// ============================================================


namespace Kiss.DbContext.Constant
{

    /// <summary>
    /// Class that contains all the LOV scheme
    /// </summary>
    public static partial class LOVsGenerated
    {
        /// <summary>
        /// Auszahlungsart eines Beleges innerhalb der Klientenbuchhaltung
        /// [System: True]
        /// [Translatable: True]
        /// [ModulID: 117]
        /// </summary>
        public enum KbuAuszahlungArt
        {
            /// <summary>
            /// [System: True]
            /// [Code: 1]
            /// [Text: Elektronische Auszahlung]
            /// [ShortText: Elektr.]
            /// [BFSCode: 0]
            /// [Value3: ZH]
            /// </summary>
            ElektronischeAuszahlung = 1,
            /// <summary>
            /// [System: True]
            /// [Code: 2]
            /// [Text: Papierverfügung]
            /// [ShortText: Pap.]
            /// [BFSCode: 0]
            /// </summary>
            Papierverfuegung = 2,
            /// <summary>
            /// [System: True]
            /// [Code: 3]
            /// [Text: Cash / Barauszahlung]
            /// [ShortText: Bar]
            /// [BFSCode: 0]
            /// [Value3: ZH]
            /// </summary>
            CashBarauszahlung = 3,
            /// <summary>
            /// [System: True]
            /// [Code: 4]
            /// [Text: Check]
            /// [ShortText: Check]
            /// [BFSCode: 0]
            /// </summary>
            Check = 4,
            /// <summary>
            /// [System: True]
            /// [Code: 5]
            /// [Text: Interne Verrechnung]
            /// [ShortText: Int. V.]
            /// [BFSCode: 0]
            /// </summary>
            InterneVerrechnung = 5,
            /// <summary>
            /// [System: True]
            /// [Code: 6]
            /// [Text: SIL-Antrag]
            /// [ShortText: SIL-A.]
            /// [BFSCode: 0]
            /// </summary>
            SILAntrag = 6
        };
        /// <summary>
        /// Art des Belegs, z.B. ob es eine Auszahlungist
        /// [System: True]
        /// [Translatable: True]
        /// [ModulID: 117]
        /// </summary>
        public enum KbuBelegart
        {
            /// <summary>
            /// [System: True]
            /// [Code: 1]
            /// [Text: Auszahlung]
            /// [ShortText: Ausz.]
            /// [BFSCode: 0]
            /// </summary>
            Auszahlung = 1,
            /// <summary>
            /// [System: True]
            /// [Code: 2]
            /// [Text: Einzahlung]
            /// [ShortText: Einz.]
            /// [BFSCode: 0]
            /// </summary>
            Einzahlung = 2,
            /// <summary>
            /// [System: True]
            /// [Code: 3]
            /// [Text: Storno]
            /// [ShortText: St.]
            /// [BFSCode: 0]
            /// </summary>
            Storno = 3,
            /// <summary>
            /// [System: True]
            /// [Code: 4]
            /// [Text: Umbuchung]
            /// [ShortText: Umb.]
            /// [BFSCode: 0]
            /// </summary>
            Umbuchung = 4
        };
        /// <summary>
        /// Art des Belegkreises innerhalb der Klientenbuchhaltung
        /// [System: True]
        /// [Translatable: True]
        /// [ModulID: 117]
        /// </summary>
        public enum KbuBelegKreis
        {
            /// <summary>
            /// [System: True]
            /// [Code: 1]
            /// [Text: Auszahlungen KISS (Modul W)]
            /// [ShortText: KA]
            /// [BFSCode: 0]
            /// </summary>
            AuszahlungenKISS = 1,
            /// <summary>
            /// [System: True]
            /// [Code: 2]
            /// [Text: Einzahlungen KISS]
            /// [ShortText: KE]
            /// [BFSCode: 0]
            /// </summary>
            EinzahlungenKISS = 2,
            /// <summary>
            /// [System: True]
            /// [Code: 3]
            /// [Text: Umbuchungen KISS]
            /// [ShortText: KU]
            /// [BFSCode: 0]
            /// </summary>
            UmbuchungenKISS = 3,
            /// <summary>
            /// [System: True]
            /// [Code: 4]
            /// [Text: Stornobuchungen KISS]
            /// [ShortText: KS]
            /// [BFSCode: 0]
            /// </summary>
            StornobuchungenKISS = 4,
            /// <summary>
            /// [System: True]
            /// [Code: 5]
            /// [Text: Barbelege KISS]
            /// [ShortText: KS]
            /// [BFSCode: 0]
            /// </summary>
            BarbelegeKISS = 5
        };
        /// <summary>
        /// Beschreibt die möglichen Stati eines Belegs
        /// [System: True]
        /// [Translatable: True]
        /// [ModulID: 117]
        /// </summary>
        public enum KbuBelegstatus
        {
            /// <summary>
            /// Der Beleg ist nur ein Vorschlag
            /// [System: True]
            /// [Code: 1]
            /// [Text: Vorschlag]
            /// [ShortText: Vo]
            /// [BFSCode: 0]
            /// </summary>
            Vorschlag = 1,
            /// <summary>
            /// Der Beleg ist freigegeben.
            /// [System: True]
            /// [Code: 2]
            /// [Text: Freigegeben]
            /// [ShortText: Fg]
            /// [BFSCode: 0]
            /// </summary>
            Freigegeben = 2,
            /// <summary>
            /// Der Beleg ist verbucht.
            /// [System: True]
            /// [Code: 3]
            /// [Text: Verbucht]
            /// [ShortText: Vb]
            /// [BFSCode: 0]
            /// </summary>
            Verbucht = 3
        };
        /// <summary>
        /// Beschreibt die Klasse eines Kontos (Aufwand, Ertrag...)
        /// [System: True]
        /// [Translatable: True]
        /// [ModulID: 117]
        /// </summary>
        public enum KbuKontoklasse
        {
            /// <summary>
            /// Das Konto ist ein Aktivkonto.
            /// [System: True]
            /// [Code: 1]
            /// [Text: Aktiven]
            /// [ShortText: Ak]
            /// [BFSCode: 0]
            /// </summary>
            Aktiven = 1,
            /// <summary>
            /// Das Konto ist ein Passivkonto.
            /// [System: True]
            /// [Code: 2]
            /// [Text: Passiven]
            /// [ShortText: Pa]
            /// [BFSCode: 0]
            /// </summary>
            Passiven = 2,
            /// <summary>
            /// Das Konto ist ein Aufwandkonto.
            /// [System: True]
            /// [Code: 3]
            /// [Text: Aufwand]
            /// [ShortText: Au]
            /// [BFSCode: 0]
            /// </summary>
            Aufwand = 3,
            /// <summary>
            /// Das Konto ist ein Ertragskonto.
            /// [System: True]
            /// [Code: 4]
            /// [Text: Ertrag]
            /// [ShortText: Er]
            /// [BFSCode: 0]
            /// </summary>
            Ertrag = 4
        };
        /// <summary>
        /// Der Kontotyp (Bsp. GBL)
        /// [System: True]
        /// [Translatable: True]
        /// [ModulID: 117]
        /// </summary>
        public enum KbuKontoTyp
        {
            /// <summary>
            /// [System: True]
            /// [Code: 1]
            /// [Text: Grundbedarf]
            /// [ShortText: GBL]
            /// [BFSCode: 0]
            /// </summary>
            GBL = 1,
            /// <summary>
            /// [System: True]
            /// [Code: 2]
            /// [Text: Zulagen]
            /// [ShortText: Zl]
            /// [BFSCode: 0]
            /// </summary>
            Zulagen = 2
        };
        /// <summary>
        /// t.b.d.
        /// [System: True]
        /// [Translatable: True]
        /// [ModulID: 117]
        /// </summary>
        public enum KbuProzessart
        {
            /// <summary>
            /// [System: True]
            /// [Code: 1]
            /// [Text: WSH]
            /// [ShortText: WSH]
            /// [BFSCode: 0]
            /// </summary>
            WSH = 1,
            /// <summary>
            /// [System: True]
            /// [Code: 2]
            /// [Text: WV]
            /// [ShortText: WV]
            /// [BFSCode: 0]
            /// </summary>
            WV = 2,
            /// <summary>
            /// [System: True]
            /// [Code: 3]
            /// [Text: Inkasso]
            /// [ShortText: Ink.]
            /// [BFSCode: 0]
            /// </summary>
            Inkasso = 3,
            /// <summary>
            /// [System: True]
            /// [Code: 4]
            /// [Text: Rückläufer]
            /// [ShortText: R.L.]
            /// [BFSCode: 0]
            /// </summary>
            RueckLaeufer = 4
        };
        /// <summary>
        /// Zustand eines Transferlaufs
        /// [System: True]
        /// [Translatable: True]
        /// [ModulID: 117]
        /// </summary>
        public enum KbuTransferlaufStatus
        {
            /// <summary>
            /// Transferlauf wurde angelegt, aber noch nicht gestartet
            /// [System: True]
            /// [Code: 1]
            /// [Text: Erstellt]
            /// [ShortText: Neu]
            /// [BFSCode: 0]
            /// </summary>
            Created = 1,
            /// <summary>
            /// Belege werden transferiert
            /// [System: True]
            /// [Code: 2]
            /// [Text: Transfer läuft]
            /// [ShortText: Tra]
            /// [BFSCode: 0]
            /// </summary>
            Running = 2,
            /// <summary>
            /// Transfer wurde abgebrochen (dies ist ein Endzustand)
            /// [System: True]
            /// [Code: 3]
            /// [Text: Abgebrochen]
            /// [ShortText: Abg]
            /// [BFSCode: 0]
            /// </summary>
            Cancelled = 3,
            /// <summary>
            /// Transfer wurde durchgeführt (dies ist ein Endzustand)
            /// [System: True]
            /// [Code: 4]
            /// [Text: Durchgeführt]
            /// [ShortText: OK]
            /// [BFSCode: 0]
            /// </summary>
            Done = 4
        };
        /// <summary>
        /// Teams, denen ein Zahlungseingang zugeordnet werden kann
        /// [System: True]
        /// [Expandable: True]
        /// [Translatable: True]
        /// [ModulID: 117]
        /// </summary>
        public enum KbuZahlungseingangTeam { };
        /// <summary>
        /// Editiermodus
        /// [System: True]
        /// [Translatable: True]
        /// [ModulID: 100]
        /// </summary>
        public enum SysEditMode
        {
            /// <summary>
            /// [System: True]
            /// [Code: 1]
            /// [Text: Freiwillig]
            /// [ShortText: Freiw.]
            /// [BFSCode: 0]
            /// </summary>
            Normal = 1,
            /// <summary>
            /// [System: True]
            /// [Code: 2]
            /// [Text: Zwingend]
            /// [ShortText: Zwing.]
            /// [BFSCode: 0]
            /// </summary>
            Required = 2,
            /// <summary>
            /// [System: True]
            /// [Code: 3]
            /// [Text: Gesperrt]
            /// [ShortText: Gesp.]
            /// [BFSCode: 0]
            /// </summary>
            ReadOnly = 3
        };
        /// <summary>
        /// Aktionen, die zum Abschluss eines Abzugs geführt haben
        /// [System: True]
        /// [Translatable: True]
        /// [ModulID: 103]
        /// </summary>
        public enum WshAbzugAbschlussAktion
        {
            /// <summary>
            /// Fallwechsel
            /// [System: True]
            /// [Code: 1]
            /// [Text: Fallwechsel]
            /// [ShortText: F]
            /// [BFSCode: 0]
            /// </summary>
            Fallwechsel = 1,
            /// <summary>
            /// Inkasso - Schuldbrief
            /// [System: True]
            /// [Code: 2]
            /// [Text: Schuldbrief]
            /// [ShortText: SB]
            /// [BFSCode: 0]
            /// </summary>
            Schuldbrief = 2,
            /// <summary>
            /// Inkasso - Schuldanerkennung
            /// [System: True]
            /// [Code: 3]
            /// [Text: Schuldanerkennung]
            /// [ShortText: SA]
            /// [BFSCode: 0]
            /// </summary>
            Schuldanerkennung = 3,
            /// <summary>
            /// Keine Aktion
            /// [System: True]
            /// [Code: 4]
            /// [Text: Keine]
            /// [ShortText: K]
            /// [BFSCode: 0]
            /// </summary>
            Keine = 4
        };
        /// <summary>
        /// Bewilligungsstatus der WSH Budget-Position
        /// [System: True]
        /// [Translatable: True]
        /// [ModulID: 103]
        /// </summary>
        public enum WshBewilligungStatus
        {
            /// <summary>
            /// [System: True]
            /// [Code: 1]
            /// [Text: In Vorbereitung]
            /// [ShortText: In V.]
            /// [BFSCode: 0]
            /// </summary>
            InVorbereitung = 1,
            /// <summary>
            /// [System: True]
            /// [Code: 2]
            /// [Text: Bewilligung abgelehnt]
            /// [ShortText: Bew. abgel.]
            /// [BFSCode: 0]
            /// </summary>
            BewilligungAbgelehnt = 2,
            /// <summary>
            /// [System: True]
            /// [Code: 3]
            /// [Text: Bewilligung angefragt]
            /// [ShortText: Bew. angefr.]
            /// [BFSCode: 0]
            /// </summary>
            BewilligungAngefragt = 3,
            /// <summary>
            /// [System: True]
            /// [Code: 5]
            /// [Text: Bewilligung erteilt]
            /// [ShortText: Bew. ert.]
            /// [BFSCode: 0]
            /// </summary>
            BewilligungErteilt = 5,
            /// <summary>
            /// [System: True]
            /// [Code: 9]
            /// [Text: Gesperrt]
            /// [ShortText: Gesp.]
            /// [BFSCode: 0]
            /// </summary>
            Gesperrt = 9
        };
        /// <summary>
        /// Gewünschte Periodizität für die Auszahlungen
        /// [System: True]
        /// [Translatable: True]
        /// [ModulID: 103]
        /// </summary>
        public enum WshPeriodizitaet
        {
            /// <summary>
            /// [System: True]
            /// [Code: 1]
            /// [Text: 1x pro Monat]
            /// [ShortText: 1x p.M.]
            /// [BFSCode: 0]
            /// [Value3: ZH,M]
            /// </summary>
            _1xProMonat = 1,
            /// <summary>
            /// [System: True]
            /// [Code: 2]
            /// [Text: 2x pro Monat]
            /// [ShortText: 2x p.M.]
            /// [BFSCode: 0]
            /// [Value3: ZH,M]
            /// </summary>
            _2xProMonat = 2,
            /// <summary>
            /// [System: True]
            /// [Code: 3]
            /// [Text: Wöchentlich]
            /// [ShortText: Wl.]
            /// [BFSCode: 0]
            /// [Value3: ZH,M]
            /// </summary>
            Woechentlich = 3,
            /// <summary>
            /// [System: True]
            /// [Code: 4]
            /// [Text: Valuta]
            /// [ShortText: Val.]
            /// [BFSCode: 0]
            /// [Value3: ZH,Einnahme,M]
            /// </summary>
            Valuta = 4,
            /// <summary>
            /// [System: True]
            /// [Code: 5]
            /// [Text: 14-täglich]
            /// [ShortText: 14-Tgl.]
            /// [BFSCode: 0]
            /// </summary>
            _14Taeglich = 5,
            /// <summary>
            /// [System: True]
            /// [Code: 6]
            /// [Text: Wochentage]
            /// [ShortText: WT.]
            /// [BFSCode: 0]
            /// </summary>
            Wochentage = 6,
            /// <summary>
            /// [System: True]
            /// [Code: 7]
            /// [Text: Quartal]
            /// [ShortText: Quart.]
            /// [BFSCode: 0]
            /// [Value3: ZH,Einnahme]
            /// </summary>
            Quartal = 7,
            /// <summary>
            /// [System: True]
            /// [Code: 8]
            /// [Text: Semester]
            /// [ShortText: Sem.]
            /// [BFSCode: 0]
            /// [Value3: ZH,Einnahme]
            /// </summary>
            Semester = 8
        };
        /// <summary>
        /// Definiert die Aufteilung des Betrags in der Verwendungsperiode
        /// [System: True]
        /// [Translatable: True]
        /// [ModulID: 103]
        /// </summary>
        public enum WshSplittingart
        {
            /// <summary>
            /// Betrag wird durch Anzahl Tage der Verwendungsperiode geteilt (gesplittet)
            /// [System: True]
            /// [Code: 1]
            /// [Text: Taggenau]
            /// [ShortText: T]
            /// [BFSCode: 0]
            /// </summary>
            Taggenau = 1,
            /// <summary>
            /// Betrag wird durch Anzahl Monate der Verwendungsperiode geteilt (gesplittet)
            /// [System: True]
            /// [Code: 2]
            /// [Text: Monat]
            /// [ShortText: M]
            /// [BFSCode: 0]
            /// </summary>
            Monat = 2,
            /// <summary>
            /// Verwendungsperiode = 1 Tag. Valutadatum bei Erfassung Einzelzahlung wird als Verwendungsperiode übernommen
            /// [System: True]
            /// [Code: 3]
            /// [Text: Valuta]
            /// [ShortText: V]
            /// [BFSCode: 0]
            /// </summary>
            Valuta = 3,
            /// <summary>
            /// Verwendungsperiode = 1 Tag. Entscheiddatum bei Erfassung Einzelzahlung wird als Verwendungsperiode übernommen
            /// [System: True]
            /// [Code: 4]
            /// [Text: Entscheid]
            /// [ShortText: E]
            /// [BFSCode: 0]
            /// </summary>
            Entscheid = 4
        };
    }
}