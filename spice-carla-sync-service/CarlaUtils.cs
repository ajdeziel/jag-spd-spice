﻿using CsvHelper;
using Gov.Jag.Spice.Interfaces;
using Gov.Jag.Spice.Interfaces.Models;
using Hangfire.Console;
using Hangfire.Server;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SpdSync;
using SpdSync.models;
using SpiceCarlaSync.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Gov.Jag.Spice.CarlaSync
{
    public class CarlaUtils
    {
        public ILogger _logger { get; }

        private IConfiguration Configuration { get; }
        private IDynamicsClient _dynamics;

        public CarlaUtils(IConfiguration Configuration, ILoggerFactory loggerFactory)
        {
            this.Configuration = Configuration;
            _logger = loggerFactory.CreateLogger(typeof(SpdUtils));
            _dynamics = DynamicsUtil.SetupDynamics(Configuration);
        }

        /// <summary>
        /// Hangfire job to receive an import from SPICE.
        /// </summary>
        public void ReceiveWorkerImportJob(PerformContext hangfireContext, List<WorkerScreeningRequest> requests)
        {
            hangfireContext.WriteLine("Starting SPICE Import Job.");
            _logger.LogError("Starting SPICE Import Job.");

            ImportWorkerRequestsToSMTP(hangfireContext, requests);

            hangfireContext.WriteLine("Done.");
            _logger.LogError("Done.");
        }

        /// <summary>
        /// Hangfire job to receive an import from SPICE.
        /// </summary>
        public void ReceiveApplicationImportJob(PerformContext hangfireContext, List<ApplicationScreeningRequest> requests)
        {
            hangfireContext.WriteLine("Starting SPICE Application Screening Import Job.");
            _logger.LogError("Starting SPICE Import Job.");

            ImportApplicationRequestsToSMTP(hangfireContext, requests);

            hangfireContext.WriteLine("Done.");
            _logger.LogError("Done.");
        }

        /// <summary>
        /// Import requests to Dynamics.
        /// </summary>
        /// <returns></returns>
        private void ImportApplicationRequests(PerformContext hangfireContext, List<ApplicationScreeningRequest> requests)
        {
            foreach (ApplicationScreeningRequest WorkerRequest in requests)
            {

                // add data to dynamics

            }
        }

        /// <summary>
        /// Import requests to SMTP
        /// </summary>
        /// <returns></returns>
        private void ImportApplicationRequestsToSMTP(PerformContext hangfireContext, List<ApplicationScreeningRequest> requests)
        {
            List<CsvAssociateExport> export = CreateBaseAssociatesExport(requests);
            string attachmentName = "Associates_ScreeningRequest.csv";
            string csvData = CreateAssociateCSV(export);
            bool sentEmail = SendSPDEmail(csvData, attachmentName);

            if (sentEmail)
            {
                _logger.LogError($"Sent email to {Configuration["SPD_EXPORT_EMAIL"]}.");
            }
            else
            {
                _logger.LogError($"Unable to send email to {Configuration["SPD_EXPORT_EMAIL"]}.");
            }

            List<CsvBusinessExport> businessExport = CreateBusinessExport(requests);
            string businessAttachmentName = "Business_ScreeningRequest.csv";
            string businessCsvData = CreateBusinessCSV(businessExport);
            bool businessSentEmail = SendSPDEmail(businessCsvData, businessAttachmentName);

            if (businessSentEmail)
            {
                _logger.LogError($"Sent email to {Configuration["SPD_EXPORT_EMAIL"]}.");
            }
            else
            {
                _logger.LogError($"Unable to send email to {Configuration["SPD_EXPORT_EMAIL"]}.");
            }
        }

        private List<CsvBusinessExport> CreateBusinessExport(List<ApplicationScreeningRequest> requests)
        {
            List<CsvBusinessExport> export = new List<CsvBusinessExport>();

            foreach (ApplicationScreeningRequest request in requests)
            {
                var business = new CsvBusinessExport()
                {
                    OrganizationName = request.ApplicantName,
                    JobId = request.RecordIdentifier,
                    BusinessNumber = request.BCeIDNumber,
                    BusinessAddressStreet1 = request.BusinessAddress.AddressStreet1,
                    BusinessCity = request.BusinessAddress.City,
                    BusinessStateProvince = request.BusinessAddress.StateProvince,
                    BusinessCountry = request.BusinessAddress.Country,
                    BusinessPostal = request.BusinessAddress.Postal,
                    EstablishmentParcelId = request.Establishment.ParcelId,
                    EstablishmentAddressStreet1 = request.Establishment.Address.AddressStreet1,
                    EstablishmentCity = request.Establishment.Address.City,
                    EstablishmentStateProvince = request.Establishment.Address.StateProvince,
                    EstablishmentCountry = request.Establishment.Address.Country,
                    EstablishmentPostal = request.Establishment.Address.Postal,
                    ContactPersonSurname = request.ContactPerson.LastName,
                    ContactPersonFirstname = request.ContactPerson.FirstName,
                    ContactPhone = request.ContactPerson.PhoneNumber,
                    ContactEmail = request.ContactPerson.Email
                };
                export.Add(business);
            }

            return export;
        }

        private List<CsvAssociateExport> CreateBaseAssociatesExport(List<ApplicationScreeningRequest> requests)
        {
            List<CsvAssociateExport> export = new List<CsvAssociateExport>();

            foreach (ApplicationScreeningRequest ApplicationRequest in requests)
            {
                var associates = CreateAssociatesExport(ApplicationRequest.RecordIdentifier, ApplicationRequest.Associates);
                export.AddRange(associates);
            }
            return export;
        }

        private List<CsvAssociateExport> CreateAssociatesExport(string JobNumber, List<LegalEntity> associates)
        {
            List<CsvAssociateExport> export = new List<CsvAssociateExport>();
            foreach (var entity in associates)
            {
                if(entity.IsIndividual)
                {
                    var newAssociate = new CsvAssociateExport()
                    {
                        LCRBBusinessJobId = JobNumber,
                        Lcrbworkerjobid = entity.Contact.ContactId,
                        Legalfirstname = entity.Contact.FirstName,
                        Legalsurname = entity.Contact.LastName,
                        Legalmiddlename = entity.Contact.MiddleName,
                        Contactphone = entity.Contact.PhoneNumber,
                        Personalemailaddress = entity.Contact.Email,
                        Addressline1 = entity.Contact.Address.AddressStreet1,
                        Addresscity = entity.Contact.Address.City,
                        Addressprovstate = entity.Contact.Address.StateProvince,
                        Addresscountry = entity.Contact.Address.Country,
                        Addresspostalcode = entity.Contact.Address.Postal,
                        Selfdisclosure = ((GeneralYesNo)entity.Contact.SelfDisclosure).ToString(),
                        Gendermf = ((AdoxioGenderCode)entity.Contact.Gender).ToString(),
                        Driverslicence = entity.Contact.DriversLicenceNumber,
                        Bcidentificationcardnumber = entity.Contact.BCIdCardNumber,
                        Birthplacecity = entity.Contact.Birthplace,
                        Birthdate = entity.Contact.BirthDate
                    };

                    /* Flatten up the aliases */
                    var aliasId = 1;
                    foreach (var alias in entity.Aliases)
                    {
                        newAssociate[$"Alias{aliasId}surname"] = alias.Surname;
                        newAssociate[$"Alias{aliasId}middlename"] = alias.SecondName;
                        newAssociate[$"Alias{aliasId}firstname"] = alias.GivenName;
                        aliasId++;
                    }

                    /* Flatten up the previous addresses */
                    var addressId = 1;
                    foreach (var address in entity.PreviousAddresses)
                    {
                        newAssociate[$"Previousstreetaddress{addressId}"] = address.AddressStreet1;
                        newAssociate[$"Previouscity{addressId}"] = address.City;
                        newAssociate[$"Previousprovstate{addressId}"] = address.StateProvince;
                        newAssociate[$"Previouscountry{addressId}"] = address.Country;
                        newAssociate[$"Previouspostalcode{addressId}"] = address.Postal;
                        addressId++;
                    }
                    export.Add(newAssociate);
                }
                else
                {
                    export.AddRange(CreateAssociatesExport(JobNumber, entity.Account.Associates));
                }
            }
            return export;
        }

        /// <summary>
        /// Import responses to Dynamics.
        /// </summary>
        /// <returns></returns>
        private void ImportWorkerRequestsToDynamics(PerformContext hangfireContext, List<WorkerScreeningRequest> requests)
        {
            foreach (WorkerScreeningRequest workerRequest in requests)
            {
                // add data to dynamics.
                // create a Contact which will be bound to the customer id field.
                MicrosoftDynamicsCRMcontact contact = new MicrosoftDynamicsCRMcontact();

                contact.SpiceBcidcardnumber = workerRequest.BCIdCardNumber;
                contact.SpiceDriverslicensenumber = int.Parse ( workerRequest.DriversLicence );
                contact.Externaluseridentifier = workerRequest.RecordIdentifier;
                contact.Gendercode = (int?) workerRequest.Gender;
                    
                MicrosoftDynamicsCRMincident incident = new MicrosoftDynamicsCRMincident();

                incident.SpiceApplicanttype = 525840001; // Cannabis  

                incident.SpiceCannabisapplicanttype = 525840002; // Worker
                incident.SpiceReasonforscreening = 525840001; // new check

                // Screenings are Incidents in Dynamics.
                _dynamics.Incidents.Create(incident);
                                
            }
        }

        /// <summary>
        /// Import responses to Dynamics.
        /// </summary>
        /// <returns></returns>
        public void ImportWorkerRequestsToSMTP(PerformContext hangfireContext, List<WorkerScreeningRequest> requests)
        {

            List<CsvWorkerExport> export = new List<CsvWorkerExport>();

            foreach (WorkerScreeningRequest workerRequest in requests)
            {
                CsvWorkerExport csvWorkerExport = new CsvWorkerExport()
                {
                    Lcrbworkerjobid = workerRequest.RecordIdentifier,
                    

                    Birthdate = workerRequest.BirthDate,
                    
                    Birthplacecity = workerRequest.Birthplace,
                    Driverslicence = workerRequest.DriversLicence,
                    Bcidentificationcardnumber = workerRequest.BCIdCardNumber,
                    
                    
                };
                //Selfdisclosure = workerRequest.SelfDisclosure,
                //Gendermf = workerRequest.Gender,

                if (workerRequest.Contact != null)
                {
                    csvWorkerExport.Legalsurname = workerRequest.Contact.LastName;
                    csvWorkerExport.Legalfirstname = workerRequest.Contact.FirstName;
                    csvWorkerExport.Legalmiddlename = workerRequest.Contact.MiddleName;
                    csvWorkerExport.Contactphone = workerRequest.Contact.PhoneNumber;
                    csvWorkerExport.Personalemailaddress = workerRequest.Contact.Email;
                }

                if (workerRequest.Address != null)
                {
                    csvWorkerExport.Addressline1 = workerRequest.Address.AddressStreet1;
                    csvWorkerExport.Addresscity = workerRequest.Address.City;
                    csvWorkerExport.Addressprovstate = workerRequest.Address.StateProvince;
                    csvWorkerExport.Addresscountry = workerRequest.Address.Country;
                    csvWorkerExport.Addresspostalcode = workerRequest.Address.Postal;
                }

                export.Add(csvWorkerExport);
            }

            string attachmentName = "Worker_ScreeningRequest.csv";
            string csvData = CreateWorkerCSV(export);
            bool sentEmail = SendSPDEmail(csvData, attachmentName);

            if (sentEmail)
            {
                _logger.LogError($"Sent email to {Configuration["SPD_EXPORT_EMAIL"]}.");
            }
            else
            {
                _logger.LogError($"Unable to send email to {Configuration["SPD_EXPORT_EMAIL"]}.");
            }
        }

        private string CreateWorkerCSV(List<CsvWorkerExport> workers)
        {

            // convert the list to a CSV document.
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            using (var csv = new CsvWriter(sw))
            {
                csv.WriteRecords(workers);
            }

            sw.Flush();
            sw.Close();
            string csvData = sb.ToString();

            return csvData;
        }

        private string CreateAssociateCSV(List<CsvAssociateExport> associates)
        {
            // convert the list to a CSV document.
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            using (var csv = new CsvWriter(sw))
            {
                csv.WriteRecords(associates);
            }

            sw.Flush();
            sw.Close();
            string csvData = sb.ToString();

            return csvData;
        }

        private string CreateBusinessCSV(List<CsvBusinessExport> businesses)
        {
            // convert the list to a CSV document.
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            using (var csv = new CsvWriter(sw))
            {
                csv.WriteRecords(businesses);
            }

            sw.Flush();
            sw.Close();
            string csvData = sb.ToString();

            return csvData;
        }

        private bool SendSPDEmail(string attachmentContent, string attachmentName)
        {
            var emailSentSuccessfully = false;
            var datePart = DateTime.Now.ToString().Replace('/', '-').Replace(':', '_');
            var email = Configuration["SPD_EXPORT_EMAIL"];
            string body = $@"";

            using (var stream = new MemoryStream())
            using (var writer = new StreamWriter(stream))    // using UTF-8 encoding by default
            using (var mailClient = new SmtpClient(Configuration["SMTP_HOST"]))
            using (var message = new MailMessage("no-reply@gov.bc.ca", email))
            {
                writer.WriteLine(attachmentContent);
                writer.Flush();
                stream.Position = 0;     // read from the start of what was written

                message.Subject = $"{attachmentName}";
                message.Body = body;
                message.IsBodyHtml = true;

                message.Attachments.Add(new Attachment(stream, attachmentName, "text/csv"));

                try
                {
                    mailClient.Send(message);
                    emailSentSuccessfully = true;
                }
                catch (Exception)
                {
                    emailSentSuccessfully = false;
                }

            }
            return emailSentSuccessfully;
        }

        /// <summary>
        /// Hangfire job to receive an import from SPICE.
        /// </summary>
        public void SendResultsJob(PerformContext hangfireContext)
        {
            hangfireContext.WriteLine("Starting SPICE Application Send Results Job.");
            _logger.LogError("Starting SPICE Send Results Job.");

            // TODO - send results.

            hangfireContext.WriteLine("Done.");
            _logger.LogError("Done.");
        }
    }
}
