using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SAcl
{
    [JsiiByValue(fqn: "scaleway.k8SAcl.K8SAclAclRules")]
    public class K8SAclAclRules : scaleway.K8SAcl.IK8SAclAclRules
    {
        /// <summary>The description of the ACL rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_acl#description K8SAcl#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>The IP subnet to be allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_acl#ip K8SAcl#ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ip
        {
            get;
            set;
        }

        private object? _scalewayRanges;

        /// <summary>Allow access to cluster from all Scaleway ranges.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_acl#scaleway_ranges K8SAcl#scaleway_ranges}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scalewayRanges", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ScalewayRanges
        {
            get => _scalewayRanges;
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
                _scalewayRanges = value;
            }
        }
    }
}
