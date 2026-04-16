using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrder), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrder")]
    public interface IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrder
    {
        /// <summary>fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#fields GlueCatalogTable#fields}
        /// </remarks>
        [JsiiProperty(name: "fields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields\"},\"kind\":\"array\"}}]}}")]
        object Fields
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#order_id GlueCatalogTable#order_id}.</summary>
        [JsiiProperty(name: "orderId", typeJson: "{\"primitive\":\"number\"}")]
        double OrderId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrder), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrder")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrder
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#fields GlueCatalogTable#fields}
            /// </remarks>
            [JsiiProperty(name: "fields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields\"},\"kind\":\"array\"}}]}}")]
            public object Fields
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#order_id GlueCatalogTable#order_id}.</summary>
            [JsiiProperty(name: "orderId", typeJson: "{\"primitive\":\"number\"}")]
            public double OrderId
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
