using Barbearia.Data;
using Barbearia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barbearia.Controllers
{
    public class AgendamentosController : Controller
    {
        private readonly Contexto _context;

        public AgendamentosController(Contexto context)
        {
            _context = context;
        }
        [Authorize]
        // GET: Agendamentos
        public async Task<IActionResult> Index()
        {
              return _context.Agendamentos != null ? 
                          View(await _context.Agendamentos.ToListAsync()) :
                          Problem("Entity set 'Contexto.Agendamentos'  is null.");
        }

        // GET: Agendamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Agendamentos == null)
            {
                return NotFound();
            }

            var agendamentos = await _context.Agendamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agendamentos == null)
            {
                return NotFound();
            }

            return View(agendamentos);
        }

        // GET: Agendamentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Agendamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeCliente,Email,Telefone,DataAgendamento,Profissional")] Agendamentos agendamentos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agendamentos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agendamentos);
        }

        // GET: Agendamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Agendamentos == null)
            {
                return NotFound();
            }

            var agendamentos = await _context.Agendamentos.FindAsync(id);
            if (agendamentos == null)
            {
                return NotFound();
            }
            return View(agendamentos);
        }

        // POST: Agendamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeCliente,Email,Telefone,DataAgendamento,Profissional")] Agendamentos agendamentos)
        {
            if (id != agendamentos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agendamentos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgendamentosExists(agendamentos.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(agendamentos);
        }

        // GET: Agendamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Agendamentos == null)
            {
                return NotFound();
            }

            var agendamentos = await _context.Agendamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agendamentos == null)
            {
                return NotFound();
            }

            return View(agendamentos);
        }

        // POST: Agendamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Agendamentos == null)
            {
                return Problem("Entity set 'Contexto.Agendamentos'  is null.");
            }
            var agendamentos = await _context.Agendamentos.FindAsync(id);
            if (agendamentos != null)
            {
                _context.Agendamentos.Remove(agendamentos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgendamentosExists(int id)
        {
          return (_context.Agendamentos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
