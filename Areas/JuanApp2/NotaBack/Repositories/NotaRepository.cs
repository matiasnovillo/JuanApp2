using Microsoft.EntityFrameworkCore;
using JuanApp2.Areas.JuanApp2.NotaBack.Entities;
using JuanApp2.Areas.JuanApp2.NotaBack.Interfaces;
using JuanApp2.DatabaseContexts;
using System.Data;

/*
 * GUID:e6c09dfe-3a3e-461b-b3f9-734aee05fc7b
 * 
 * Coded by fiyistack.com
 * Copyright © 2024
 * 
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 * 
 */

namespace JuanApp2.Areas.JuanApp2.NotaBack.Repositories
{
    public class NotaRepository : INotaRepository
    {
        protected readonly JuanApp2Context _context;

        public NotaRepository(JuanApp2Context context)
        {
            _context = context;
        }

        public IQueryable<Nota> AsQueryable()
        {
            try
            {
                return _context.Nota.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Nota.Count();
            }
            catch (Exception) { throw; }
        }

        public Nota? GetByNotaId(int notaId)
        {
            try
            {
                return _context.Nota
                            .FirstOrDefault(x => x.NotaId == notaId);
            }
            catch (Exception) { throw; }
        }

        public Nota? GetNota1()
        {
            try
            {
                return _context.Nota
                            .FirstOrDefault(x => x.NotaId == 1);
            }
            catch (Exception) { throw; }
        }

        public Nota? GetNota2()
        {
            try
            {
                return _context.Nota
                            .FirstOrDefault(x => x.NotaId == 2);
            }
            catch (Exception) { throw; }
        }

        public Nota? GetNota3()
        {
            try
            {
                return _context.Nota
                            .FirstOrDefault(x => x.NotaId == 3);
            }
            catch (Exception) { throw; }
        }

        public Nota? GetNota4()
        {
            try
            {
                return _context.Nota
                            .FirstOrDefault(x => x.NotaId == 4);
            }
            catch (Exception) { throw; }
        }

        public List<Nota?> GetAll()
        {
            try
            {
                return _context.Nota.ToList();
            }
            catch (Exception) { throw; }
        }

        public List<Nota> GetAllByNotaIdForModal(string textToSearch)
        {
            try
            {
                var query = from nota in _context.Nota
                            select new { Nota = nota};

                // Extraemos los resultados en listas separadas
                List<Nota> lstNota = query.Select(result => result.Nota)
                        .Where(x => x.NotaId.ToString().Contains(textToSearch))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .ToList();

                return lstNota;
            }
            catch (Exception) { throw; }
        }

        public List<Nota?> GetAllByNotaId(List<int> lstNotaChecked)
        {
            try
            {
                List<Nota?> lstNota = [];

                foreach (int NotaId in lstNotaChecked)
                {
                    Nota nota = _context.Nota.Where(x => x.NotaId == NotaId).FirstOrDefault();

                    if (nota != null)
                    {
                        lstNota.Add(nota);
                    }
                }

                return lstNota;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public bool Add(Nota nota)
        {
            try
            {
                _context.Nota.Add(nota);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool Update(Nota nota)
        {
            try
            {
                _context.Nota.Update(nota);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool UpdateNota1(Nota nota)
        {
            try
            {
                _context.Nota.Update(nota);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool UpdateNota2(Nota nota)
        {
            try
            {
                _context.Nota.Update(nota);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool UpdateNota3(Nota nota)
        {
            try
            {
                _context.Nota.Update(nota);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool UpdateNota4(Nota nota)
        {
            try
            {
                _context.Nota.Update(nota);
                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }

        public bool DeleteByNotaId(int notaId)
        {
            try
            {
                AsQueryable()
                        .Where(x => x.NotaId == notaId)
                        .ExecuteDelete();

                return _context.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Methods for DataTable
        public DataTable GetAllByNotaIdInDataTable(List<int> lstNotaChecked)
        {
            try
            {
                DataTable DataTable = new();
                DataTable.Columns.Add("NotaId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Nota1", typeof(string));
                DataTable.Columns.Add("Nota2", typeof(string));
                DataTable.Columns.Add("Nota3", typeof(string));
                DataTable.Columns.Add("Nota4", typeof(string));
                

                foreach (int NotaId in lstNotaChecked)
                {
                    Nota nota = _context.Nota.Where(x => x.NotaId == NotaId).FirstOrDefault();

                    if (nota != null)
                    {
                        DataTable.Rows.Add(
                        nota.NotaId,
                        nota.Active,
                        nota.DateTimeCreation,
                        nota.DateTimeLastModification,
                        nota.UserCreationId,
                        nota.UserLastModificationId,
                        nota.Nota1,
                        nota.Nota2,
                        nota.Nota3,
                        nota.Nota4
                        
                        );
                    }
                }                

                return DataTable;
            }
            catch (Exception) { throw; }
        }

        public DataTable GetAllInDataTable()
        {
            try
            {
                List<Nota> lstNota = _context.Nota.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("NotaId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Nota1", typeof(string));
                DataTable.Columns.Add("Nota2", typeof(string));
                DataTable.Columns.Add("Nota3", typeof(string));
                DataTable.Columns.Add("Nota4", typeof(string));
                

                foreach (Nota nota in lstNota)
                {
                    DataTable.Rows.Add(
                        nota.NotaId,
                        nota.Active,
                        nota.DateTimeCreation,
                        nota.DateTimeLastModification,
                        nota.UserCreationId,
                        nota.UserLastModificationId,
                        nota.Nota1,
                        nota.Nota2,
                        nota.Nota3,
                        nota.Nota4
                        
                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
