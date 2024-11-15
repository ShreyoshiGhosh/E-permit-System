USE [E_Permit]
GO
/****** Object:  StoredProcedure [dbo].[showpermitbyid]    Script Date: 15-07-2024 23:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--select by id stored procedure--


ALTER PROCEDURE 
[dbo].[showpermitbyid]
    @Permit_Issue_ID varchar(36)
AS
BEGIN
    SET NOCOUNT ON;

    --SELECT Permit_Issue_ID, IssuedByDeparment,IssuedToDeparment,PermitIssueDate,JobDescription,IssueColdPermit,IssueHotPermit,IsPermitReceived 
	SELECT Permit_Issue_ID,
		Permit_Issue_No,
		IssuedByDeparment,
		IssuedByArea,
		IssuedToDeparment,
		IssuedToArea,
		CONVERT(NVARCHAR, PermitIssueDate, 120) AS PermitIssueDate,
		PermitShift,
		LocationOfWork,
		JobDescription,
		IsGasTestRequired,
		IsPermitToBeRecievedByIndividual,
		WithSAPnotification,
		WithSAPPMONotification,
		WithSAPPMsuborder,
		WithuoutSAPnotification,
		ReasonForWithoutSAPnotification,
		WithWorkOrderNumber,
		WithoutWorkOrderNumber,
		ReasonForWithoutWorkOrderNumber,
		IssueColdPermit,
		IssueHotPermit,
		IsPermitReceived
	FROM Issue_permit
    WHERE Permit_Issue_ID = @Permit_Issue_ID;


END;
