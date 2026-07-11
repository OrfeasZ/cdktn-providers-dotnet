using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.NamedLocation
{
    [JsiiInterface(nativeType: typeof(INamedLocationIp), fullyQualifiedName: "azuread.namedLocation.NamedLocationIp")]
    public interface INamedLocationIp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/named_location#ip_ranges NamedLocation#ip_ranges}.</summary>
        [JsiiProperty(name: "ipRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] IpRanges
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/named_location#trusted NamedLocation#trusted}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "trusted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Trusted
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INamedLocationIp), fullyQualifiedName: "azuread.namedLocation.NamedLocationIp")]
        internal sealed class _Proxy : DeputyBase, azuread.NamedLocation.INamedLocationIp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/named_location#ip_ranges NamedLocation#ip_ranges}.</summary>
            [JsiiProperty(name: "ipRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] IpRanges
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/named_location#trusted NamedLocation#trusted}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trusted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Trusted
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
