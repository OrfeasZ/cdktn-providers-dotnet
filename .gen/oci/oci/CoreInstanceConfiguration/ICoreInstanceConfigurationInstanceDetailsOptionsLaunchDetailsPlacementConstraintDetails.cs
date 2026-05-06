using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiInterface(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPlacementConstraintDetails), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPlacementConstraintDetails")]
    public interface ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPlacementConstraintDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#compute_host_group_id CoreInstanceConfiguration#compute_host_group_id}.</summary>
        [JsiiProperty(name: "computeHostGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string ComputeHostGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#type CoreInstanceConfiguration#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPlacementConstraintDetails), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPlacementConstraintDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPlacementConstraintDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#compute_host_group_id CoreInstanceConfiguration#compute_host_group_id}.</summary>
            [JsiiProperty(name: "computeHostGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string ComputeHostGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#type CoreInstanceConfiguration#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
