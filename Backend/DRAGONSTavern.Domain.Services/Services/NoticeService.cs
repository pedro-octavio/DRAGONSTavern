using DRAGONSTavern.Domain.Core.Interfaces.Repositories;
using DRAGONSTavern.Domain.Core.Interfaces.Services;
using DRAGONSTavern.Domain.Entities;
using DRAGONSTavern.Domain.Helpers.Validator;

namespace DRAGONSTavern.Domain.Services.Services
{
    public class NoticeService : BaseService<Notice>, INoticeService
    {
        public NoticeService(INoticeRepository noticeRepository, Validator<Notice> validator) : base(noticeRepository, validator) { }
    }
}
