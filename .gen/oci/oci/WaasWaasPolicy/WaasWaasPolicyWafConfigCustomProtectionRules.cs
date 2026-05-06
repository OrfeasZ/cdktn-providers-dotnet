using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiByValue(fqn: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigCustomProtectionRules")]
    public class WaasWaasPolicyWafConfigCustomProtectionRules : oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCustomProtectionRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#action WaasWaasPolicy#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }

        private object? _exclusions;

        /// <summary>exclusions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#exclusions WaasWaasPolicy#exclusions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclusions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigCustomProtectionRulesExclusions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Exclusions
        {
            get => _exclusions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCustomProtectionRulesExclusions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCustomProtectionRulesExclusions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exclusions = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#id WaasWaasPolicy#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }
    }
}
