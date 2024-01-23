using System;
using System.Collections.Generic;

namespace DemoSession4_ASPNET_CORE_MVC.Models;

public partial class InvoiceDetail
{
    public int InvoiceId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }
}
