using Microsoft.AspNetCore.Mvc;
using Xunit;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EShop.Models;
using EShop.Controllers;

namespace E_Shop.Tests {
    public class ProcessorControllerTests {
        [Fact]
        public void GetTest() {
            var mock = new Mock<GenericRepository<Processor>>();
            mock.Setup(repo => repo.GetAll()).Returns(GetTestProcessors());
            ProcessorsController controller = new ProcessorsController(mock.Object.context);

            ViewResult result = controller.Get() as ViewResult;

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IndexViewModel<Processor>>(viewResult.Model);
            Assert.Equal(5, model.Items.Count());
        }
        [Fact]
        public void GetByIdNotFoundTest() {
            var mock = new Mock<GenericRepository<Processor>>();
            var controller = new ProcessorsController(mock.Object.context);

            var result = controller.Get(20, true);

            var notFoundResult = Assert.IsType<NotFoundResult>(result);
        }
        [Fact]
        public void GetByIdBadRequestTest() {
            var mock = new Mock<GenericRepository<Processor>>();
            var controller = new ProcessorsController(mock.Object.context);

            var result = controller.Get(null, true);

            var notFoundResult = Assert.IsType<BadRequestResult>(result);
        }
        [Fact]
        public void GetByIdSuccessTest() {
            int testId = 6;
            var mock = new Mock<GenericRepository<Processor>>();
            mock.Setup(repo => repo.GetByID(testId)).Returns(GetTestProcessors().FirstOrDefault(p => p.Id == testId));
            var controller = new ProcessorsController(mock.Object.context);
            var processor = new Processor { Name = "AMD Ryzen 1200", Frequency = 3.5, TurboFrequency = 3.7, NumCores = 4, NumThreads = 4, Cache = 8, RAMSupport = "DDR4", TDP = 65, Lithography = 14, Price = 118.75, ImgURL = "/Images/amd-ryzen.jpg" };

            var result = controller.Get(6, true);

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<Processor>(viewResult.Model);
            Assert.Equal("~/Views/ItemPages/ProcessorPage.cshtml", viewResult.ViewName);
            Assert.Equal(processor.Name, model.Name);
            Assert.Equal(processor.Frequency, model.Frequency);
            Assert.Equal(processor.TurboFrequency, model.TurboFrequency);
            Assert.Equal(processor.NumCores, model.NumCores);
            Assert.Equal(processor.NumThreads, model.NumThreads);
            Assert.Equal(processor.Cache, model.Cache);
            Assert.Equal(processor.RAMSupport, model.RAMSupport);
            Assert.Equal(processor.TDP, model.TDP);
            Assert.Equal(processor.Lithography, model.Lithography);
            Assert.Equal(processor.Price, model.Price);
            Assert.Equal(processor.ImgURL, model.ImgURL);
        }



        private List<Processor> GetTestProcessors() {
            List<Processor> list = new List<Processor> {
                new Processor { Name = "Intel Core i3 2100", Frequency = 3.1, TurboFrequency = 3.1, NumCores = 2, NumThreads = 4, Cache = 3, RAMSupport = "DDR3", TDP = 65, Lithography = 32, Price = 116.12, ImgURL = "/Images/intel.jpg" },
                new Processor { Name = "AMD Ryzen 2600X", Frequency = 3.8, TurboFrequency = 4.2, NumCores = 6, NumThreads = 12, Cache = 12, RAMSupport = "DDR4", TDP = 95, Lithography = 14, Price = 202.55, ImgURL = "/Images/amd-ryzen.jpg" },
                new Processor { Name = "Intel Core i3 4170", Frequency = 3.7, TurboFrequency = 3.7, NumCores = 2, NumThreads = 4, Cache = 3, RAMSupport = "DDR3", TDP = 54, Lithography = 22, Price = 130.77, ImgURL = "/Images/intel.jpg" },
                new Processor { Name = "Intel Core i3 8350k", Frequency = 4.0, TurboFrequency = 4.0, NumCores = 4, NumThreads = 4, Cache = 8, RAMSupport = "DDR4", TDP = 91, Lithography = 14, Price = 187.91, ImgURL = "/Images/intel.jpg" },
                new Processor { Name = "Intel Core i5 4690k", Frequency = 3.5, TurboFrequency = 3.9, NumCores = 4, NumThreads = 4, Cache = 6, RAMSupport = "DDR3", TDP = 88, Lithography = 22, Price = 171.03, ImgURL = "/Images/intel.jpg" },
                new Processor { Name = "AMD Ryzen 1200", Frequency = 3.5, TurboFrequency = 3.7, NumCores = 4, NumThreads = 4, Cache = 8, RAMSupport = "DDR4", TDP = 65, Lithography = 14, Price = 118.75, ImgURL = "/Images/amd-ryzen.jpg" },
                new Processor { Name = "AMD Ryzen 1700", Frequency = 3.7, TurboFrequency = 3.9, NumCores = 8, NumThreads = 16, Cache = 16, RAMSupport = "DDR4", TDP = 65, Lithography = 14, Price = 227.83, ImgURL = "/Images/amd-ryzen.jpg" },
                new Processor { Name = "Intel Core i5 6400", Frequency = 2.7, TurboFrequency = 3.3, NumCores = 4, NumThreads = 4, Cache = 6, RAMSupport = "DDR3, DDR4", TDP = 65, Lithography = 14, Price = 194.69, ImgURL = "/Images/intel.jpg" },
                new Processor { Name = "Intel Core i5 8600", Frequency = 3.1, TurboFrequency = 4.3, NumCores = 6, NumThreads = 6, Cache = 9, RAMSupport = "DDR4", TDP = 65, Lithography = 14, Price = 232.43, ImgURL = "/Images/intel.jpg" },
                new Processor { Name = "AMD Ryzen 1200", Frequency = 3.5, TurboFrequency = 3.7, NumCores = 4, NumThreads = 4, Cache = 8, RAMSupport = "DDR4", TDP = 65, Lithography = 14, Price = 118.36, ImgURL = "/Images/amd-ryzen.jpg" },
                new Processor { Name = "Intel Core i7 3770k", Frequency = 3.5, TurboFrequency = 3.9, NumCores = 4, NumThreads = 8, Cache = 8, RAMSupport = "DDR3", TDP = 77, Lithography = 22, Price = 210.50, ImgURL = "/Images/intel.jpg" },
                new Processor { Name = "AMD Ryzen 2700X", Frequency = 3.9, TurboFrequency = 4.3, NumCores = 8, NumThreads = 16, Cache = 16, RAMSupport = "DDR4", TDP = 95, Lithography = 14, Price = 284.00, ImgURL = "/Images/amd-ryzen.jpg" },
                new Processor { Name = "Intel Core i7 7700k", Frequency = 3.8, TurboFrequency = 4.2, NumCores = 4, NumThreads = 4, Cache = 6, RAMSupport = "DDR3L, DDR4", TDP = 91, Lithography = 14, Price = 290.78, ImgURL = "/Images/intel.jpg" },
                new Processor { Name = "Intel Core i7 8700", Frequency = 3.2, TurboFrequency = 4.6, NumCores = 6, NumThreads = 12, Cache = 12, RAMSupport = "DDR4", TDP = 65, Lithography = 14, Price = 341.07, ImgURL = "/Images/intel.jpg" },
                new Processor { Name = "Intel Core i9 9900k", Frequency = 3.6, TurboFrequency = 5.0, NumCores = 8, NumThreads = 16, Cache = 16, RAMSupport = "DDR4", TDP = 95, Lithography = 14, Price = 575.95, ImgURL = "/Images/intel.jpg" },
                new Processor { Name = "AMD Ryzen 1500X", Frequency = 3.6, TurboFrequency = 4.0, NumCores = 4, NumThreads = 8, Cache = 16, RAMSupport = "DDR4", TDP = 95, Lithography = 14, Price = 153.76, ImgURL = "/Images/amd-ryzen.jpg" }
            };
            return list;
        }
    }
}
