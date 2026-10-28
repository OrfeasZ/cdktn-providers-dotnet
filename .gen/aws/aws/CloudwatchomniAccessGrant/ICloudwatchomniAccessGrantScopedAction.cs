using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAccessGrant
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniAccessGrantScopedAction), fullyQualifiedName: "aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantScopedAction")]
    public interface ICloudwatchomniAccessGrantScopedAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#actions CloudwatchomniAccessGrant#actions}.</summary>
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Actions
        {
            get;
        }

        /// <summary>resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#resource CloudwatchomniAccessGrant#resource}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResource" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantScopedActionResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Resource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniAccessGrantScopedAction), fullyQualifiedName: "aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantScopedAction")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#actions CloudwatchomniAccessGrant#actions}.</summary>
            [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Actions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#resource CloudwatchomniAccessGrant#resource}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResource" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantScopedActionResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Resource
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
