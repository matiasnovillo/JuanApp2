using JuanApp2.Areas.System.FailureBack.Entities;

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

namespace JuanApp2.Areas.System.FailureBack.Interfaces
{
    public interface IFailureRepository
    {
        IQueryable<Failure> AsQueryable();

        #region Queries
        int Count();

        Failure? GetByFailureId(int testId);

        List<Failure?> GetAll();
        #endregion

        #region Non-Queries
        bool Add(Failure test);

        bool Update(Failure test);

        bool DeleteByFailureId(int testId);
        #endregion
    }
}
