﻿SET NOCOUNT ON
BEGIN TRANSACTION
GO
DELETE FROM [BaRelation]
GO
SET IDENTITY_INSERT [BaRelation] ON
GO
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (1, N'Eltern : Kind', N'Vater / Mutter', N'Kind / Adoptivkind', N'Vater', N'Mutter', N'Sohn / Adoptivsohn', N'Tochter / Adoptivtochter', 0, 7, 0, 8, 3)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (2, N'Andere Person (im Haushalt)', N'Andere Person (im Haushalt)', N'Andere Person (im Haushalt)', N'andere Beziehung', N'andere Beziehung', N'andere Beziehung', N'andere Beziehung', 1, 12, 0, 17, 17)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (3, N'Andere Person (nicht gl. HH)', N'Andere Person (nicht gl. HH)', N'Andere Person (nicht gl. HH)', N'andere Beziehung', N'andere Beziehung', N'andere Beziehung', N'andere Beziehung', 1, 13, 0, 17, 17)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (6, N'Pflegeltern : Pflegekind', N'Pflegevater/-mutter', N'Pflegekind', N'Pflegevater', N'Pflegemutter', N'Pflegesohn', N'Pflegetochter', 0, 9, 0, 9, 4)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (7, N'Stiefeltern : Stiefkind', N'Stiefvater/-mutter', N'Stiefkind', N'Stiefvater', N'Stiefmutter', N'Stiefsohn', N'Stieftochter', 0, 8, 0, 9, 4)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (13, N'Ehepaar', N'Ehepartner/-in', N'Ehepartner/-in', N'Ehemann', N'Ehefrau', N'Ehemann', N'Ehefrau', 1, 1, 0, 1, 1)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (14, N'eingetr. Partnerschaft', N'eingetr. Partner/-in', N'eingetr. Partner/-in', N'eingetr. Partner', N'eingetr. Partnerin', N'eingetr. Partner', N'eingetr. Partnerin', 1, 2, 0, 18, 18)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (15, N'Konkubinatspaar', N'Konkubinatpartner/-in', N'Konkubinatpartner/-in', N'Konkubinatspartner', N'Konkubinatspartnerin', N'Konkubinatspartner', N'Konkubinatspartnerin', 1, 3, 0, 2, 2)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (17, N'Ex-Partnersch.(gem.Kind,Ehe,reg.)', N'Ex-Partner/-in', N'Ex-Partner/-in', N'Ex-Ehemann/Partner', N'Ex-Ehefrau/Partnerin', N'Ex-Ehemann/Partner', N'Ex-Ehefrau/Partnerin', 1, 6, 0, 17, 17)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (36, N'Ehepaar getrennt lebend', N'Ehepartner getr. lebend', N'Ehepartner getr. lebend', N'Ehemann getrennt lebend', N'Ehefrau getrennt lebend', N'Ehemann getrennt lebend', N'Ehefrau getrennt lebend', 1, 4, 0, 1, 1)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (38, N'eingetr. Partnerschaft getr. lebend', N'eingetr. Partner/-in getrennt lebend', N'eingetr. Partner/-in getrennt lebend', N'eingetr. Partner getrennt lebend', N'eingetr. Partnerin getrennt lebend', N'eingetr. Partner getrennt lebend', N'eingetr. Partnerin getrennt lebend', 1, 5, 0, 18, 18)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (39, N'Eltern auswärts : Kind', N'Vater / Mutter (nicht gleicher Haushalt)', N'Kind (nicht gleicher Haushalt)', N'Vater (nicht gleicher Haushalt)', N'Mutter (nicht gleicher Haushalt)', N'Sohn (nicht gleicher Haushalt)', N'Tochter (nicht gleicher Haushalt)', 0, 10, 0, 8, 3)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (41, N'Berechnungsperson', N'Berechnungsperson', N'Berechnungsperson', N'andere Beziehung', N'andere Beziehung', N'andere Beziehung', N'andere Beziehung', 1, 11, 0, 17, 17)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (42, N'Andere Beziehung', N'Andere Beziehung', N'Andere Beziehung', N'andere Beziehung', N'andere Beziehung', N'andere Beziehung', N'andere Beziehung', 1, 99, 1, 17, 17)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (43, N'Geschwister', N'Bruder / Schwester', N'Bruder / Schwester', N'Bruder', N'Schwester', N'Bruder', N'Schwester', 1, 21, 1, 5, 5)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (45, N'Stiefgeschwister', N'Stiefgeschwister', N'Stiefgeschwister', N'Stiefbruder', N'Stiefschwester', N'Stiefbruder', N'Stiefschwester', 1, 22, 1, 6, 6)
INSERT INTO [BaRelation] ([BaRelationID], [NameRelation], [NameGenerisch1], [NameGenerisch2], [NameMaennlich1], [NameWeiblich1], [NameMaennlich2], [NameWeiblich2], [symmetrisch], [SortKey], [AusblendenBeiFallaufnahme], [BfsCode12], [BfsCode21]) VALUES (46, N'Halbgeschwister', N'Halbgeschwister', N'Halbgeschwister', N'Halbbruder', N'Halbschwester', N'Halbbruder', N'Halbschwester', 1, 23, 1, 5, 5)
GO
SET IDENTITY_INSERT [BaRelation] OFF
GO
COMMIT
GO