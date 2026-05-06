using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceIdentityConfiguration
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails), fullyQualifiedName: "oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails")]
    public interface IBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#is_posix_attributes_addition_required BdsBdsInstanceIdentityConfiguration#is_posix_attributes_addition_required}.</summary>
        [JsiiProperty(name: "isPosixAttributesAdditionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPosixAttributesAdditionRequired
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails), fullyQualifiedName: "oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#is_posix_attributes_addition_required BdsBdsInstanceIdentityConfiguration#is_posix_attributes_addition_required}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isPosixAttributesAdditionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsPosixAttributesAdditionRequired
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
