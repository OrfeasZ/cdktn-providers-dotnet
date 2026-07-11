using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiInterface(nativeType: typeof(IApplicationOptionalClaimsAccessToken), fullyQualifiedName: "azuread.application.ApplicationOptionalClaimsAccessToken")]
    public interface IApplicationOptionalClaimsAccessToken
    {
        /// <summary>The name of the optional claim.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#name Application#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>List of additional properties of the claim.</summary>
        /// <remarks>
        /// If a property exists in this list, it modifies the behaviour of the optional claim
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#additional_properties Application#additional_properties}
        /// </remarks>
        [JsiiProperty(name: "additionalProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AdditionalProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the claim specified by the client is necessary to ensure a smooth authorization experience.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#essential Application#essential}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "essential", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Essential
        {
            get
            {
                return null;
            }
        }

        /// <summary>The source of the claim.</summary>
        /// <remarks>
        /// If <c>source</c> is absent, the claim is a predefined optional claim. If <c>source</c> is <c>user</c>, the value of <c>name</c> is the extension property from the user object
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#source Application#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationOptionalClaimsAccessToken), fullyQualifiedName: "azuread.application.ApplicationOptionalClaimsAccessToken")]
        internal sealed class _Proxy : DeputyBase, azuread.Application.IApplicationOptionalClaimsAccessToken
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the optional claim.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#name Application#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>List of additional properties of the claim.</summary>
            /// <remarks>
            /// If a property exists in this list, it modifies the behaviour of the optional claim
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#additional_properties Application#additional_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AdditionalProperties
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Whether the claim specified by the client is necessary to ensure a smooth authorization experience.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#essential Application#essential}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "essential", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Essential
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The source of the claim.</summary>
            /// <remarks>
            /// If <c>source</c> is absent, the claim is a predefined optional claim. If <c>source</c> is <c>user</c>, the value of <c>name</c> is the extension property from the user object
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#source Application#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Source
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
