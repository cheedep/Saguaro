using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using Saguaro.Domain.Abstract;
using Saguaro.Domain.Concrete;
using Saguaro.Domain.Models;

namespace Saguaro.Web.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            //return base.GetControllerInstance(requestContext, controllerType);

            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            //var mock = new Mock<IArticleRepository>();
            //mock.Setup(m => m.Articles).Returns((new List<Article>
            //                                        {
            //                                            new Article() 
            //                                            { 
            //                                                Id = 1, 
            //                                                AuthorId = 1, 
            //                                                Title = "Article 1", 
            //                                                Description = "Description 1", 
            //                                                Text = "Text 1"
            //                                            },
            //                                            new Article() 
            //                                            { 
            //                                                Id = 2, 
            //                                                AuthorId = 1, 
            //                                                Title = "Article 2", 
            //                                                Description = "Description 2", 
            //                                                Text = "Text 2"
            //                                            },
            //                                        }).AsQueryable());
            //ninjectKernel.Bind<IArticleRepository>().ToConstant(mock.Object);

            ninjectKernel.Bind<IArticleRepository>().To<EfArticleRepository>();

        }
    }
}