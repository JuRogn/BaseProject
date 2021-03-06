﻿using Module.Core.Models;

namespace Module.Vendors.Services
{
    public interface IVendorService
    {
        void Create(Vendor brand);

        void Update(Vendor brand);

        void Delete(long id);

        void Delete(Vendor brand);
    }
}
