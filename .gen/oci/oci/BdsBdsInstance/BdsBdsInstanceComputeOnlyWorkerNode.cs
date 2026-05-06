using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.bdsBdsInstance.BdsBdsInstanceComputeOnlyWorkerNode")]
    public class BdsBdsInstanceComputeOnlyWorkerNode : oci.BdsBdsInstance.IBdsBdsInstanceComputeOnlyWorkerNode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#number_of_nodes BdsBdsInstance#number_of_nodes}.</summary>
        [JsiiProperty(name: "numberOfNodes", typeJson: "{\"primitive\":\"number\"}")]
        public double NumberOfNodes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#shape BdsBdsInstance#shape}.</summary>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public string Shape
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#subnet_id BdsBdsInstance#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#block_volume_size_in_gbs BdsBdsInstance#block_volume_size_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockVolumeSizeInGbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlockVolumeSizeInGbs
        {
            get;
            set;
        }

        /// <summary>shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#shape_config BdsBdsInstance#shape_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceComputeOnlyWorkerNodeShapeConfig\"}", isOptional: true)]
        public oci.BdsBdsInstance.IBdsBdsInstanceComputeOnlyWorkerNodeShapeConfig? ShapeConfig
        {
            get;
            set;
        }
    }
}
