using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkflowmonitorScope
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkflowmonitorScope.NetworkflowmonitorScopeTargetTargetIdentifier")]
    public class NetworkflowmonitorScopeTargetTargetIdentifier : aws.NetworkflowmonitorScope.INetworkflowmonitorScopeTargetTargetIdentifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkflowmonitor_scope#target_type NetworkflowmonitorScope#target_type}.</summary>
        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetType
        {
            get;
            set;
        }

        private object? _targetId;

        /// <summary>target_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkflowmonitor_scope#target_id NetworkflowmonitorScope#target_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkflowmonitorScope.NetworkflowmonitorScopeTargetTargetIdentifierTargetId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TargetId
        {
            get => _targetId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.NetworkflowmonitorScope.INetworkflowmonitorScopeTargetTargetIdentifierTargetId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworkflowmonitorScope.INetworkflowmonitorScopeTargetTargetIdentifierTargetId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetId = value;
            }
        }
    }
}
