﻿namespace RealEstate_Dapper_UI.Dtos.ProductDtos
{
    public class ResultProductDto
    {

            public int productID { get; set; }
            public string title { get; set; }
            public decimal price { get; set; }
            public object city { get; set; }
            public string district { get; set; }
            public string categoryName { get; set; }
        

    }
}
