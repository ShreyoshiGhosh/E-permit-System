using Epermit.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Epermit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult PermitIssue()
        {

            return View();
        }




        [HttpGet]
        public ActionResult Issuepage()
        {
            PermitDetails permitDetails = new PermitDetails();
            permitDetails.Permit_Issue_ID = "";


            return View(permitDetails);
        }


        [HttpPost]
        public ActionResult Issuepage(PermitDetails permitDetails)
        {

            try
            {

                var id = Guid.NewGuid().ToString();

                permitDetails.Permit_Issue_ID = id;

                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["permitdatabase"].ConnectionString))
                {
                    SqlCommand sqlCommand = con.CreateCommand();
                    sqlCommand.Connection = con;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandText = "[E_Permit].[dbo].[issuepermitinsert]";
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    sqlCommand.Parameters.AddWithValue("@Permit_Issue_ID", id);
                    
                    sqlCommand.Parameters.AddWithValue("@IssuedByDeparment", permitDetails.IssuedByDeparment);
                    sqlCommand.Parameters.AddWithValue("@IssuedByArea", permitDetails.IssuedByArea);
                    sqlCommand.Parameters.AddWithValue("@IssuedToDeparment", permitDetails.IssuedToDeparment);
                    sqlCommand.Parameters.AddWithValue("@IssuedToArea", permitDetails.IssuedToArea);
                    sqlCommand.Parameters.AddWithValue("@PermitIssueDate", permitDetails.PermitIssueDate);
                    sqlCommand.Parameters.AddWithValue("@PermitShift", permitDetails.PermitShift);
                    sqlCommand.Parameters.AddWithValue("@JobDescription", permitDetails.JobDescription);
                    sqlCommand.Parameters.AddWithValue("@IsPermitToBeRecievedByIndividual", permitDetails.IsPermitToBeRecievedByIndividual);
                    sqlCommand.Parameters.AddWithValue("@IsGasTestRequired", permitDetails.IsGasTestRequired);
                    sqlCommand.Parameters.AddWithValue("@LocationOfWork", permitDetails.LocationOfWork);
                    sqlCommand.Parameters.AddWithValue("@WithSAPnotification", permitDetails.WithSAPnotification);
                    sqlCommand.Parameters.AddWithValue("@WithSAPPMONotification", permitDetails.WithSAPPMONotification);
                    sqlCommand.Parameters.AddWithValue("@WithSAPPMsuborder", permitDetails.WithSAPPMsuborder);
                    sqlCommand.Parameters.AddWithValue("@WithuoutSAPnotification", permitDetails.WithuoutSAPnotification);
                    sqlCommand.Parameters.AddWithValue("@ReasonForWithoutSAPnotification", permitDetails.ReasonForWithoutSAPnotification);
                    sqlCommand.Parameters.AddWithValue("@WithWorkOrderNumber", permitDetails.WithWorkOrderNumber);
                    sqlCommand.Parameters.AddWithValue("@WithoutWorkOrderNumber", permitDetails.WithoutWorkOrderNumber);
                    sqlCommand.Parameters.AddWithValue("@ReasonForWithoutWorkOrderNumber", permitDetails.ReasonForWithoutWorkOrderNumber);
                



                    sqlCommand.Parameters.Add("@status", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;

                    sqlCommand.Connection.Open();
                    var response = sqlCommand.ExecuteNonQuery();

                    sqlCommand.Connection.Close();
                }

            }
            catch (Exception ex)    { }

            return View(permitDetails);
        }



        [HttpPost]
        public JsonResult InsertColdPermit(ColdPermit coldPermit)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["permitdatabase"].ConnectionString))
                {
                    SqlCommand sqlCommand = con.CreateCommand();
                    sqlCommand.Connection = con;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandText = "[E_Permit].[dbo].[coldpermitinsert]";
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@WorkAreaInspected", coldPermit.WorkAreaInspected);
                    sqlCommand.Parameters.AddWithValue("@SurroundingARea", coldPermit.SurroundingARea);
                    sqlCommand.Parameters.AddWithValue("@SurroundingAReaChecklist", JsonConvert.SerializeObject(coldPermit.SurroundingAReaChecklist));

                    sqlCommand.Parameters.AddWithValue("@EquipmentElectricallyIsolated", coldPermit.EquipmentElectricallyIsolated);
                    sqlCommand.Parameters.AddWithValue("@RunningWater", coldPermit.RunningWater);
                    sqlCommand.Parameters.AddWithValue("@RunningWaterChecklist", JsonConvert.SerializeObject(coldPermit.RunningWaterChecklist));

                    sqlCommand.Parameters.AddWithValue("@Equipment", coldPermit.Equipment);
                    sqlCommand.Parameters.AddWithValue("@EquipmentChecklist", JsonConvert.SerializeObject(coldPermit.EquipmentChecklist));


                    sqlCommand.Parameters.AddWithValue("@EquipmentProperty", coldPermit.EquipmentProperty);
                    sqlCommand.Parameters.AddWithValue("@EquipmentPropertyChecklist", JsonConvert.SerializeObject(coldPermit.EquipmentPropertyChecklist));


                    sqlCommand.Parameters.AddWithValue("@EquipmentWaterFlushed", coldPermit.EquipmentWaterFlushed);
                    sqlCommand.Parameters.AddWithValue("@IronSulphide", coldPermit.IronSulphide);
                    sqlCommand.Parameters.AddWithValue("@EquipmentProperlySteamed", coldPermit.EquipmentProperlySteamed);
                    sqlCommand.Parameters.AddWithValue("@GasTest", coldPermit.GasTest);
                    sqlCommand.Parameters.AddWithValue("@StandbyPerson", coldPermit.StandbyPerson);
                    sqlCommand.Parameters.AddWithValue("@VentilationandLighting", coldPermit.VentilationandLighting);
                    sqlCommand.Parameters.AddWithValue("@AreaCordoned", coldPermit.AreaCordoned);
                    sqlCommand.Parameters.AddWithValue("@RadioIsotopes", coldPermit.RadioIsotopes);
                    sqlCommand.Parameters.AddWithValue("@ppe", coldPermit.ppe);

                    sqlCommand.Parameters.AddWithValue("@permitId", coldPermit.permitId);
                   
                     



                    //sqlCommand.Parameters.Add("@status", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;

                    sqlCommand.Connection.Open();
                    var response = sqlCommand.ExecuteNonQuery();

                    sqlCommand.Connection.Close();
                }

            }
            catch (Exception ex) { }

            return Json(null);

        }

        public JsonResult InsertHotPermit(HotPermit hotPermit)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["permitdatabase"].ConnectionString))
                {
                    SqlCommand sqlCommand = con.CreateCommand();
                    sqlCommand.Connection = con;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandText = "[E_Permit].[dbo].[hotpermitinsert]";
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@checking", hotPermit.checking);
                    sqlCommand.Parameters.AddWithValue("@checkingChecklist", JsonConvert.SerializeObject(hotPermit.checkingChecklist));


                    sqlCommand.Parameters.AddWithValue("@SurroundingARea", hotPermit.SurroundingARea);
                    sqlCommand.Parameters.AddWithValue("@hotSurroundingAReaChecklist", JsonConvert.SerializeObject(hotPermit.hotSurroundingAReaChecklist));

                    sqlCommand.Parameters.AddWithValue("@SewersManholesCBDandHotSurface", hotPermit.SewersManholesCBDandHotSurface);
                    sqlCommand.Parameters.AddWithValue("@SewersManholesCBDandHotSurfaceChecklist", JsonConvert.SerializeObject(hotPermit.SewersManholesCBDandHotSurfaceChecklist));

                    sqlCommand.Parameters.AddWithValue("@ConsideredHazardFrom", hotPermit.ConsideredHazardFrom);
                    sqlCommand.Parameters.AddWithValue("@EquipmentElectricallyIsolated", hotPermit.EquipmentElectricallyIsolated);
                    sqlCommand.Parameters.AddWithValue("@FireWaterhose_PortableExtinguishers", hotPermit.FireWaterhose_PortableExtinguishers);
                    sqlCommand.Parameters.AddWithValue("@EquipmentProperlyDrained_Depressurized", hotPermit.EquipmentProperlyDrained_Depressurized);
                    sqlCommand.Parameters.AddWithValue("@CheckforOilgas_Trapped", hotPermit.CheckforOilgas_Trapped);
                    sqlCommand.Parameters.AddWithValue("@WeldingMachineCheckedfor", hotPermit.WeldingMachineCheckedfor);
                    sqlCommand.Parameters.AddWithValue("@EquipmentProperlySteamed_Purged", hotPermit.EquipmentProperlySteamed_Purged);
                    sqlCommand.Parameters.AddWithValue("@ShieldAgainstSparks", hotPermit.ShieldAgainstSparks);
                    sqlCommand.Parameters.AddWithValue("@ProperMeansofExit", hotPermit.ProperMeansofExit);
                    sqlCommand.Parameters.AddWithValue("@IronSulphide", hotPermit.IronSulphide);
                    sqlCommand.Parameters.AddWithValue("@GasTest", hotPermit.GasTest);

                    sqlCommand.Parameters.AddWithValue("@hot_permit_ID", hotPermit.hot_permit_ID);



                    //sqlCommand.Parameters.Add("@status", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;

                    sqlCommand.Connection.Open();
                    var response = sqlCommand.ExecuteNonQuery();

                    sqlCommand.Connection.Close();
                }

            }
            catch (Exception ex) { }

            return Json(null);

        }


















        public ActionResult Recievepage()
        {
            List<PermitDetails> listOfPermitDetails = new List<PermitDetails>();

            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["permitdatabase"].ConnectionString))
            {
                SqlCommand sqlCommand = con.CreateCommand();
                sqlCommand.Connection = con;
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "[E_Permit].[dbo].[showallpermit]";
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Connection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    listOfPermitDetails = DataReaderMapToList<PermitDetails>(reader).ToList();

                }
                sqlCommand.Connection.Close();
            }

            return View(listOfPermitDetails);
        }


        [HttpPost]
        public JsonResult RecievePermit(string permitid)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["permitdatabase"].ConnectionString))
                {
                    SqlCommand sqlCommand = con.CreateCommand();
                    sqlCommand.Connection = con;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandText = "[E_Permit].[dbo].[UpdateReceivedSTatus]";
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@Permit_Issue_ID", permitid);
                    sqlCommand.Parameters.AddWithValue("@IsPermitReceived", true);

                    sqlCommand.Connection.Open();
                    var response = sqlCommand.ExecuteNonQuery();

                    sqlCommand.Connection.Close();
                }

            }
            catch (Exception ex) { }

            return Json(null);

        }



        public ActionResult Showallpermit()
        {

            List<PermitDetails> listOfPermitDetails = new List<PermitDetails>();

            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["permitdatabase"].ConnectionString))
            {
                SqlCommand sqlCommand = con.CreateCommand();
                sqlCommand.Connection = con;
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "[E_Permit].[dbo].[showallpermit]";
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Connection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    listOfPermitDetails = DataReaderMapToList<PermitDetails>(reader).ToList();

                }
                sqlCommand.Connection.Close();
            }

            return View(listOfPermitDetails);
        }
        
        
        public ActionResult Loginpage()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Registration(User user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["permitdatabase"].ConnectionString))
                {
                    SqlCommand sqlCommand = con.CreateCommand();
                    sqlCommand.Connection = con;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandText = "[E_Permit].[dbo].[insertregitration]";
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@Name", user.Name);
                    sqlCommand.Parameters.AddWithValue("@Email_id", user.Email_id);
                    sqlCommand.Parameters.AddWithValue("@Password", user.Password);
                    sqlCommand.Parameters.AddWithValue("@Phone_no", user.Phone_no);
                    sqlCommand.Parameters.AddWithValue("@Username", user.Username);

                    sqlCommand.Connection.Open();
                    var response = sqlCommand.ExecuteNonQuery();

                    sqlCommand.Connection.Close();
                }

            }
            catch (Exception ex) { }

            //return Json(null);
            return Json(new { status = "success", message = "Registration Done" });
        }


        [HttpPost]
        public JsonResult LoginUser(User user)
        {
            List<User> users = new List<User>();


            try
            {
                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["permitdatabase"].ConnectionString))
                {
                    SqlCommand sqlCommand = con.CreateCommand();
                    sqlCommand.Connection = con;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandText = "[E_Permit].[dbo].[LOGINSELECT]";
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@Password", user.Password);
                    sqlCommand.Parameters.AddWithValue("@Phone_no", user.Phone_no);

                    sqlCommand.Connection.Open();

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        users = DataReaderMapToList<User>(reader).ToList();
                    }
                    sqlCommand.Connection.Close();
                }

            }
            catch (Exception ex) { }

            if (users != null) 
            {
                if (users.Count > 0)
                {
                    return Json(new { status = "success", message = "Login Successful", user = users[0] });
                }
                else
                {
                    return Json(new { status = "error", message = "Wrong Credentials" });
                }
            }
            else
            {
                return Json(new { status = "error", message = "Wrong Credentials"});

            }
        }






        public ActionResult Informationpage(string permitId)
        {
            List<PermitDetails> listOfPermitDetails = new List<PermitDetails>();
            List<ColdPermit> coldpermit = new List<ColdPermit>();
            List<HotPermit> HotPermit = new List<HotPermit>();

            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["permitdatabase"].ConnectionString))
            {
                SqlCommand sqlCommand = con.CreateCommand();
                sqlCommand.Connection = con;
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "[E_Permit].[dbo].[showpermitbyid]";
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Permit_Issue_ID", permitId);
                sqlCommand.Connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    listOfPermitDetails = DataReaderMapToList<PermitDetails>(reader).ToList();
                }
                sqlCommand.Connection.Close();


               /* sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "[E_Permit].[dbo].[showColdPermitbyid]";
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Permit_Issue_ID", permitId);
                sqlCommand.Connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    coldpermit = DataReaderMapToList<ColdPermit>(reader).ToList();
                }
                sqlCommand.Connection.Close();


                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "[E_Permit].[dbo].[showHotPermitbyid]";
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Permit_Issue_ID", permitId);
                sqlCommand.Connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    HotPermit = DataReaderMapToList<HotPermit>(reader).ToList();
                }
                sqlCommand.Connection.Close();*/
            
            }

            return View(listOfPermitDetails[0]);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home/Issuepage");
        }


        private static List<T> DataReaderMapToList<T>(DbDataReader dr)
        {
            List<T> list = new List<T>();
            try
            {
                while (dr.Read())
                {
                    var obj = Activator.CreateInstance<T>();
                    foreach (PropertyInfo prop in obj.GetType().GetProperties())
                    {
                        if (!Equals(dr[prop.Name], DBNull.Value))
                        {
                            prop.SetValue(obj, dr[prop.Name], null);
                        }
                    }
                    list.Add(obj);
                }
            }
            catch (Exception ex) { }
            return list;
        }

    }
}