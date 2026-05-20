using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalog
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTargetRedshiftCatalog), fullyQualifiedName: "aws.glueCatalog.GlueCatalogTargetRedshiftCatalog")]
    public interface IGlueCatalogTargetRedshiftCatalog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/glue_catalog#catalog_arn GlueCatalog#catalog_arn}.</summary>
        [JsiiProperty(name: "catalogArn", typeJson: "{\"primitive\":\"string\"}")]
        string CatalogArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTargetRedshiftCatalog), fullyQualifiedName: "aws.glueCatalog.GlueCatalogTargetRedshiftCatalog")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalog.IGlueCatalogTargetRedshiftCatalog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/glue_catalog#catalog_arn GlueCatalog#catalog_arn}.</summary>
            [JsiiProperty(name: "catalogArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CatalogArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
