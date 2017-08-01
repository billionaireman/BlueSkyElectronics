using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlueSkyElectronics.Models;

namespace BlueSkyElectronics.Controllers
{
    public class TFilingsController : Controller
    {
        private readonly BlueSkyElectronicsContext _context;

        public TFilingsController(BlueSkyElectronicsContext context)
        {
            _context = context;    
        }

        // GET: TFilings
        public async Task<IActionResult> Index()
        {
            var renewalfilings = from renewal in _context.TFiling
                                 where renewal.FilingId == 245394
                                 select renewal;

            return View(await renewalfilings.ToListAsync());
        }

        // GET: TFilings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tFiling = await _context.TFiling
                .SingleOrDefaultAsync(m => m.FilingId == id);
            if (tFiling == null)
            {
                return NotFound();
            }

            return View(tFiling);
        }

        // GET: TFilings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TFilings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FilingId,FilingNo,FilingTypeId,StateId,SecurityId,Prospectus,CheckId,PermitNo,StatusId,FiledDate,EffectiveDate,EffDateCode,ExpiryDate,RegisteredAmt,SoldAmt,FilingFee,EnvelopeId,Notes,Deleted,FilingCategoryCode,FeeBasicCode,FilingRuleId,Renewal,ChequeAmount,SalesFromDate,SalesToDate")] TFiling tFiling)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tFiling);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tFiling);
        }

        // GET: TFilings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tFiling = await _context.TFiling.SingleOrDefaultAsync(m => m.FilingId == id);
            if (tFiling == null)
            {
                return NotFound();
            }
            return View(tFiling);
        }

        // POST: TFilings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FilingId,FilingNo,FilingTypeId,StateId,SecurityId,Prospectus,CheckId,PermitNo,StatusId,FiledDate,EffectiveDate,EffDateCode,ExpiryDate,RegisteredAmt,SoldAmt,FilingFee,EnvelopeId,Notes,Deleted,FilingCategoryCode,FeeBasicCode,FilingRuleId,Renewal,ChequeAmount,SalesFromDate,SalesToDate")] TFiling tFiling)
        {
            if (id != tFiling.FilingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tFiling);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TFilingExists(tFiling.FilingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(tFiling);
        }

        // GET: TFilings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tFiling = await _context.TFiling
                .SingleOrDefaultAsync(m => m.FilingId == id);
            if (tFiling == null)
            {
                return NotFound();
            }

            return View(tFiling);
        }

        // POST: TFilings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tFiling = await _context.TFiling.SingleOrDefaultAsync(m => m.FilingId == id);
            _context.TFiling.Remove(tFiling);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool TFilingExists(int id)
        {
            return _context.TFiling.Any(e => e.FilingId == id);
        }
    }
}
