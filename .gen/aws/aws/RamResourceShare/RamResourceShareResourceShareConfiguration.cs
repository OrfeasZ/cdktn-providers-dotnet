using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RamResourceShare
{
    [JsiiByValue(fqn: "aws.ramResourceShare.RamResourceShareResourceShareConfiguration")]
    public class RamResourceShareResourceShareConfiguration : aws.RamResourceShare.IRamResourceShareResourceShareConfiguration
    {
        private object? _retainSharingOnAccountLeaveOrganization;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ram_resource_share#retain_sharing_on_account_leave_organization RamResourceShare#retain_sharing_on_account_leave_organization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retainSharingOnAccountLeaveOrganization", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RetainSharingOnAccountLeaveOrganization
        {
            get => _retainSharingOnAccountLeaveOrganization;
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
                _retainSharingOnAccountLeaveOrganization = value;
            }
        }
    }
}
