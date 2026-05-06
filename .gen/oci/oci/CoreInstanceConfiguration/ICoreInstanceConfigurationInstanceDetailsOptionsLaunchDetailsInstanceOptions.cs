using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiInterface(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsInstanceOptions), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsInstanceOptions")]
    public interface ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsInstanceOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#are_legacy_imds_endpoints_disabled CoreInstanceConfiguration#are_legacy_imds_endpoints_disabled}.</summary>
        [JsiiProperty(name: "areLegacyImdsEndpointsDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AreLegacyImdsEndpointsDisabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsInstanceOptions), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsInstanceOptions")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsInstanceOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#are_legacy_imds_endpoints_disabled CoreInstanceConfiguration#are_legacy_imds_endpoints_disabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "areLegacyImdsEndpointsDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AreLegacyImdsEndpointsDisabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
