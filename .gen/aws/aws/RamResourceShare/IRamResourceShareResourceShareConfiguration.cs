using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RamResourceShare
{
    [JsiiInterface(nativeType: typeof(IRamResourceShareResourceShareConfiguration), fullyQualifiedName: "aws.ramResourceShare.RamResourceShareResourceShareConfiguration")]
    public interface IRamResourceShareResourceShareConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ram_resource_share#retain_sharing_on_account_leave_organization RamResourceShare#retain_sharing_on_account_leave_organization}.</summary>
        [JsiiProperty(name: "retainSharingOnAccountLeaveOrganization", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RetainSharingOnAccountLeaveOrganization
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRamResourceShareResourceShareConfiguration), fullyQualifiedName: "aws.ramResourceShare.RamResourceShareResourceShareConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.RamResourceShare.IRamResourceShareResourceShareConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ram_resource_share#retain_sharing_on_account_leave_organization RamResourceShare#retain_sharing_on_account_leave_organization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retainSharingOnAccountLeaveOrganization", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RetainSharingOnAccountLeaveOrganization
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
