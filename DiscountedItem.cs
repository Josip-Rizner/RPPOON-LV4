using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV4
{
    class DiscountedItem : RentableDecorator
    {
        private readonly double Discount = 0.5;
        public DiscountedItem(IRentable rentable) : base(rentable) { }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() * this.Discount;
        }
        public override String Description
        {
            get
            {
                return "Now at " + Discount * 100 + "% off! : " + base.Description;
            }
        }
    }
}
