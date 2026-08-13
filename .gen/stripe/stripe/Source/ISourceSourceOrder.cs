using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiInterface(nativeType: typeof(ISourceSourceOrder), fullyQualifiedName: "stripe.source.SourceSourceOrder")]
    public interface ISourceSourceOrder
    {
        /// <summary>List of items constituting the order.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#items Source#items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Source.ISourceSourceOrderItems" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.source.SourceSourceOrderItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Items
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#shipping Source#shipping}.</summary>
        [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.source.SourceSourceOrderShipping\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Source.ISourceSourceOrderShipping? Shipping
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISourceSourceOrder), fullyQualifiedName: "stripe.source.SourceSourceOrder")]
        internal sealed class _Proxy : DeputyBase, stripe.Source.ISourceSourceOrder
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of items constituting the order.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#items Source#items}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Source.ISourceSourceOrderItems" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.source.SourceSourceOrderItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Items
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#shipping Source#shipping}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.source.SourceSourceOrderShipping\"}", isOptional: true)]
            public stripe.Source.ISourceSourceOrderShipping? Shipping
            {
                get => GetInstanceProperty<stripe.Source.ISourceSourceOrderShipping?>();
            }
        }
    }
}
