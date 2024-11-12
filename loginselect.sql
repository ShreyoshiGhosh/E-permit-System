USE [E_Permit]
GO
/****** Object:  StoredProcedure [dbo].[LOGINSELECT]    Script Date: 15-07-2024 23:24:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE

[dbo].[LOGINSELECT]

@Password  nvarchar(Max)  = NULL,
@Phone_no nvarchar(Max)  = NULL

AS
BEGIN
	
	SELECT 
		Name,
		Email_id,
		Password,
		Phone_no,
		Username 
		
	FROM 
		registration
	
	WHERE 
		Phone_no = @Phone_no
		AND Password = @Password

end


