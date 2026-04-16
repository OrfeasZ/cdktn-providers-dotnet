using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec")]
    public interface IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec
    {
        /// <summary>fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#fields GlueCatalogTable#fields}
        /// </remarks>
        [JsiiProperty(name: "fields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields\"},\"kind\":\"array\"}}]}}")]
        object Fields
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#spec_id GlueCatalogTable#spec_id}.</summary>
        [JsiiProperty(name: "specId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SpecId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#fields GlueCatalogTable#fields}
            /// </remarks>
            [JsiiProperty(name: "fields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields\"},\"kind\":\"array\"}}]}}")]
            public object Fields
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#spec_id GlueCatalogTable#spec_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "specId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SpecId
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
