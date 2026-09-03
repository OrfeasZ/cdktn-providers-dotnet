using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccountaccessApplication
{
    [JsiiInterface(nativeType: typeof(IAccountaccessApplicationIdentitySource), fullyQualifiedName: "aws.accountaccessApplication.AccountaccessApplicationIdentitySource")]
    public interface IAccountaccessApplicationIdentitySource
    {
        /// <summary>identity_center block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/accountaccess_application#identity_center AccountaccessApplication#identity_center}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AccountaccessApplication.IAccountaccessApplicationIdentitySourceIdentityCenter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "identityCenter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accountaccessApplication.AccountaccessApplicationIdentitySourceIdentityCenter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdentityCenter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountaccessApplicationIdentitySource), fullyQualifiedName: "aws.accountaccessApplication.AccountaccessApplicationIdentitySource")]
        internal sealed class _Proxy : DeputyBase, aws.AccountaccessApplication.IAccountaccessApplicationIdentitySource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>identity_center block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/accountaccess_application#identity_center AccountaccessApplication#identity_center}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AccountaccessApplication.IAccountaccessApplicationIdentitySourceIdentityCenter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityCenter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accountaccessApplication.AccountaccessApplicationIdentitySourceIdentityCenter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IdentityCenter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
