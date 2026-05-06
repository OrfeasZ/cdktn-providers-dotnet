using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreBootVolume
{
    [JsiiInterface(nativeType: typeof(ICoreBootVolumeBootVolumeReplicas), fullyQualifiedName: "oci.coreBootVolume.CoreBootVolumeBootVolumeReplicas")]
    public interface ICoreBootVolumeBootVolumeReplicas
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_boot_volume#availability_domain CoreBootVolume#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        string AvailabilityDomain
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_boot_volume#display_name CoreBootVolume#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_boot_volume#xrr_kms_key_id CoreBootVolume#xrr_kms_key_id}.</summary>
        [JsiiProperty(name: "xrrKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? XrrKmsKeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreBootVolumeBootVolumeReplicas), fullyQualifiedName: "oci.coreBootVolume.CoreBootVolumeBootVolumeReplicas")]
        internal sealed class _Proxy : DeputyBase, oci.CoreBootVolume.ICoreBootVolumeBootVolumeReplicas
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_boot_volume#availability_domain CoreBootVolume#availability_domain}.</summary>
            [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
            public string AvailabilityDomain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_boot_volume#display_name CoreBootVolume#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_boot_volume#xrr_kms_key_id CoreBootVolume#xrr_kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "xrrKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? XrrKmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
