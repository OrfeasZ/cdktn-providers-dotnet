using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainSoftwareUpdateOptions")]
    public class OpensearchDomainSoftwareUpdateOptions : aws.OpensearchDomain.IOpensearchDomainSoftwareUpdateOptions
    {
        private object? _autoSoftwareUpdateEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_domain#auto_software_update_enabled OpensearchDomain#auto_software_update_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoSoftwareUpdateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AutoSoftwareUpdateEnabled
        {
            get => _autoSoftwareUpdateEnabled;
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
                _autoSoftwareUpdateEnabled = value;
            }
        }
    }
}
