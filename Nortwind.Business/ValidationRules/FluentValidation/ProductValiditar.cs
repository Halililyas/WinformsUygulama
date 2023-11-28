using FluentValidation;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Business.ValidationRules.FluentValidation
{
    public class ProductValiditar:AbstractValidator<Product> // Ben Ürünler İçin Kurallar Yapıcam 
    {
       public ProductValiditar() // constructor metod ctor yazınca iki tab yap çıkar 
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün İsmi Boş Bırakılamaz.. ");      // Product name Boş Geçilemez 
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Ürün Catogory ID  Boş Bırakılamaz.. ");   // CAtegoryId boş Geçilemz DEmiş olduk 
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("Ürün Sınıfı Boş Bırakılamaz.. ");// QuantityPerUnit boş Geçilemz DEmiş olduk 
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Ürün Stock Boş Bırakılamaz.. ");  // UnitsInStock boş Geçilemz DEmiş olduk 
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Ürün Fiyatı Boş Bırakılamaz.. ");    // UnitPrice boş Geçilemz DEmiş olduk 

            RuleFor(p => p.UnitPrice).GreaterThan(0); // UnitPrice 0 Dan büyük olmalı
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0); //    
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);

            RuleFor(p => p.ProductName).Must(BaslangıcA).WithMessage("Ürün Adı Mecbur A ile başlamalı ");

        }

        private bool BaslangıcA(string arg) // Return kullanılması zorunludur 
        {
            return arg.StartsWith("A");
        }
    }
}
