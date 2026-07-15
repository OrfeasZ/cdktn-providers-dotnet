using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ResiliencehubResiliencyPolicy
{
    [JsiiInterface(nativeType: typeof(IResiliencehubResiliencyPolicyPolicy), fullyQualifiedName: "aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicy")]
    public interface IResiliencehubResiliencyPolicyPolicy
    {
        /// <summary>az block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/resiliencehub_resiliency_policy#az ResiliencehubResiliencyPolicy#az}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "az", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAz\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Az
        {
            get
            {
                return null;
            }
        }

        /// <summary>hardware block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/resiliencehub_resiliency_policy#hardware ResiliencehubResiliencyPolicy#hardware}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyHardware" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "hardware", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardware\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Hardware
        {
            get
            {
                return null;
            }
        }

        /// <summary>region block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/resiliencehub_resiliency_policy#region ResiliencehubResiliencyPolicy#region}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>software block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/resiliencehub_resiliency_policy#software ResiliencehubResiliencyPolicy#software}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicySoftware" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "softwareAttribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftware\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SoftwareAttribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubResiliencyPolicyPolicy), fullyQualifiedName: "aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>az block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/resiliencehub_resiliency_policy#az ResiliencehubResiliencyPolicy#az}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "az", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAz\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Az
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>hardware block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/resiliencehub_resiliency_policy#hardware ResiliencehubResiliencyPolicy#hardware}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyHardware" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hardware", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardware\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Hardware
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>region block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/resiliencehub_resiliency_policy#region ResiliencehubResiliencyPolicy#region}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Region
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>software block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/resiliencehub_resiliency_policy#software ResiliencehubResiliencyPolicy#software}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicySoftware" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "softwareAttribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftware\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SoftwareAttribute
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
