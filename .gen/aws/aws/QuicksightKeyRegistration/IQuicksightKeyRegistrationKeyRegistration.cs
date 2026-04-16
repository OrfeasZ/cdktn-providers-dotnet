using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightKeyRegistration
{
    [JsiiInterface(nativeType: typeof(IQuicksightKeyRegistrationKeyRegistration), fullyQualifiedName: "aws.quicksightKeyRegistration.QuicksightKeyRegistrationKeyRegistration")]
    public interface IQuicksightKeyRegistrationKeyRegistration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/quicksight_key_registration#key_arn QuicksightKeyRegistration#key_arn}.</summary>
        [JsiiProperty(name: "keyArn", typeJson: "{\"primitive\":\"string\"}")]
        string KeyArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/quicksight_key_registration#default_key QuicksightKeyRegistration#default_key}.</summary>
        [JsiiProperty(name: "defaultKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightKeyRegistrationKeyRegistration), fullyQualifiedName: "aws.quicksightKeyRegistration.QuicksightKeyRegistrationKeyRegistration")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightKeyRegistration.IQuicksightKeyRegistrationKeyRegistration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/quicksight_key_registration#key_arn QuicksightKeyRegistration#key_arn}.</summary>
            [JsiiProperty(name: "keyArn", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/quicksight_key_registration#default_key QuicksightKeyRegistration#default_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DefaultKey
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
