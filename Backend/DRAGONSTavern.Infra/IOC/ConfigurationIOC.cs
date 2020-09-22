using Autofac;
using DRAGONSTavern.Domain.Core.Interfaces.Repositories;
using DRAGONSTavern.Domain.Core.Interfaces.Services;
using DRAGONSTavern.Domain.Entities;
using DRAGONSTavern.Domain.Helpers.Validator;
using DRAGONSTavern.Domain.Services.Services;
using DRAGONSTavern.Domain.Validators;
using DRAGONSTavern.Domain.ValueObjects;
using DRAGONSTavern.Infra.Data;
using DRAGONSTavern.Infra.Data.Repositories;
using FluentValidation;

namespace DRAGONSTavern.Infra.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NoticeService>().As<INoticeService>();
            builder.RegisterType<UserService>().As<IUserService>();

            builder.RegisterType<NoticeRepository>().As<INoticeRepository>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<TokenService>().As<ITokenService>();

            builder.RegisterType<NoticeValidator>().As<IValidator<Notice>>();
            builder.RegisterType<SharedValidator>().As<IValidator<Shared>>();
            builder.RegisterType<UserValidator>().As<IValidator<User>>();

            builder.RegisterType<Validator<Notice>>();
            builder.RegisterType<Validator<Shared>>();
            builder.RegisterType<Validator<User>>();
        }
    }
}
