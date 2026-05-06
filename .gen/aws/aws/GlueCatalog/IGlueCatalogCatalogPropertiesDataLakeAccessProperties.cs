using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalog
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogCatalogPropertiesDataLakeAccessProperties), fullyQualifiedName: "aws.glueCatalog.GlueCatalogCatalogPropertiesDataLakeAccessProperties")]
    public interface IGlueCatalogCatalogPropertiesDataLakeAccessProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#catalog_type GlueCatalog#catalog_type}.</summary>
        [JsiiProperty(name: "catalogType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CatalogType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#data_lake_access GlueCatalog#data_lake_access}.</summary>
        [JsiiProperty(name: "dataLakeAccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataLakeAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#data_transfer_role GlueCatalog#data_transfer_role}.</summary>
        [JsiiProperty(name: "dataTransferRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataTransferRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#kms_key GlueCatalog#kms_key}.</summary>
        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogCatalogPropertiesDataLakeAccessProperties), fullyQualifiedName: "aws.glueCatalog.GlueCatalogCatalogPropertiesDataLakeAccessProperties")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalog.IGlueCatalogCatalogPropertiesDataLakeAccessProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#catalog_type GlueCatalog#catalog_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CatalogType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#data_lake_access GlueCatalog#data_lake_access}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataLakeAccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DataLakeAccess
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#data_transfer_role GlueCatalog#data_transfer_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataTransferRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataTransferRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#kms_key GlueCatalog#kms_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
