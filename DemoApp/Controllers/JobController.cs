using DemoApp.Data;
using DemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class JobController : Controller
    {
        private MyDBContext _dbContext;
        public JobController()
        {
            _dbContext = new MyDBContext();
        }
        // GET: Job
        public ActionResult Index()
        {
            return View(GetJobs());
        }

        public ActionResult JobForm(int Id=0)
        {
            if (Id == 0)
            {
                var job = new Job();
                return View(job);
            }
            else
            {
                var job = _dbContext.Jobs.SingleOrDefault(c => c.Id == Id);
                if (job != null)
                                    return View(job);
                else return View();
            }
        }

        [ValidateAntiForgeryToken]
        public ActionResult Save(Job job)
        {
            if (!ModelState.IsValid)
            {
                return View("JobForm",job);
            }
            else
            {
                if (job.Id == 0)
                {
                    _dbContext.Jobs.Add(job);
                }
                else
                {
                    var JobinDB = _dbContext.Jobs.Single(c => c.Id==job.Id);
                    JobinDB.JobTitle = job.JobTitle;
                    JobinDB.JobDescription = job.JobDescription;
                    JobinDB.JobCreateAt = job.JobCreateAt;
                    JobinDB.JobExpiresAt = job.JobExpiresAt;
                    TryUpdateModel(JobinDB);
                }
                _dbContext.SaveChanges();
                return View("Index", GetJobs());
            }
          
        }


        private IEnumerable<Job> GetJobs()
        {
            return _dbContext.Jobs.ToList();
        }
    }
}