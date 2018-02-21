using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace NewFreeLanceComp.Models
{
    public sealed class Job
    {
        /// <summary>
        /// unique identifier of the job
        /// </summary>
        public int JobId { get; set; }

        /// <summary>
        /// Unique identifier of the job type table
        /// </summary>
        public int JobCategoryIdFk { get; set; }

        /// <summary>
        /// 10-100 character cover of job/ short descrition
        /// </summary>
        public string JobBriefDescription { get; set; }

        /// <summary>
        /// 10000 characters complete job description
        /// </summary>
        public string JobDescription { get; set; }

        /// <summary>
        /// true  - user wants suggestion on Freelancer
        /// false - user need not be bothered with suggestion
        /// </summary>
        public bool IsFreelanceSuggestionRequested { get; set; }

        /// <summary>
        /// Freelnacer's id who will be assigned this job
        /// </summary>
        public int? HiredFreelancerUserID { get; set; }

        /// <summary>
        /// List of keyword ids
        /// this can be used to match keywords of Freelancer and give suggestion to customer
        /// </summary>
        public List<int> JobKeyWordIDs { get; set; }

        /// <summary>
        /// When entering a job, if customer wants to select
        /// specific location's freelnacer can only apply.
        /// This can be required by cutomer to make sure he and 
        /// freelancer work on some overlaping Timezones or in his timezone
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Budjet of the job
        /// </summary>
        public JobBudget Budget { get; set; }

        public DateTime JobApplicationDeadline { get; set; }
        // Files will need to be added
    }
}
