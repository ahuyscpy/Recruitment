using System;

namespace ViewModel.Catalog.Company
{
    public class GetCompanyBranchRequest
    {
        public string Keyword { get; set; }
        public Guid CompanyId { get; set; }
    }
}
