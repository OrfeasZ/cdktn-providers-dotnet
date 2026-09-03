using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    [JsiiByValue(fqn: "aws.datazonePolicyGrant.DatazonePolicyGrantDetailAddToProjectMemberPool")]
    public class DatazonePolicyGrantDetailAddToProjectMemberPool : aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailAddToProjectMemberPool
    {
        private object? _includeChildDomainUnits;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#include_child_domain_units DatazonePolicyGrant#include_child_domain_units}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includeChildDomainUnits", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeChildDomainUnits
        {
            get => _includeChildDomainUnits;
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
                _includeChildDomainUnits = value;
            }
        }
    }
}
