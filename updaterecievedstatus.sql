USE [E_Permit]
GO
/****** Object:  StoredProcedure [dbo].[UpdateReceivedSTatus]    Script Date: 15-07-2024 23:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--update dtaabase stored procedure--

ALTER PROCEDURE [dbo].[UpdateReceivedSTatus]
    @Permit_Issue_ID varchar(36),
	@IsPermitReceived bit
AS
BEGIN
   SET NOCOUNT ON;
    UPDATE Issue_permit
    SET IsPermitReceived = @IsPermitReceived
    WHERE Permit_Issue_ID = @Permit_Issue_ID
END;

