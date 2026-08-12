using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    [JsiiInterface(nativeType: typeof(IContainerengineNodePoolSecondaryVnics), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolSecondaryVnics")]
    public interface IContainerengineNodePoolSecondaryVnics
    {
        /// <summary>create_vnic_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/containerengine_node_pool#create_vnic_details ContainerengineNodePool#create_vnic_details}
        /// </remarks>
        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolSecondaryVnicsCreateVnicDetails\"}")]
        oci.ContainerengineNodePool.IContainerengineNodePoolSecondaryVnicsCreateVnicDetails CreateVnicDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/containerengine_node_pool#display_name ContainerengineNodePool#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/containerengine_node_pool#nic_index ContainerengineNodePool#nic_index}.</summary>
        [JsiiProperty(name: "nicIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NicIndex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineNodePoolSecondaryVnics), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolSecondaryVnics")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineNodePool.IContainerengineNodePoolSecondaryVnics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>create_vnic_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/containerengine_node_pool#create_vnic_details ContainerengineNodePool#create_vnic_details}
            /// </remarks>
            [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolSecondaryVnicsCreateVnicDetails\"}")]
            public oci.ContainerengineNodePool.IContainerengineNodePoolSecondaryVnicsCreateVnicDetails CreateVnicDetails
            {
                get => GetInstanceProperty<oci.ContainerengineNodePool.IContainerengineNodePoolSecondaryVnicsCreateVnicDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/containerengine_node_pool#display_name ContainerengineNodePool#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/containerengine_node_pool#nic_index ContainerengineNodePool#nic_index}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nicIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NicIndex
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
