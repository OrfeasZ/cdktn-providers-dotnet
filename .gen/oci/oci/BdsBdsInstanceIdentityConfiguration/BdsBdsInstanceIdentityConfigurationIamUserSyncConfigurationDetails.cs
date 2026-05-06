using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceIdentityConfiguration
{
    [JsiiByValue(fqn: "oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails")]
    public class BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails : oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails
    {
        private object? _isPosixAttributesAdditionRequired;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#is_posix_attributes_addition_required BdsBdsInstanceIdentityConfiguration#is_posix_attributes_addition_required}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isPosixAttributesAdditionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsPosixAttributesAdditionRequired
        {
            get => _isPosixAttributesAdditionRequired;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isPosixAttributesAdditionRequired = value;
            }
        }
    }
}
