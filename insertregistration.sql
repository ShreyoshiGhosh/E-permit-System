USE [E_Permit]
GO
/****** Object:  StoredProcedure [dbo].[insertregitration]    Script Date: 15-07-2024 23:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
ALTER procedure
[dbo].[insertregitration] 

@Name nvarchar(Max) = NULL, 
@Email_id bigint  = NULL,
@Password  nvarchar(Max)  = NULL,
@Phone_no nvarchar(Max)  = NULL,
@Username nvarchar(20) = NULL

as
begin

insert into registration(Name,
Email_id,
Password,
Phone_no,
Username
)

values(@Name,@Email_id,@Password,@Phone_no,@Name)
end