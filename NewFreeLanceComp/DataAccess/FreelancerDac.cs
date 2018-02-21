using NewFreeLanceComp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace NewFreeLanceComp.DataAccess
{
    public sealed class FreelancerDac
    {
        private string _path = "~/App_Data/Job.JSON";

        /// <summary>
        /// Get Job Data
        /// </summary>
        /// <returns></returns>
        public List<Freelancer> Get()
        {
            // Variable Defination
            var serializer = new JavaScriptSerializer();

            //Read the content of the JSON DB
            var fileContents = System.IO.File.ReadAllText(_path);
            //Serialize the JSON value            
            var deserializedResult = serializer.Deserialize<List<Freelancer>>(fileContents);

            return deserializedResult;
        }

        /// <summary>
        /// Write data tyo Job JSON file
        /// </summary>
        /// <param name="jobs"></param>
        public void Insert(List<Freelancer> jobs)
        {
            // Create a Serializer Object
            var serializer = new JavaScriptSerializer();
            //Serialize the list content
            var serializedResult = serializer.Serialize(jobs);

            try
            {
                //Save the result
                System.IO.File.WriteAllText(_path, serializedResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}