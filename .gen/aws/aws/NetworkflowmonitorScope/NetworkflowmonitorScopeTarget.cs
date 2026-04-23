using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkflowmonitorScope
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkflowmonitorScope.NetworkflowmonitorScopeTarget")]
    public class NetworkflowmonitorScopeTarget : aws.NetworkflowmonitorScope.INetworkflowmonitorScopeTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkflowmonitor_scope#region NetworkflowmonitorScope#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }

        private object? _targetIdentifier;

        /// <summary>target_identifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkflowmonitor_scope#target_identifier NetworkflowmonitorScope#target_identifier}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetIdentifier", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkflowmonitorScope.NetworkflowmonitorScopeTargetTargetIdentifier\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TargetIdentifier
        {
            get => _targetIdentifier;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.NetworkflowmonitorScope.INetworkflowmonitorScopeTargetTargetIdentifier[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworkflowmonitorScope.INetworkflowmonitorScopeTargetTargetIdentifier).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetIdentifier = value;
            }
        }
    }
}
