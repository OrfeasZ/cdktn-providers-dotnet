using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceUtilNode), fullyQualifiedName: "oci.bdsBdsInstance.BdsBdsInstanceUtilNode")]
    public interface IBdsBdsInstanceUtilNode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#number_of_nodes BdsBdsInstance#number_of_nodes}.</summary>
        [JsiiProperty(name: "numberOfNodes", typeJson: "{\"primitive\":\"number\"}")]
        double NumberOfNodes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#shape BdsBdsInstance#shape}.</summary>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        string Shape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#subnet_id BdsBdsInstance#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#block_volume_size_in_gbs BdsBdsInstance#block_volume_size_in_gbs}.</summary>
        [JsiiProperty(name: "blockVolumeSizeInGbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlockVolumeSizeInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#shape_config BdsBdsInstance#shape_config}
        /// </remarks>
        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceUtilNodeShapeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BdsBdsInstance.IBdsBdsInstanceUtilNodeShapeConfig? ShapeConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceUtilNode), fullyQualifiedName: "oci.bdsBdsInstance.BdsBdsInstanceUtilNode")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstance.IBdsBdsInstanceUtilNode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#number_of_nodes BdsBdsInstance#number_of_nodes}.</summary>
            [JsiiProperty(name: "numberOfNodes", typeJson: "{\"primitive\":\"number\"}")]
            public double NumberOfNodes
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#shape BdsBdsInstance#shape}.</summary>
            [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
            public string Shape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#subnet_id BdsBdsInstance#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#block_volume_size_in_gbs BdsBdsInstance#block_volume_size_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockVolumeSizeInGbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BlockVolumeSizeInGbs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>shape_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#shape_config BdsBdsInstance#shape_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceUtilNodeShapeConfig\"}", isOptional: true)]
            public oci.BdsBdsInstance.IBdsBdsInstanceUtilNodeShapeConfig? ShapeConfig
            {
                get => GetInstanceProperty<oci.BdsBdsInstance.IBdsBdsInstanceUtilNodeShapeConfig?>();
            }
        }
    }
}
