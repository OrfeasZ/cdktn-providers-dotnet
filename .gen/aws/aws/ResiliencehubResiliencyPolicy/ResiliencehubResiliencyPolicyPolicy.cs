using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ResiliencehubResiliencyPolicy
{
    [JsiiByValue(fqn: "aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicy")]
    public class ResiliencehubResiliencyPolicyPolicy : aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicy
    {
        private object? _az;

        /// <summary>az block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/resiliencehub_resiliency_policy#az ResiliencehubResiliencyPolicy#az}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "az", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAz\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Az
        {
            get => _az;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _az = value;
            }
        }

        private object? _hardware;

        /// <summary>hardware block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/resiliencehub_resiliency_policy#hardware ResiliencehubResiliencyPolicy#hardware}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hardware", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardware\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Hardware
        {
            get => _hardware;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyHardware[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyHardware).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hardware = value;
            }
        }

        private object? _region;

        /// <summary>region block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/resiliencehub_resiliency_policy#region ResiliencehubResiliencyPolicy#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Region
        {
            get => _region;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _region = value;
            }
        }

        private object? _softwareAttribute;

        /// <summary>software block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/resiliencehub_resiliency_policy#software ResiliencehubResiliencyPolicy#software}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "softwareAttribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftware\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SoftwareAttribute
        {
            get => _softwareAttribute;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicySoftware[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicySoftware).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _softwareAttribute = value;
            }
        }
    }
}
