﻿SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO
EXECUTE dbo.spDropObject fnKgAuszahlTermine
GO
/*===============================================================================================
  $Revision: 4 $
=================================================================================================
  Description
-------------------------------------------------------------------------------------------------
  SUMMARY: .
    @Param1   .
    @Param20: .
  -
  RETURNS: .
  -
=================================================================================================
  TEST:    .
=================================================================================================*/

CREATE FUNCTION dbo.fnKgAuszahlTermine
(
  @Jahr int,
  @Monat  int
)
  RETURNS @OUTPUT TABLE
   (KgAuszahlungsTerminCode int,
    KgWochentagCode         int,
    Datum                   datetime)

AS BEGIN
  DECLARE @Tag         int,
          @TageImMonat int,
          @Datum       datetime,
          @Wochentag   int

  INSERT @OUTPUT SELECT 1, NULL, DatMonatlich FROM   dbo.KgZahlungslaufValuta WITH (READUNCOMMITTED) WHERE  Jahr = @Jahr AND Monat = @Monat
  INSERT @OUTPUT SELECT 2, NULL, DatTeil1     FROM   dbo.KgZahlungslaufValuta WITH (READUNCOMMITTED) WHERE  Jahr = @Jahr AND Monat = @Monat
  INSERT @OUTPUT SELECT 2, NULL, DatTeil2     FROM   dbo.KgZahlungslaufValuta WITH (READUNCOMMITTED) WHERE  Jahr = @Jahr AND Monat = @Monat
  INSERT @OUTPUT SELECT 3, NULL, DatWoche1    FROM   dbo.KgZahlungslaufValuta WITH (READUNCOMMITTED) WHERE  Jahr = @Jahr AND Monat = @Monat
  INSERT @OUTPUT SELECT 3, NULL, DatWoche2    FROM   dbo.KgZahlungslaufValuta WITH (READUNCOMMITTED) WHERE  Jahr = @Jahr AND Monat = @Monat
  INSERT @OUTPUT SELECT 3, NULL, DatWoche3    FROM   dbo.KgZahlungslaufValuta WITH (READUNCOMMITTED) WHERE  Jahr = @Jahr AND Monat = @Monat
  INSERT @OUTPUT SELECT 3, NULL, DatWoche4    FROM   dbo.KgZahlungslaufValuta WITH (READUNCOMMITTED) WHERE  Jahr = @Jahr AND Monat = @Monat
  INSERT @OUTPUT SELECT 3, NULL, DatWoche5    FROM   dbo.KgZahlungslaufValuta WITH (READUNCOMMITTED) WHERE  Jahr = @Jahr AND Monat = @Monat
  INSERT @OUTPUT SELECT 5, NULL, Dat14Tage1   FROM   dbo.KgZahlungslaufValuta WITH (READUNCOMMITTED) WHERE  Jahr = @Jahr AND Monat = @Monat
  INSERT @OUTPUT SELECT 5, NULL, Dat14Tage2   FROM   dbo.KgZahlungslaufValuta WITH (READUNCOMMITTED) WHERE  Jahr = @Jahr AND Monat = @Monat
  INSERT @OUTPUT SELECT 5, NULL, Dat14Tage3   FROM   dbo.KgZahlungslaufValuta WITH (READUNCOMMITTED) WHERE  Jahr = @Jahr AND Monat = @Monat

  DELETE @OUTPUT WHERE Datum IS NULL

  --Wochentage MO-FR
  SET @TageImMonat = dbo.fnDaysInMonthOf(dbo.fnDateSerial(@Jahr,@Monat,1))
  SET @Tag = 1
  WHILE @Tag <= @TageImMonat BEGIN
    SET @Datum = dbo.fnDateSerial(@Jahr,@Monat,@Tag)
    SET @Wochentag = DatePart(weekday,@Datum) - 1
    IF @Wochentag BETWEEN 1 AND 5 INSERT @OUTPUT VALUES (6, @Wochentag, @Datum)
	SET @Tag = @Tag + 1
  END

  RETURN
END
GO
SET QUOTED_IDENTIFIER OFF
GO
SET ANSI_NULLS ON
GO