USE [E_Permit]
GO
/****** Object:  StoredProcedure [dbo].[showallpermit]    Script Date: 15-07-2024 23:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[showallpermit]
as
begin
	select Permit_Issue_ID,
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
		IsPermitReceived from Issue_permit;
end;
