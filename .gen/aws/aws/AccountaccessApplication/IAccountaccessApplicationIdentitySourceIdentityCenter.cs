using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccountaccessApplication
{
    [JsiiInterface(nativeType: typeof(IAccountaccessApplicationIdentitySourceIdentityCenter), fullyQualifiedName: "aws.accountaccessApplication.AccountaccessApplicationIdentitySourceIdentityCenter")]
    public interface IAccountaccessApplicationIdentitySourceIdentityCenter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/accountaccess_application#instance_arn AccountaccessApplication#instance_arn}.</summary>
        [JsiiProperty(name: "instanceArn", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountaccessApplicationIdentitySourceIdentityCenter), fullyQualifiedName: "aws.accountaccessApplication.AccountaccessApplicationIdentitySourceIdentityCenter")]
        internal sealed class _Proxy : DeputyBase, aws.AccountaccessApplication.IAccountaccessApplicationIdentitySourceIdentityCenter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/accountaccess_application#instance_arn AccountaccessApplication#instance_arn}.</summary>
            [JsiiProperty(name: "instanceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
