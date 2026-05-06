using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsCapacityReport
{
    [JsiiInterface(nativeType: typeof(IBdsBdsCapacityReportShapeAvailabilities), fullyQualifiedName: "oci.bdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilities")]
    public interface IBdsBdsCapacityReportShapeAvailabilities
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_capacity_report#shape BdsBdsCapacityReport#shape}.</summary>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        string Shape
        {
            get;
        }

        /// <summary>shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_capacity_report#shape_config BdsBdsCapacityReport#shape_config}
        /// </remarks>
        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.bdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilitiesShapeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BdsBdsCapacityReport.IBdsBdsCapacityReportShapeAvailabilitiesShapeConfig? ShapeConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsCapacityReportShapeAvailabilities), fullyQualifiedName: "oci.bdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilities")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsCapacityReport.IBdsBdsCapacityReportShapeAvailabilities
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_capacity_report#shape BdsBdsCapacityReport#shape}.</summary>
            [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
            public string Shape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>shape_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_capacity_report#shape_config BdsBdsCapacityReport#shape_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.bdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilitiesShapeConfig\"}", isOptional: true)]
            public oci.BdsBdsCapacityReport.IBdsBdsCapacityReportShapeAvailabilitiesShapeConfig? ShapeConfig
            {
                get => GetInstanceProperty<oci.BdsBdsCapacityReport.IBdsBdsCapacityReportShapeAvailabilitiesShapeConfig?>();
            }
        }
    }
}
