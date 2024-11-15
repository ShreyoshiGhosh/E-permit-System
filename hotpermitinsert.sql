USE [E_Permit]
GO
/****** Object:  StoredProcedure [dbo].[hotpermitinsert]    Script Date: 15-07-2024 23:22:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure 
[dbo].[hotpermitinsert]

@checking nvarchar(max) = NULL,
@checkingChecklist nvarchar(max) = NULL,
@SurroundingARea nvarchar(max) = NULL,
@hotSurroundingAReaChecklist nvarchar(max) = NULL,
@SewersManholesCBDandHotSurface nvarchar(20) = NULL,
@SewersManholesCBDandHotSurfaceChecklist nvarchar(20) = NULL,
@ConsideredHazardFrom nvarchar(max) = NULL,
@EquipmentElectricallyIsolated nvarchar(20) = NULL,
@FireWaterhose_PortableExtinguishers nvarchar(max) = NULL,
@EquipmentProperlyDrained_Depressurized nvarchar(20) = NULL,
@CheckforOilgas_Trapped nvarchar(20) = NULL,
@WeldingMachineCheckedfor nvarchar(max) = NULL,
@EquipmentProperlySteamed_Purged nvarchar(20) = NULL,
@ShieldAgainstSparks nvarchar(20) = NULL,
@ProperMeansofExit nvarchar(20) = NULL,
@IronSulphide nvarchar(20) = NULL,
@GasTest nvarchar(max) = NULL,
@ClearanceForDykeWallCutting nvarchar(20) = NULL,
@ProperTags_Boards nvarchar(20) = NULL,
@EquipmentWaterFlushed nvarchar(20) = NULL,
@StandByPersonal_FireWatch nvarchar(max) = NULL,
@PortableEquipment_Nozzles nvarchar(20) = NULL,
@StandbyPersonal_VesselEntry nvarchar(20) = NULL,
@ClearanceForRoadCuttingFromTech_Fire_ConcerenedDept nvarchar(20) = NULL,
@ClearanceForAreaCivil_Excavation nvarchar(20) = NULL,
@Equipment nvarchar(max) = NULL,
@PrecautionAgainstPublicTraffic nvarchar(20) = NULL,
@VentilationAndLightning nvarchar(20) = NULL,
@PrecautionaryTags_Boards nvarchar(20) = NULL,
@AreaCordonedOf nvarchar(20) = NULL,
@ClearanceForExcavation_Electrical_ConcerenedDept nvarchar(20) = NULL,
@Flame_SparkArrestor nvarchar(20) = NULL,
@ppe nvarchar(max) = NULL

as
begin


if  @checking is not null and
@checkingChecklist is not null and
@SurroundingARea is not null and
@hotSurroundingAReaChecklist is not null and
@SewersManholesCBDandHotSurface is not null and 
@SewersManholesCBDandHotSurfaceChecklist is not null 

begin
insert into HOT_PERMIT (checking,checkingChecklist,SurroundingARea,hotSurroundingAReaChecklist, SewersManholesCBDandHotSurface,SewersManholesCBDandHotSurfaceChecklist, ConsideredHazardFrom, EquipmentElectricallyIsolated, FireWaterhose_PortableExtinguishers, EquipmentProperlyDrained_Depressurized, CheckforOilgas_Trapped,
WeldingMachineCheckedfor, EquipmentProperlySteamed_Purged, ShieldAgainstSparks, ProperMeansofExit, IronSulphide, GasTest, ClearanceForDykeWallCutting, ProperTags_Boards, EquipmentWaterFlushed, StandByPersonal_FireWatch,
PortableEquipment_Nozzles,StandbyPersonal_VesselEntry, ClearanceForRoadCuttingFromTech_Fire_ConcerenedDept, ClearanceForAreaCivil_Excavation, Equipment,PrecautionAgainstPublicTraffic,VentilationAndLightning,PrecautionaryTags_Boards, 
AreaCordonedOf,ClearanceForExcavation_Electrical_ConcerenedDept, Flame_SparkArrestor, ppe )
values (@checking,
@checkingChecklist,
@SurroundingARea, 
@hotSurroundingAReaChecklist,
@SewersManholesCBDandHotSurface, 
@SewersManholesCBDandHotSurfaceChecklist,
@ConsideredHazardFrom, 
@EquipmentElectricallyIsolated, 
@FireWaterhose_PortableExtinguishers, 
@EquipmentProperlyDrained_Depressurized, 
@CheckforOilgas_Trapped,
@WeldingMachineCheckedfor, 
@EquipmentProperlySteamed_Purged, 
@ShieldAgainstSparks, 
@ProperMeansofExit, 
@IronSulphide, 
@GasTest, 
@ClearanceForDykeWallCutting, 
@ProperTags_Boards, 
@EquipmentWaterFlushed, 
@StandByPersonal_FireWatch,
@PortableEquipment_Nozzles,
@StandbyPersonal_VesselEntry, 
@ClearanceForRoadCuttingFromTech_Fire_ConcerenedDept, 
@ClearanceForAreaCivil_Excavation, 
@Equipment, 
@PrecautionAgainstPublicTraffic,
@VentilationAndLightning,
@PrecautionaryTags_Boards, 
@AreaCordonedOf,
@ClearanceForExcavation_Electrical_ConcerenedDept, 
@Flame_SparkArrestor, 
@ppe)
end
end