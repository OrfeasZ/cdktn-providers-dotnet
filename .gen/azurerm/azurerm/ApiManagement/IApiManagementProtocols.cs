using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    [JsiiInterface(nativeType: typeof(IApiManagementProtocols), fullyQualifiedName: "azurerm.apiManagement.ApiManagementProtocols")]
    public interface IApiManagementProtocols
    {
        /// <summary>Should HTTP/2 be supported by the API Management Service?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#http2_enabled ApiManagement#http2_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "http2Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Http2Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementProtocols), fullyQualifiedName: "azurerm.apiManagement.ApiManagementProtocols")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagement.IApiManagementProtocols
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Should HTTP/2 be supported by the API Management Service?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#http2_enabled ApiManagement#http2_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Http2Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
