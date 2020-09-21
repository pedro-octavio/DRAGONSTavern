using Autofac;
using DRAGONSTavern.Domain.Core.Interfaces.Repositories;
using DRAGONSTavern.Domain.Core.Interfaces.Services;
using DRAGONSTavern.Domain.Entities;
using DRAGONSTavern.Domain.Helpers.Validator;
using DRAGONSTavern.Domain.Services.Services;
using DRAGONSTavern.Domain.Validators;
using DRAGONSTavern.Domain.ValueObjects;
using DRAGONSTavern.Infra.Data;
using FluentValidation;

namespace DRAGONSTavern.Infra.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NoticeService>().As<INoticeService>();

            builder.RegisterType<NoticeRepository>().As<INoticeRepository>();

            builder.RegisterType<NoticeValidator>().As<IValidator<Notice>>();
            builder.RegisterType<SharedValidator>().As<IValidator<Shared>>();

            builder.RegisterType<Validator<Notice>>();
        }
    }
}
