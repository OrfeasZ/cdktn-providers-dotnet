using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.functionsApplication.FunctionsApplicationImagePolicyConfig")]
    public class FunctionsApplicationImagePolicyConfig : oci.FunctionsApplication.IFunctionsApplicationImagePolicyConfig
    {
        private object _isPolicyEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_application#is_policy_enabled FunctionsApplication#is_policy_enabled}.</summary>
        [JsiiProperty(name: "isPolicyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsPolicyEnabled
        {
            get => _isPolicyEnabled;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isPolicyEnabled = value;
            }
        }

        private object? _keyDetails;

        /// <summary>key_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_application#key_details FunctionsApplication#key_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.functionsApplication.FunctionsApplicationImagePolicyConfigKeyDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KeyDetails
        {
            get => _keyDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FunctionsApplication.IFunctionsApplicationImagePolicyConfigKeyDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FunctionsApplication.IFunctionsApplicationImagePolicyConfigKeyDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _keyDetails = value;
            }
        }
    }
}
