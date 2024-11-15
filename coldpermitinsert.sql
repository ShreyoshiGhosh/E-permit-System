USE [E_Permit]
GO
/****** Object:  StoredProcedure [dbo].[coldpermitinsert]    Script Date: 15-07-2024 23:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE
[dbo].[coldpermitinsert]

	@permitId varchar(36) =NULL,
	@WorkAreaInspected nvarchar(20) =NULL,
	@SurroundingARea nvarchar(max) =NULL,
	@SurroundingAReaChecklist nvarchar(max) =NULL, 

	@EquipmentElectricallyIsolated nvarchar(20) =NULL,
	@RunningWater nvarchar(max) =NULL,
	@RunningWaterChecklist nvarchar(max) =NULL,
	@Equipment nvarchar(MAX) =NULL,
	@EquipmentChecklist nvarchar(MAX) =NULL,
	@EquipmentProperty nvarchar(MAX) =NULL,
	@EquipmentPropertyChecklist nvarchar(MAX) =NULL,
	@EquipmentWaterFlushed nvarchar(20) =NULL,
	@IronSulphide nvarchar(20) =NULL,
	@EquipmentProperlySteamed nvarchar(20) =NULL,
	@GasTest nvarchar(MAX) =NULL,
	@StandbyPerson nvarchar(MAX) =NULL,
	@VentilationandLighting nvarchar(20) =NULL,
	@AreaCordoned nvarchar(20) =NULL,
	@RadioIsotopes nvarchar(20) =NULL,
	@ppe nvarchar(MAX) =NULL,
	@Stnt nvarchar(20)= ' '

as
begin

	IF @WorkAreaInspected IS NOT NULL AND @SurroundingARea IS NOT NULL AND @SurroundingAReaChecklist IS NOT NULL AND @EquipmentElectricallyIsolated IS NOT NULL AND  @RunningWater IS NOT NULL AND @RunningWaterChecklist IS NOT NULL AND @Equipment IS NOT NULL AND @EquipmentChecklist IS NOT NULL AND @EquipmentProperty IS NOT NULL AND @EquipmentPropertyChecklist IS NOT NULL AND  @EquipmentWaterFlushed IS NOT NULL 
	BEGIN
	    
		insert into cold_permit(permitId,
			WorkAreaInspected ,
			SurroundingARea ,
			SurroundingAReaChecklist,

			EquipmentElectricallyIsolated ,

			RunningWater ,
			RunningWaterChecklist,
			Equipment ,

			EquipmentChecklist,
			EquipmentProperty,
			EquipmentPropertyChecklist,
			EquipmentWaterFlushed ,
			IronSulphide ,
			EquipmentProperlySteamed ,
			GasTest ,
			StandbyPerson ,
			VentilationandLighting ,
			AreaCordoned ,
			RadioIsotopes ,
			ppe 
			)
		values (@permitId,@WorkAreaInspected,@SurroundingARea, @SurroundingAReaChecklist,@EquipmentElectricallyIsolated,
			@RunningWater,@RunningWaterChecklist,@Equipment,@EquipmentChecklist, @EquipmentProperty, 
			@EquipmentPropertyChecklist,@EquipmentWaterFlushed,@IronSulphide,@EquipmentProperlySteamed,@GasTest,
			@StandbyPerson,@VentilationandLighting,@AreaCordoned,@RadioIsotopes,@ppe)


		
	END


	


END