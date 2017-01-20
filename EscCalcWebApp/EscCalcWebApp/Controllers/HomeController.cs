using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EscCalc.Domain.Implementation;
using EscCalc.Domain.Entities.Models;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using EscCalc.Domain.Entities.MyEntities;
using System.Diagnostics;
using System.IO;

namespace EscCalcWebApp.Controllers
{
    public class HomeController : Controller
    {

      
        public ActionResult Index()
        {
            UnitofWork UoW = new UnitofWork();
            //var NewCase = UoW.CaseRepository.Get(1);

            //ViewBag.Pro = UoW.ProductRepository.GetAll;
            return View(UoW.GetAllTxnCaseVersions());

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page. 1";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult NonStandard()
        {


            return View();
        }
        public ActionResult Advanced()
        {


            return View();
        }
      
        public ActionResult Report()
        {
            UnitofWork UoW = new UnitofWork();
            ViewBag.NewFinalCalc = UoW.TxnFinalCalcParameter.Get(13);


            return View();
        }

        public ActionResult DownloadViewPDF()
        {
            UnitofWork UoW = new UnitofWork();
            ////ESCCALCEntities esc = new ESCCALCEntities();
            //ViewBag.NewFinalCalc = UoW.TxnFinalCalcParameter.Get(1);

            ////Code to get content
            //return new Rotativa.ViewAsPdf("Report") { FileName = "EscalatorCalculationsReport.pdf" };

            //UnitofWork UoW = new UnitofWork();
            //UoW.TxnFinalCalc_Parameter();
            //ESCCALCEntities esc = new ESCCALCEntities();
            ViewBag.NewFinalCalc = UoW.TxnFinalCalcParameter.Get(13);

            //Code to get content
            return new Rotativa.ViewAsPdf("Report") { FileName = "EscalatorCalculationsReport.pdf" };
        }
        public ActionResult Case()
        {
            UnitofWork UoW = new UnitofWork();
            //ESCCALCEntities esc = new ESCCALCEntities();


            ViewBag.Pro = new SelectList(UoW.ProductRepository.GetAll, "ProductId", "ProductName");
            ViewBag.Truss = new SelectList(UoW.TrussPackagRepository.GetAll, "TrussPackageId", "TrussPackageName");
            List<string> GuideName = (from a in UoW.StepChainGuideRepository.GetAll
                                      select a.GuideName).Distinct().ToList();

            ViewBag.StepChain = new SelectList(GuideName);

            ViewBag.StepMaterial = new SelectList(UoW.StepMaterialRepository.GetAll, "StepMaterialId", "StepMaterialName");
            ViewBag.StepChainType = new SelectList(UoW.StepChainTypeRepository.GetAll, "StepChainTypeId", "StepChainTypeName");
            ViewBag.wearingFactor = new SelectList(UoW.WearingFactorRepository.GetAll, "WearingFactorId", "Name");
            ViewBag.countryType = new SelectList(UoW.CountryTypeRepository.GetAll, "CountryId", "CountryName");
            ViewBag.environmentType = new SelectList(UoW.EnvironmentTypeRepository.GetAll, "EnvironmentId", "EnvironmentTypeName");
            ViewBag.powerSupply = new SelectList(UoW.PowerSupplyRepository.GetAll, "PowerSupplyId", "Description");
            ViewBag.gearboxType = new SelectList(UoW.GearboxTypeRepository.GetAll, "GearBoxTypeId", "GearBoxTypeName");
            ViewBag.strandQuantity = new SelectList(UoW.StrandQuantityRepository.GetAll, "QuantityFactorId", "StrandQuantity");
            ViewBag.impactCoefficient = new SelectList(UoW.ImpactCoefficientRepository.GetAll, "FactorYId", "LoadType");
            ViewBag.handraiDriveType = new SelectList(UoW.HandrailDriveTypeRepository.GetAll, "HandrailDriveTypeId", "HandrailDriveTypeName");
            ViewBag.handrailShapeType = new SelectList(UoW.HandrailShapeTypeRepository.GetAll, "HandrailShapeTypeId", "HandrailShapeTypeName");
            //ViewBag.nominalStepBandSpeed = new SelectList(UoW.NominalStepBandSpeedRepository.GetAll, "StepbandSpeedId", "StepbandSpeed");
            ViewBag.safetyfactorPinPressure = new SelectList(UoW.SafetyFactorandPinPressure.GetAll, "SafetyFactorandPinPressureId", "Description");
            ViewBag.nominalStepBandSpeed = UoW.NominalStepBandSpeedRepository.GetAll;
            ViewBag.nominalStepWidth = UoW.NominalStepWidthRepository.GetAll;


            return View();


        }

        [HttpPost]

        public ActionResult SaveCaseInfo(CaseProperties model)
        {
            bool isCustomComponentsCheckBoxChecked = model.IsCustomStep || model.IsCustomStepChain || model.IsCustomTrackSystem || model.IsCustomGearbox || model.IsCustomHandrail ? true : false;
            UnitofWork UoW = new UnitofWork();
           
            UoW.SaveCaseInfo(model);
            if (isCustomComponentsCheckBoxChecked)
            {
                if (model.IsCustomStep)
                {
                    return View("NonStandard");
                }
                if (model.IsCustomStepChain)
                {
                    return View("StepChain");
                }
                else
                {
                    return View("Advanced");
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
