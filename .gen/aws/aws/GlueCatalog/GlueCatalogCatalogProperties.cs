using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalog
{
    [JsiiByValue(fqn: "aws.glueCatalog.GlueCatalogCatalogProperties")]
    public class GlueCatalogCatalogProperties : aws.GlueCatalog.IGlueCatalogCatalogProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#custom_properties GlueCatalog#custom_properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? CustomProperties
        {
            get;
            set;
        }

        private object? _dataLakeAccessProperties;

        /// <summary>data_lake_access_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#data_lake_access_properties GlueCatalog#data_lake_access_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataLakeAccessProperties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalog.GlueCatalogCatalogPropertiesDataLakeAccessProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataLakeAccessProperties
        {
            get => _dataLakeAccessProperties;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.GlueCatalog.IGlueCatalogCatalogPropertiesDataLakeAccessProperties[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.GlueCatalog.IGlueCatalogCatalogPropertiesDataLakeAccessProperties).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataLakeAccessProperties = value;
            }
        }

        private object? _icebergOptimizationProperties;

        /// <summary>iceberg_optimization_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#iceberg_optimization_properties GlueCatalog#iceberg_optimization_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "icebergOptimizationProperties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalog.GlueCatalogCatalogPropertiesIcebergOptimizationProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IcebergOptimizationProperties
        {
            get => _icebergOptimizationProperties;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.GlueCatalog.IGlueCatalogCatalogPropertiesIcebergOptimizationProperties[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.GlueCatalog.IGlueCatalogCatalogPropertiesIcebergOptimizationProperties).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _icebergOptimizationProperties = value;
            }
        }
    }
}
