using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    [JsiiInterface(nativeType: typeof(ICoreInstanceLaunchVolumeAttachmentsLaunchCreateVolumeDetails), fullyQualifiedName: "oci.coreInstance.CoreInstanceLaunchVolumeAttachmentsLaunchCreateVolumeDetails")]
    public interface ICoreInstanceLaunchVolumeAttachmentsLaunchCreateVolumeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#size_in_gbs CoreInstance#size_in_gbs}.</summary>
        [JsiiProperty(name: "sizeInGbs", typeJson: "{\"primitive\":\"string\"}")]
        string SizeInGbs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#volume_creation_type CoreInstance#volume_creation_type}.</summary>
        [JsiiProperty(name: "volumeCreationType", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeCreationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#compartment_id CoreInstance#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#display_name CoreInstance#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#kms_key_id CoreInstance#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#vpus_per_gb CoreInstance#vpus_per_gb}.</summary>
        [JsiiProperty(name: "vpusPerGb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpusPerGb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstanceLaunchVolumeAttachmentsLaunchCreateVolumeDetails), fullyQualifiedName: "oci.coreInstance.CoreInstanceLaunchVolumeAttachmentsLaunchCreateVolumeDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstance.ICoreInstanceLaunchVolumeAttachmentsLaunchCreateVolumeDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#size_in_gbs CoreInstance#size_in_gbs}.</summary>
            [JsiiProperty(name: "sizeInGbs", typeJson: "{\"primitive\":\"string\"}")]
            public string SizeInGbs
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#volume_creation_type CoreInstance#volume_creation_type}.</summary>
            [JsiiProperty(name: "volumeCreationType", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeCreationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#compartment_id CoreInstance#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#display_name CoreInstance#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#kms_key_id CoreInstance#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#vpus_per_gb CoreInstance#vpus_per_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpusPerGb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpusPerGb
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
