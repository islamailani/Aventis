﻿using System;
using Kiss4Web.Model.Entities;

namespace Kiss4Web.Model
{
    public partial class BaAdresse : IEntity, IAuditableEntity
    {
        public int BaAdresseId { get; set; }
        public int? BaPersonId { get; set; }
        public int? BaInstitutionId { get; set; }
        public int? UserId { get; set; }
        public int? PlatzierungInstId { get; set; }
        public int? VmMandantId { get; set; }
        public int? VmPriMaId { get; set; }
        public int? KaBetriebId { get; set; }
        public int? KaBetriebKontaktId { get; set; }
        public int? BaLandId { get; set; }
        public DateTime? DatumVon { get; set; }
        public DateTime? DatumBis { get; set; }
        public bool AusEinwohnerregister { get; set; }
        public bool Gesperrt { get; set; }
        public int? AdresseCode { get; set; }
        public string CareOf { get; set; }
        public string Zusatz { get; set; }
        public string ZuhandenVon { get; set; }
        public string Strasse { get; set; }
        public int? StrasseCode { get; set; }
        public string HausNr { get; set; }
        public string Postfach { get; set; }
        public bool PostfachOhneNr { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }
        public int? OrtschaftCode { get; set; }
        public string Kanton { get; set; }
        public string Bezirk { get; set; }
        public string Bemerkung { get; set; }
        public string InstitutionName { get; set; }
        public int? PlatzierungsartCode { get; set; }
        public int? WohnStatusCode { get; set; }
        public int? WohnungsgroesseCode { get; set; }
        public int? QuartierCode { get; set; }
        public int? MigrationKa { get; set; }
        public int? VerId { get; set; }
        public string Creator { get; set; }
        public DateTime Created { get; set; }
        public string Modifier { get; set; }
        public DateTime Modified { get; set; }
        public byte[] BaAdresseTs { get; set; }

        public BaInstitution BaInstitution { get; set; }
        public BaLand BaLand { get; set; }
        public BaPerson BaPerson { get; set; }
        public KaBetrieb KaBetrieb { get; set; }
        public KaBetriebKontakt KaBetriebKontakt { get; set; }
        public BaInstitution PlatzierungInst { get; set; }
        public XUser User { get; set; }
        public VmMandant VmMandant { get; set; }
        public VmPriMa VmPriMa { get; set; }
        public int Id => BaAdresseId;
        public byte[] RowVersion => BaAdresseTs;
    }
}