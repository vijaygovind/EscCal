using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EscCalc.Domain.Abstract;
using EscCalc.Domain.Entities.Models;
using EscCalc.Domain.Entities.MyEntities;
using EscCalc.Domain.Entities.ClassModel;
using EscCalc.Domain.Entities;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Text;
using System.Web;

namespace EscCalc.Domain.Implementation
{
    public class UnitofWork
    {
        private ESCCALCEntities dbcontext = new ESCCALCEntities();


        private Repository<TxnCaseVersion> caseRepository;
        private Repository<TxnFinalCalcParameter> txnFinalCalcParameter;

        private Repository<TxnCase> casRepository;

        private Repository<MasterProduct> productRepository;

        private Repository<MasterPowerSupply> powerSupplyRepository;

        public List<TxnCaseVersionValuesForIndex> GetAllTxnCaseVersions()
        {
            List<TxnCaseVersionValuesForIndex> txnCaseVersionValuesForIndexs = new List<TxnCaseVersionValuesForIndex>();
            txnCaseVersionValuesForIndexs = (from TCV in dbcontext.TxnCaseVersions
                                             join MP in dbcontext.MasterProducts on TCV.ProductId equals MP.ProductId
                                             join TC in dbcontext.TxnCases on TCV.CaseId equals TC.CaseId
                                             join MTP in dbcontext.MasterTrussPackages on TCV.TrussPackageId equals MTP.TrussPackageId

                                             select new TxnCaseVersionValuesForIndex
                                             {
                                                 CaseName = TC.CaseName,
                                                 VersionNumber = TCV.VersionNumber,
                                                 Project = TCV.Project,
                                                 ProductName = MP.ProductName,
                                                 VerticalRise = TCV.VerticalRise,
                                                 TrussPackageName = MTP.TrussPackageName,
                                                 StepWidth = TCV.StepWidth,
                                                 CreatedBy = TCV.CreatedBy,
                                                 CreatedOn = TCV.CreatedOn
                                             }).ToList();

            return txnCaseVersionValuesForIndexs;
        }
        //public List<TxnCaseVersionValuesForTemplate> GetTemplatevalues()
        //{
        //    List<TxnCaseVersionValuesForTemplate> txnCaseVersionValuesForIndexs = new List<TxnCaseVersionValuesForTemplate>();
        //    txnCaseVersionValuesForIndexs = (from TCV in dbcontext.TxnCaseVersions
        //                                     join TCF in dbcontext.TxnFinalCalcParameters on TCV.CaseVersionId equals TCF.CaseVersionId
        //                                     join MP in dbcontext.MasterProducts on TCV.ProductId equals MP.ProductId
        //                                     join MG in dbcontext.MasterGearboxTypes on TCV.GearBoxTypeId equals MG.GearBoxTypeId
        //                                     select new TxnCaseVersionValuesForTemplate
        //                                     {
        //                                         CaseversionID = TCV.CaseVersionId,
        //                                         CalculationID = TCF.CalculationId,
        //                                         Project = TCV.Project,
        //                                         ProductName = MP.ProductName,
        //                                         VerticalRise = TCV.VerticalRise,
        //                                         GearBoxTypeName = MG.GearBoxTypeName,
        //                                         SafetyFactorGearBox = TCF.SafetyFactorGearBox,
        //                                         CreatedBy = TCV.CreatedBy,
        //                                         CreatedOn = TCV.CreatedOn,
        //                                         PinPressure = TCF.PinPressure,
        //                                         TotalChainLifeTimeElongation = TCF.TotalChainLifeTimeElongation
        //                                     }).ToList();

        //    return txnCaseVersionValuesForIndexs;
        //}
        //public string ReplacetemplateValues(string template, List<TxnCaseVersionValuesForTemplate> lstvalues)
        //{
        //    template = template.Replace("[PROJECT]", lstvalues[0].Project.ToString());
        //    template = template.Replace("[ProductName]", lstvalues[0].ProductName.ToString());
        //    template = template.Replace("[VerticalRise]", Convert.ToString(lstvalues[0].VerticalRise).ToString());
        //    template = template.Replace("[GearBoxTypeName]", lstvalues[0].GearBoxTypeName.ToString());
        //    template = template.Replace("[SafetyFactorGearBox]", Convert.ToString(lstvalues[0].SafetyFactorGearBox).ToString());
        //    template = template.Replace("[CreatedBy]", lstvalues[0].CreatedBy.ToString());

        //    template = template.Replace("[CreatedOn]", Convert.ToString(lstvalues[0].CreatedOn).ToString());
        //    template = template.Replace("[PinPressure]", Convert.ToString(lstvalues[0].PinPressure).ToString());
        //    template = template.Replace("[TotalChainLifeTimeElongation]", Convert.ToString(lstvalues[0].TotalChainLifeTimeElongation).ToString());

        //    return template;
        //}
        //public void TxnFinalCalc_Parameter()
        //{
        //    List<TxnCaseVersionValuesForTemplate> lstTemplate = new List<TxnCaseVersionValuesForTemplate>();
        //    lstTemplate = GetTemplatevalues();
        //    List<TxnFinalCalcParameter> lst = new List<TxnFinalCalcParameter>();
        //    string text = System.IO.File.ReadAllText(HttpContext.Current.Server.MapPath("~/Template/Output.html"));
        //    text = ReplacetemplateValues(text, lstTemplate);
        //    Byte[] bytes;
        //    using (var ms = new MemoryStream())
        //    {
        //        using (var doc = new Document())
        //        {
        //            using (var writer = PdfWriter.GetInstance(doc, ms))
        //            {
        //                doc.Open();

        //                var example_html = text;// @"<p>This <em>is </em><span class=""headline"" style=""text-decoration: underline;"">some</span> <strong>sample <em> text</em></strong><span style=""color: red;"">!!!</span></p>";

        //                using (var htmlWorker = new iTextSharp.text.html.simpleparser.HTMLWorker(doc))
        //                {

        //                    using (var sr = new StringReader(example_html))
        //                    {
        //                        htmlWorker.Parse(sr);
        //                    }
        //                }
        //                doc.Close();
        //            }
        //        }

        //        //After all of the PDF "stuff" above is done and closed but **before** we
        //        //close the MemoryStream, grab all of the active bytes from the stream
        //        bytes = ms.ToArray();
        //    }
        //    var testFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "test.pdf");
        //    System.IO.File.WriteAllBytes(testFile, bytes);

        //}

        //public List<TxnFinalCalcParameter> GetAllFinalCalc()
        //{
        //    List<TxnFinalCalcParameter> txnFinalCalcParameter = new List<TxnFinalCalcParameter>();
        //    txnFinalCalcParameter = (from c in dbcontext.TxnFinalCalcParameters
        //                             select new TxnFinalCalcParameter
        //                             {
        //                                 MotorPower = c.MotorPower;
        //                                 Dece
        //                                }).ToList();
        //    return txnFinalCalcParameter;
        //}

        private Repository<MasterTrussPackage> trussPackageRepository;
        private Repository<MasterStepChainGuide> stepChainGuideRepository;
        private Repository<MasterStepMaterial> stepMaterialRepository;
        private Repository<MasterStepChainType> stepChainTypeRepository;
        private Repository<MasterWearingFactor> wearingFactorRepository;

        private Repository<MasterCountryType> countryTypeRepository;
        private Repository<MasterEnvironmentType> environmentTypeRepository;
        private Repository<MasterGearboxType> gearboxTypeRepository;
        private Repository<MasterStrandQuantity> strandQuantityRepository;
        private Repository<MasterImpactCoefficient> impactCoefficientyRepository;
        private Repository<MasterHandrailDriveType> handrailDriveTypeRepository;
        private Repository<MasterHandrailShapeType> handrailShapeTypeRepository;
        private Repository<MasterNominalStepWidth> nominalStepWidthRepository;

        private Repository<MasterSafetyFactorandPinPressure> safetyFactorandPinPressure;

        private Repository<MasterNominalStepbandSpeed> nominalStepbandSpeedRepository;


        //Accessors for each private repository, creates repository if null
        public IRepository<TxnCaseVersion> CaseRepository
        {
            get
            {
                if (caseRepository == null)
                {
                    caseRepository = new Repository<TxnCaseVersion>(dbcontext);
                }
                return caseRepository;
            }

        }
        public IRepository<TxnFinalCalcParameter> TxnFinalCalcParameter
        {
            get
            {
                if (txnFinalCalcParameter == null)
                {
                    txnFinalCalcParameter = new Repository<TxnFinalCalcParameter>(dbcontext);
                }
                return txnFinalCalcParameter;
            }

        }
        public IRepository<MasterSafetyFactorandPinPressure> SafetyFactorandPinPressure
        {
            get
            {
                if (safetyFactorandPinPressure == null)
                {
                    safetyFactorandPinPressure = new Repository<MasterSafetyFactorandPinPressure>(dbcontext);
                }
                return safetyFactorandPinPressure;
            }

        }

        public IRepository<MasterEnvironmentType> EnvironmentTypeRepository
        {
            get
            {
                if (environmentTypeRepository == null)
                {
                    environmentTypeRepository = new Repository<MasterEnvironmentType>(dbcontext);
                }
                return environmentTypeRepository;
            }

        }
        public IRepository<TxnCase> CasRepository
        {
            get
            {
                if (casRepository == null)
                {
                    casRepository = new Repository<TxnCase>(dbcontext);
                }
                return casRepository;
            }



        }
        public IRepository<MasterNominalStepWidth> NominalStepWidthRepository
        {
            get
            {
                if (nominalStepWidthRepository == null)
                {
                    nominalStepWidthRepository = new Repository<MasterNominalStepWidth>(dbcontext);
                }
                return nominalStepWidthRepository;
            }

        }
        public IRepository<MasterNominalStepbandSpeed> NominalStepBandSpeedRepository
        {
            get
            {
                if (nominalStepbandSpeedRepository == null)
                {
                    nominalStepbandSpeedRepository = new Repository<MasterNominalStepbandSpeed>(dbcontext);
                }
                return nominalStepbandSpeedRepository;
            }

        }



        public void SaveCaseInfo(CaseProperties model)
        {
            TxnCase txnCase = new TxnCase();
            TxnCaseVersion txncaseVersion = new TxnCaseVersion();
            MasterProduct mstProduct = new MasterProduct();
            MasterNominalStepbandSpeed mstNomonalStepBandSpeed = new MasterNominalStepbandSpeed();
            MasterNominalStepWidth mstStepwidth = new MasterNominalStepWidth();
            MasterTrussPackage mstTruss = new MasterTrussPackage();
            MasterStepChainGuide mstGuide = new MasterStepChainGuide();
            MasterInclination mstInclination = new MasterInclination();
            MasterStepMaterial mstStepMaterial = new MasterStepMaterial();
            MasterStepChainType mst = new MasterStepChainType();
            MasterWearingFactor mstWearing = new MasterWearingFactor();
            MasterSafetyFactorandPinPressure mstSafety = new MasterSafetyFactorandPinPressure();
            MasterCountryType mstCountry = new MasterCountryType();
            MasterEnvironmentType mstEnvironment = new MasterEnvironmentType();
            MasterPowerSupply mstPower = new MasterPowerSupply();
            MasterGearboxType mstGearbox = new MasterGearboxType();
            MasterStrandQuantity mststrand = new MasterStrandQuantity();
            MasterImpactCoefficient mstImpact = new MasterImpactCoefficient();
            MasterHandrailShapeType mstHandraishape = new MasterHandrailShapeType();
            MasterHandrailDriveType mstHandrailDriveType = new MasterHandrailDriveType();

            txnCase.CaseName = model.CaseName;
            txnCase.CreatedBy = "A.Yaganteeswarudu";
            txnCase.CreatedOn = DateTime.Now;
            txnCase.Source = 1;
            
            dbcontext.TxnCases.Add(txnCase); dbcontext.SaveChanges();
            //txncaseVersion.CaseId = (from c in dbcontext.TxnCases where c.CaseName.Equals(model.CaseName) select c.CaseId);

            txncaseVersion.CaseId = dbcontext.TxnCases.First(a => a.CaseName == model.CaseName).CaseId;
            txncaseVersion.Project = model.Project;
            txncaseVersion.VersionNumber = 1;
            txncaseVersion.ProductId= dbcontext.MasterProducts.FirstOrDefault(a => a.ProductId == model.ProductId).ProductId;
            txncaseVersion.ProductReleaseId = 1;
            txncaseVersion.VerticalRise = model.VerticalRise;
            //txncaseVersion.StepbandSpeedId = (from s in dbcontext.MasterNominalStepbandSpeeds where s.StepbandSpeed == model.StepbandSpeed select s.StepbandSpeedId).First();
            //txncaseVersion.StepWidthId = (from s in dbcontext.MasterNominalStepWidths where s.StepWidth == model.StepWidth select s.StepWidthId).FirstOrDefault();
            txncaseVersion.StepWidth = model.StepWidth;
            txncaseVersion.StepbandSpeed = model.StepbandSpeed;
            txncaseVersion.TrussPackageId = dbcontext.MasterTrussPackages.First(a => a.TrussPackageId == model.TrussPackageId).TrussPackageId;
            txncaseVersion.StepChainGuideId= dbcontext.MasterTrussPackages.First(a => a.TrussPackageId == model.TrussPackageId).TrussPackageId;
            txncaseVersion.TrussUpperExtensionLength = model.TrussUpperExtensionLength;
            txncaseVersion.TrussLowerExtensionLength = model.TrussLowerExtensionLength;
            //txncaseVersion.InclinationId= dbcontext.MasterProducts.FirstOrDefault(a => a.ProductId == model.ProductId).ProductId;
            txncaseVersion.HorizontalNoOfStepsUpper = model.HorizontalNoOfStepsUpper;
            txncaseVersion.HorizontalNoOfStepsLower = model.HorizontalNoOfStepsLower;
            txncaseVersion.TransitionRadiusUpperPassenger = model.TransitionRadiusUpperPassenger;
            txncaseVersion.TranstionRadiusLowerPassenger = model.TransitionRadiusLowerPassenger;
            txncaseVersion.TransitionRadiusUpperBackTrack = model.TransitionRadiusUpperBackTrack;
            txncaseVersion.TranstionRadiusLowerBackTrack = model.TranstionRadiusLowerBackTrack;
            txncaseVersion.StepBandTypeId= dbcontext.MasterStepMaterials.First(a => a.StepMaterialId == model.StepMaterialId).StepMaterialId;
            txncaseVersion.StepChainTypeId= dbcontext.MasterStepChainTypes.First(a => a.StepChainTypeId == model.StepChainTypeId).StepChainTypeId;
            txncaseVersion.StepChainConditionId= dbcontext.MasterWearingFactors.First(a => a.WearingFactorId == model.WearingFactorId).WearingFactorId;
            txncaseVersion.SafetyFactorandPinPressureId= dbcontext.MasterSafetyFactorandPinPressures.First(a => a.SafetyFactorandPinPressureId == model.SafetyFactorandPinPressureId).SafetyFactorandPinPressureId;
            txncaseVersion.DestinationCountryId= dbcontext.MasterCountryTypes.First(a => a.CountryId == model.DestinationCountryId).CountryId;
            txncaseVersion.EscalatorEnvironmentId= dbcontext.MasterEnvironmentTypes.First(a => a.EnvironmentId == model.EscalatorEnvironmentId).EnvironmentId;
            txncaseVersion.PowerSupplyId= dbcontext.MasterPowerSupplies.First(a => a.PowerSupplyId == model.PowerSupplyId).PowerSupplyId;
            txncaseVersion.GearBoxTypeId= dbcontext.MasterGearboxTypes.First(a => a.GearBoxTypeId == model.GearBoxTypeId).GearBoxTypeId;
            txncaseVersion.MainDriveStrandQuantityId= dbcontext.MasterEnvironmentTypes.First(a => a.EnvironmentId == model.EscalatorEnvironmentId).EnvironmentId;
            txncaseVersion.LoadTypeId= dbcontext.MasterEnvironmentTypes.First(a => a.EnvironmentId == model.EscalatorEnvironmentId).EnvironmentId;
            txncaseVersion.MainDriveChainConditionId= dbcontext.MasterPowerSupplies.First(a => a.PowerSupplyId == model.PowerSupplyId).PowerSupplyId;
            txncaseVersion.SafetyFactor = model.SafetyFactor;
            txncaseVersion.HandrailTypeId= dbcontext.MasterProducts.FirstOrDefault(a => a.ProductId == model.ProductId).ProductId;
            txncaseVersion.HandrailDriveTypeId= dbcontext.MasterPowerSupplies.First(a => a.PowerSupplyId == model.PowerSupplyId).PowerSupplyId;
            txncaseVersion.IsCustomStep = model.IsCustomStep;
            txncaseVersion.IsCustomStepChain = model.IsCustomStepChain;
            txncaseVersion.IsCustomTrackSystem = model.IsCustomTrackSystem;
            txncaseVersion.IsCustomGearbox = model.IsCustomGearbox;
            txncaseVersion.IsCustomHandrail = model.IsCustomHandrail;
            txncaseVersion.IsFreezed = model.IsFreezed;
            txncaseVersion.Report = "abcd";
            txncaseVersion.CreatedBy = "A.Yaganteeswarudu";
            txncaseVersion.CreatedOn = DateTime.Now;
            txncaseVersion.ModifiedOn = DateTime.Now;
            txncaseVersion.IsEditable = model.IsEditable;
            txncaseVersion.Comments = "I created ";


            dbcontext.TxnCaseVersions.Add(txncaseVersion);
            dbcontext.SaveChanges();
        }

        public IRepository<MasterHandrailShapeType> HandrailShapeTypeRepository
        {
            get
            {
                if (handrailShapeTypeRepository == null)
                {
                    handrailShapeTypeRepository = new Repository<MasterHandrailShapeType>(dbcontext);
                }
                return handrailShapeTypeRepository;
            }

        }
        public IRepository<MasterHandrailDriveType> HandrailDriveTypeRepository
        {
            get
            {
                if (handrailDriveTypeRepository == null)
                {
                    handrailDriveTypeRepository = new Repository<MasterHandrailDriveType>(dbcontext);
                }
                return handrailDriveTypeRepository;
            }

        }
        public IRepository<MasterImpactCoefficient> ImpactCoefficientRepository
        {
            get
            {
                if (impactCoefficientyRepository == null)
                {
                    impactCoefficientyRepository = new Repository<MasterImpactCoefficient>(dbcontext);
                }
                return impactCoefficientyRepository;
            }

        }
        public IRepository<MasterStrandQuantity> StrandQuantityRepository
        {
            get
            {
                if (strandQuantityRepository == null)
                {
                    strandQuantityRepository = new Repository<MasterStrandQuantity>(dbcontext);
                }
                return strandQuantityRepository;
            }

        }
        public IRepository<MasterGearboxType> GearboxTypeRepository
        {
            get
            {
                if (gearboxTypeRepository == null)
                {
                    gearboxTypeRepository = new Repository<MasterGearboxType>(dbcontext);
                }
                return gearboxTypeRepository;
            }

        }
        public IRepository<MasterProduct> ProductRepository
        {

            get
            {
                if (productRepository == null)
                {
                    productRepository = new Repository<MasterProduct>(dbcontext);
                }

                return productRepository;
            }

        }
        public IRepository<MasterCountryType> CountryTypeRepository
        {

            get
            {
                if (countryTypeRepository == null)
                {
                    countryTypeRepository = new Repository<MasterCountryType>(dbcontext);
                }

                return countryTypeRepository;
            }

        }
        public IRepository<MasterStepMaterial> StepMaterialRepository
        {

            get
            {
                if (stepMaterialRepository == null)
                {
                    stepMaterialRepository = new Repository<MasterStepMaterial>(dbcontext);
                }

                return stepMaterialRepository;
            }

        }
        public IRepository<MasterWearingFactor> WearingFactorRepository
        {

            get
            {
                if (wearingFactorRepository == null)
                {
                    wearingFactorRepository = new Repository<MasterWearingFactor>(dbcontext);
                }

                return wearingFactorRepository;
            }

        }
        public IRepository<MasterStepChainType> StepChainTypeRepository
        {

            get
            {
                if (stepChainTypeRepository == null)
                {
                    stepChainTypeRepository = new Repository<MasterStepChainType>(dbcontext);
                }

                return stepChainTypeRepository;
            }

        }
        public IRepository<MasterTrussPackage> TrussPackagRepository
        {

            get
            {
                if (trussPackageRepository == null)
                {
                    trussPackageRepository = new Repository<MasterTrussPackage>(dbcontext);
                }

                return trussPackageRepository;
            }

        }
        public IRepository<MasterStepChainGuide> StepChainGuideRepository
        {

            get
            {
                if (stepChainGuideRepository == null)
                {
                    stepChainGuideRepository = new Repository<MasterStepChainGuide>(dbcontext);
                }

                return stepChainGuideRepository;
            }

        }


        public IRepository<MasterPowerSupply> PowerSupplyRepository
        {

            get
            {
                if (powerSupplyRepository == null)
                {
                    powerSupplyRepository = new Repository<MasterPowerSupply>(dbcontext);
                }
                return powerSupplyRepository;
            }
        }



        public int Complete()
        {
            return dbcontext.SaveChanges();
        }

        public void Dispose()
        {
            dbcontext.Dispose();
        }
    }
}
