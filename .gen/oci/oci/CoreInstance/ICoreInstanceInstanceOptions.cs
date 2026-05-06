using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    [JsiiInterface(nativeType: typeof(ICoreInstanceInstanceOptions), fullyQualifiedName: "oci.coreInstance.CoreInstanceInstanceOptions")]
    public interface ICoreInstanceInstanceOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#are_legacy_imds_endpoints_disabled CoreInstance#are_legacy_imds_endpoints_disabled}.</summary>
        [JsiiProperty(name: "areLegacyImdsEndpointsDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AreLegacyImdsEndpointsDisabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstanceInstanceOptions), fullyQualifiedName: "oci.coreInstance.CoreInstanceInstanceOptions")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstance.ICoreInstanceInstanceOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#are_legacy_imds_endpoints_disabled CoreInstance#are_legacy_imds_endpoints_disabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "areLegacyImdsEndpointsDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AreLegacyImdsEndpointsDisabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
