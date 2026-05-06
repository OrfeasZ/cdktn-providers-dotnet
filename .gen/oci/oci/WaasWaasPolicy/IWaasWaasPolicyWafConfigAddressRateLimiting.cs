using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyWafConfigAddressRateLimiting), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigAddressRateLimiting")]
    public interface IWaasWaasPolicyWafConfigAddressRateLimiting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_enabled WaasWaasPolicy#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#allowed_rate_per_address WaasWaasPolicy#allowed_rate_per_address}.</summary>
        [JsiiProperty(name: "allowedRatePerAddress", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AllowedRatePerAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_response_code WaasWaasPolicy#block_response_code}.</summary>
        [JsiiProperty(name: "blockResponseCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BlockResponseCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#max_delayed_count_per_address WaasWaasPolicy#max_delayed_count_per_address}.</summary>
        [JsiiProperty(name: "maxDelayedCountPerAddress", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxDelayedCountPerAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyWafConfigAddressRateLimiting), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigAddressRateLimiting")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAddressRateLimiting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_enabled WaasWaasPolicy#is_enabled}.</summary>
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#allowed_rate_per_address WaasWaasPolicy#allowed_rate_per_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedRatePerAddress", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AllowedRatePerAddress
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_response_code WaasWaasPolicy#block_response_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockResponseCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BlockResponseCode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#max_delayed_count_per_address WaasWaasPolicy#max_delayed_count_per_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxDelayedCountPerAddress", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxDelayedCountPerAddress
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
