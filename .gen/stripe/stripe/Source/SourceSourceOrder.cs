using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiByValue(fqn: "stripe.source.SourceSourceOrder")]
    public class SourceSourceOrder : stripe.Source.ISourceSourceOrder
    {
        private object? _items;

        /// <summary>List of items constituting the order.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#items Source#items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Source.ISourceSourceOrderItems" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.source.SourceSourceOrderItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Items
        {
            get => _items;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Source.ISourceSourceOrderItems[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Source.ISourceSourceOrderItems).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _items = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#shipping Source#shipping}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.source.SourceSourceOrderShipping\"}", isOptional: true)]
        public stripe.Source.ISourceSourceOrderShipping? Shipping
        {
            get;
            set;
        }
    }
}
