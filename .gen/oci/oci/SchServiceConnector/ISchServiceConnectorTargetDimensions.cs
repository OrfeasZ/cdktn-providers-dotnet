using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiInterface(nativeType: typeof(ISchServiceConnectorTargetDimensions), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorTargetDimensions")]
    public interface ISchServiceConnectorTargetDimensions
    {
        /// <summary>dimension_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#dimension_value SchServiceConnector#dimension_value}
        /// </remarks>
        [JsiiProperty(name: "dimensionValue", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorTargetDimensionsDimensionValue\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.SchServiceConnector.ISchServiceConnectorTargetDimensionsDimensionValue? DimensionValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#name SchServiceConnector#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISchServiceConnectorTargetDimensions), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorTargetDimensions")]
        internal sealed class _Proxy : DeputyBase, oci.SchServiceConnector.ISchServiceConnectorTargetDimensions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dimension_value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#dimension_value SchServiceConnector#dimension_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimensionValue", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorTargetDimensionsDimensionValue\"}", isOptional: true)]
            public oci.SchServiceConnector.ISchServiceConnectorTargetDimensionsDimensionValue? DimensionValue
            {
                get => GetInstanceProperty<oci.SchServiceConnector.ISchServiceConnectorTargetDimensionsDimensionValue?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#name SchServiceConnector#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
