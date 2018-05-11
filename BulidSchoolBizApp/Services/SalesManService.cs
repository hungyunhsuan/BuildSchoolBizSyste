using BizDataLibrary.Model;
using BizDataLibrary.Repositories;
using BulidSchoolBizApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulidSchoolBizApp.Services
{
  public  class SalesManService
    {
        public OpreationResult Create(SalesManViewModel input)
        {
            var result = new OpreationResult();
            try
            {
                BizModel context = new BizModel();
                BizRepository<SalesMan> repository = new BizRepository<SalesMan>(context);
                SalesMan entity = new SalesMan() { Name = input.Name };
                repository.Create(entity);
                context.SaveChanges();
                result.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                result.IsSuccessful = false;
                result.exception = ex;
            }
            return result;
        }

        public bool IsNameExist(SalesManViewModel input)
        {
            BizModel context = new BizModel();
            BizRepository<SalesMan> repository = new BizRepository<SalesMan>(context);
            return repository.GetAll().Any((x) => x.Name == input.Name);
        }

        public SalesManListViewModel GetSalesMen()
        {
            var result = new SalesManListViewModel();
            result.Items = new List<SalesManViewModel>();
            BizModel context = new BizModel();
            var repository = new BizRepository<SalesMan>(context);
            foreach (var item in repository.GetAll().OrderBy((x) => x.JobNumber))
            {
                var p = new SalesManViewModel()
                {
                    JobNumber = item.JobNumber,
                    Name = item.Name

                };
                result.Items.Add(p);
            }
            return result;
        }
    }
}
