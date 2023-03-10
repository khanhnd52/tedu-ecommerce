using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace TeduEcommerce.Products;

public class Product : AuditedAggregateRoot<Guid>
{
    public Guid ManufactureId { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string Slug { get; set; }
    public ProductType ProductType { get; set; }
    public string SKU { get; set; }
    public int SortOrder { get; set; }
    public bool Visibility { get; set; }
    public bool IsActive { get; set; }
    public Guid CategoryId { get; set; }
    public string SeoMetaDescription { get; set; }
    public string MyProperty { get; set; }
    public string Description { get; set; }
    public string ThumbnailPicture { get; set; }
}