// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace NorthWeird.AutoGen.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Product
    {
        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product(string productName = default(string), int? productId = default(int?), int? categoryId = default(int?), int? supplierId = default(int?), string quantityPerUnit = default(string), double? unitPrice = default(double?), int? unitsInStock = default(int?), int? unitsOnOrder = default(int?), int? reorderLevel = default(int?), bool? discontinued = default(bool?), Category category = default(Category), Supplier supplier = default(Supplier))
        {
            ProductName = productName;
            ProductId = productId;
            CategoryId = categoryId;
            SupplierId = supplierId;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            UnitsOnOrder = unitsOnOrder;
            ReorderLevel = reorderLevel;
            Discontinued = discontinued;
            Category = category;
            Supplier = supplier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productName")]
        public string ProductName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productId")]
        public int? ProductId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "categoryId")]
        public int? CategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supplierId")]
        public int? SupplierId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantityPerUnit")]
        public string QuantityPerUnit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unitPrice")]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unitsInStock")]
        public int? UnitsInStock { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unitsOnOrder")]
        public int? UnitsOnOrder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reorderLevel")]
        public int? ReorderLevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discontinued")]
        public bool? Discontinued { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public Category Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supplier")]
        public Supplier Supplier { get; set; }

    }
}