﻿using Infrastructure.Models;
using Module.Core.Models;

namespace Module.Orders.Models
{
    public class OrderAddress : EntityBase
    {
        public string ContactName { get; set; }

        public string Phone { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public long DistrictId { get; set; }

        public District District { get; set; }

        public long StateOrProvinceId { get; set; }

        public StateOrProvince StateOrProvince { get; set; }

        public long CountryId { get; set; }

        public Country Country { get; set; }
    }
}
