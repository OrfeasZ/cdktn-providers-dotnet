using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsTargetAsset
{
    [JsiiByValue(fqn: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecInstanceOptions")]
    public class CloudMigrationsTargetAssetUserSpecInstanceOptions : oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecInstanceOptions
    {
        private object? _areLegacyImdsEndpointsDisabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#are_legacy_imds_endpoints_disabled CloudMigrationsTargetAsset#are_legacy_imds_endpoints_disabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "areLegacyImdsEndpointsDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AreLegacyImdsEndpointsDisabled
        {
            get => _areLegacyImdsEndpointsDisabled;
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
                _areLegacyImdsEndpointsDisabled = value;
            }
        }
    }
}
