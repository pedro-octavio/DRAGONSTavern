using DRAGONSTavern.Domain.Core.Interfaces.Repositories;
using DRAGONSTavern.Domain.Entities;
using DRAGONSTavern.Infra.Data.Repositories;

namespace DRAGONSTavern.Infra.Data
{
    public class NoticeRepository : BaseRepository<Notice>, INoticeRepository
    {
        public NoticeRepository(DataContext dataContext) : base(dataContext) { }
    }
}
