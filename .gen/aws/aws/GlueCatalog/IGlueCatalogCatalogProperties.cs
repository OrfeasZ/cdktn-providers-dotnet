using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalog
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogCatalogProperties), fullyQualifiedName: "aws.glueCatalog.GlueCatalogCatalogProperties")]
    public interface IGlueCatalogCatalogProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_catalog#custom_properties GlueCatalog#custom_properties}.</summary>
        [JsiiProperty(name: "customProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? CustomProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_lake_access_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_catalog#data_lake_access_properties GlueCatalog#data_lake_access_properties}
        /// </remarks>
        [JsiiProperty(name: "dataLakeAccessProperties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalog.GlueCatalogCatalogPropertiesDataLakeAccessProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataLakeAccessProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>iceberg_optimization_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_catalog#iceberg_optimization_properties GlueCatalog#iceberg_optimization_properties}
        /// </remarks>
        [JsiiProperty(name: "icebergOptimizationProperties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalog.GlueCatalogCatalogPropertiesIcebergOptimizationProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IcebergOptimizationProperties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogCatalogProperties), fullyQualifiedName: "aws.glueCatalog.GlueCatalogCatalogProperties")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalog.IGlueCatalogCatalogProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_catalog#custom_properties GlueCatalog#custom_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? CustomProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>data_lake_access_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_catalog#data_lake_access_properties GlueCatalog#data_lake_access_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataLakeAccessProperties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalog.GlueCatalogCatalogPropertiesDataLakeAccessProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataLakeAccessProperties
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>iceberg_optimization_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_catalog#iceberg_optimization_properties GlueCatalog#iceberg_optimization_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "icebergOptimizationProperties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalog.GlueCatalogCatalogPropertiesIcebergOptimizationProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IcebergOptimizationProperties
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
