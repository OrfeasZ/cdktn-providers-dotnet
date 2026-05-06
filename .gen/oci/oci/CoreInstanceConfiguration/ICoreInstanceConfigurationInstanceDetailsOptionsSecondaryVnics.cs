using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiInterface(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnics), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnics")]
    public interface ICoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnics
    {
        /// <summary>create_vnic_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#create_vnic_details CoreInstanceConfiguration#create_vnic_details}
        /// </remarks>
        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnicsCreateVnicDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnicsCreateVnicDetails? CreateVnicDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#display_name CoreInstanceConfiguration#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#nic_index CoreInstanceConfiguration#nic_index}.</summary>
        [JsiiProperty(name: "nicIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NicIndex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnics), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnics")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>create_vnic_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#create_vnic_details CoreInstanceConfiguration#create_vnic_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnicsCreateVnicDetails\"}", isOptional: true)]
            public oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnicsCreateVnicDetails? CreateVnicDetails
            {
                get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnicsCreateVnicDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#display_name CoreInstanceConfiguration#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#nic_index CoreInstanceConfiguration#nic_index}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nicIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NicIndex
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
