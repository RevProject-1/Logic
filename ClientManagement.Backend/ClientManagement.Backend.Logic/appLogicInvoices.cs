using ClientManagement.Backend.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic
{
   public partial class appLogic
   {
      public Invoice generateInvoice(jobDTO job)
      {
         Invoice invoice = new Invoice();
         invoice.expenses = new List<InvoiceExpenses>();
         invoice.BusinessName = job.user.Name;
         invoice.BusinessPhoneNumber = job.user.PhoneNumber;
         invoice.ClientName = job.client.Name;
         invoice.ClientNumber = job.client.PhoneNumber;
         invoice.ClientStreet = job.client.Address.Street;
         invoice.ClientCity = job.client.Address.City;
         invoice.ClientState = job.client.Address.State;
         invoice.ZipCode = job.client.Address.Zip;
         invoice.ServiceType = job.type.Name;
         invoice.StartDate = job.StartDate.GetValueOrDefault().ToString();
         invoice.EndDate = job.StartDate.GetValueOrDefault().AddDays(job.EstimatedDuration.GetValueOrDefault()).ToString();
         invoice.HourlyRate = job.type.Rate.GetValueOrDefault().ToString();
         invoice.BilledHours = job.Hours.GetValueOrDefault().ToString();
         var jobexpenses = getJobExpenseByJobId(job);
         var expenses = new List<ExpenseDTO>();
         foreach (var item in jobexpenses)
         {
            var x = getExpenses().Where(m => m.Id == item.ExpenseId).FirstOrDefault();
            expenses.Add(x);
            InvoiceExpenses ie = new InvoiceExpenses();
            ie.Cost = x.Cost.ToString();
            ie.Name = x.Name;
            invoice.expenses.Add(ie);
         }
         var expensetotal = 0.00m;
         foreach (var item in expenses)
         {
            expensetotal += item.Cost;
         }
         var subtotal = (job.type.Rate * job.Hours) + expensetotal;
         invoice.totalExpenses = expensetotal.ToString();
         invoice.subTotal = subtotal.ToString();
         invoice.Notes = job.Notes;
         return invoice;
      }
   }
}
