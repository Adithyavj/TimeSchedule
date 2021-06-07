using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class InterviewCallProcessor
    {
        // Create Data
        public void SaveInventoryRecord(InterviewCall interview)
        {
            SqlDataAccess.ManipulateData("dbo.spInterviewCall_Insert", interview);
        }

        // Update Data
        public void UpdateInventoryRecord(InterviewCall interview)
        {
            SqlDataAccess.ManipulateData("dbo.spInterviewCall_Update", interview);
        }

        // Delete Data
        public void DeleteInventoryRecord(InterviewCall interview)
        {
            SqlDataAccess.ManipulateData("dbo.spInterviewCall_Delete", interview);
        }

        // Read Data
        // Get all products
        public List<InterviewCall> GetProducts()
        {
            var output = SqlDataAccess.LoadData<InterviewCall, dynamic>("dbo.spInterviewCall_GetAll", new { });

            return output;
        }
    }
}
