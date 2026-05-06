using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipelineStage
{
    [JsiiInterface(nativeType: typeof(IDevopsBuildPipelineStagePrivateAccessConfig), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStagePrivateAccessConfig")]
    public interface IDevopsBuildPipelineStagePrivateAccessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#network_channel_type DevopsBuildPipelineStage#network_channel_type}.</summary>
        [JsiiProperty(name: "networkChannelType", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkChannelType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#subnet_id DevopsBuildPipelineStage#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#nsg_ids DevopsBuildPipelineStage#nsg_ids}.</summary>
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NsgIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsBuildPipelineStagePrivateAccessConfig), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStagePrivateAccessConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStagePrivateAccessConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#network_channel_type DevopsBuildPipelineStage#network_channel_type}.</summary>
            [JsiiProperty(name: "networkChannelType", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkChannelType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#subnet_id DevopsBuildPipelineStage#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#nsg_ids DevopsBuildPipelineStage#nsg_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NsgIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
