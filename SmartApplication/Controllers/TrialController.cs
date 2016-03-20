using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using SmartModel.ViewModel;
using System.Linq;
using SmartBusinessLogic.Services;
using SmartModel.Entities;
using System.Collections.Generic;

namespace SmartApplication.Controllers
{
    public class TrialController : Controller
    {
        private readonly ITrialService _trialService;
        public TrialController(ITrialService trialServices)
        {
            _trialService = trialServices;
        }
       
        // GET: Trial
        public async Task<ActionResult> Index()
        {
            var trialList = await _trialService.Get();
            var trialListModel = trialList.Select(x => x.ToModel());
            return View(trialListModel);
        }

        // GET: Trial/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var  trial = await _trialService.GetById(id);

            if (trial == null)
            {
                return HttpNotFound();
            }
            var trialModel = trial.ToModel();
               
            return View(trialModel);
        }

        // GET: Trial/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trial/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Status,StartDate,EndDate,StudyType,InterventionType,Phase")] TrialModel trial)
        {
            if (ModelState.IsValid)
            {
                var entity = trial.ToEntity();
               _trialService.New(entity);
              
                return RedirectToAction("Index");
            }

            return View(trial);
        }

        // GET: Trial/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trial trial = await _trialService.GetById(id);
            if (trial == null)
            {
                return HttpNotFound();
            }
            var trialModel = trial.ToModel();
            return View(trialModel);
        }

        // POST: Trial/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(TrialModel trial)
        {
            if (ModelState.IsValid)
            {
                var entity = trial.ToEntity();
                 _trialService.Update(entity);
                return  RedirectToAction("Index");
            }
            return View(trial);
        }

        // GET: Trial/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var trial = await _trialService.GetById(id);
            
            if (trial == null)
            {
                return HttpNotFound();
            }
            var trialModel = trial.ToModel();
            return View(trialModel);
        }

        // POST: Trial/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Trial trial = await _trialService.GetById(id);
            _trialService.Delete(trial);
           return RedirectToAction("Index");
        }

       
    }
}
