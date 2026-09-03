using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccountaccessApplication
{
    [JsiiByValue(fqn: "aws.accountaccessApplication.AccountaccessApplicationIdentitySource")]
    public class AccountaccessApplicationIdentitySource : aws.AccountaccessApplication.IAccountaccessApplicationIdentitySource
    {
        private object? _identityCenter;

        /// <summary>identity_center block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/accountaccess_application#identity_center AccountaccessApplication#identity_center}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AccountaccessApplication.IAccountaccessApplicationIdentitySourceIdentityCenter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityCenter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accountaccessApplication.AccountaccessApplicationIdentitySourceIdentityCenter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IdentityCenter
        {
            get => _identityCenter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AccountaccessApplication.IAccountaccessApplicationIdentitySourceIdentityCenter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AccountaccessApplication.IAccountaccessApplicationIdentitySourceIdentityCenter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _identityCenter = value;
            }
        }
    }
}
