using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiInterface(nativeType: typeof(IApplicationRequiredResourceAccess), fullyQualifiedName: "azuread.application.ApplicationRequiredResourceAccess")]
    public interface IApplicationRequiredResourceAccess
    {
        /// <summary>resource_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#resource_access Application#resource_access}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationRequiredResourceAccessResourceAccess" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceAccess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationRequiredResourceAccessResourceAccess\"},\"kind\":\"array\"}}]}}")]
        object ResourceAccess
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#resource_app_id Application#resource_app_id}.</summary>
        [JsiiProperty(name: "resourceAppId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceAppId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationRequiredResourceAccess), fullyQualifiedName: "azuread.application.ApplicationRequiredResourceAccess")]
        internal sealed class _Proxy : DeputyBase, azuread.Application.IApplicationRequiredResourceAccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resource_access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#resource_access Application#resource_access}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationRequiredResourceAccessResourceAccess" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "resourceAccess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationRequiredResourceAccessResourceAccess\"},\"kind\":\"array\"}}]}}")]
            public object ResourceAccess
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#resource_app_id Application#resource_app_id}.</summary>
            [JsiiProperty(name: "resourceAppId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceAppId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
