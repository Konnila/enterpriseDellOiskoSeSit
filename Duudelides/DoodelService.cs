using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Duudelides.Repositories;

namespace Duudelides
{
    public class DoodelService
    {
        private DoodelRepository doodelRepository;

        public DoodelService()
        {
            doodelRepository = new DoodelRepository();
        }

        public virtual void CreateDoodel(DoodelCreateModel model)
        {
            var doodel = new Doodel
            {
                BeginTime = Convert.ToDateTime(model.Beginning),
                EndTime = Convert.ToDateTime(model.Ending),
                Title = model.Title
            };

            doodelRepository.CreateDoodel(doodel);
        }
    }
}