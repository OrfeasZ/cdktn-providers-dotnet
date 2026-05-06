using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiInterface(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumes), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsBlockVolumes")]
    public interface ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumes
    {
        /// <summary>attach_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#attach_details CoreInstanceConfiguration#attach_details}
        /// </remarks>
        [JsiiProperty(name: "attachDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesAttachDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesAttachDetails? AttachDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>create_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#create_details CoreInstanceConfiguration#create_details}
        /// </remarks>
        [JsiiProperty(name: "createDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetails? CreateDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#volume_id CoreInstanceConfiguration#volume_id}.</summary>
        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumes), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsBlockVolumes")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>attach_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#attach_details CoreInstanceConfiguration#attach_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "attachDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesAttachDetails\"}", isOptional: true)]
            public oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesAttachDetails? AttachDetails
            {
                get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesAttachDetails?>();
            }

            /// <summary>create_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#create_details CoreInstanceConfiguration#create_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetails\"}", isOptional: true)]
            public oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetails? CreateDetails
            {
                get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#volume_id CoreInstanceConfiguration#volume_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
