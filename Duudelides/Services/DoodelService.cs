using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Duudelides.Repositories;
using Duudelides.ViewModels;
using WebMatrix.WebData;

namespace Duudelides.Services
{
    public class DoodelService
    {
        private DoodelRepository doodelRepository;

        public DoodelService()
        {
            doodelRepository = new DoodelRepository();
        }

        public virtual void CreateDoodel(DoodelCreateModel model, int userId)
        {
            var doodel = new Doodel
            {
                BeginTime = Convert.ToDateTime(model.Beginning),
                EndTime = Convert.ToDateTime(model.Ending),
                Title = model.Title
            };

            doodelRepository.CreateDoodel(doodel, userId);
        }

        public virtual IEnumerable<Doodel> Get(Expression<Func<Doodel, bool>> where = null)
        {
            if (where == null)
                return doodelRepository.GetAllDoodels();

            return doodelRepository.Get(where);
        }


        public IEnumerable<UsersDoodle> GetUserDoodels()
        {
            return doodelRepository.GetUserDoodels();
        }
    }
}