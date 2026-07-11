using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSiteConfigCors), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigCors")]
    public interface IWindowsWebAppSiteConfigCors
    {
        /// <summary>Specifies a list of origins that should be allowed to make cross-origin calls.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app#allowed_origins WindowsWebApp#allowed_origins}
        /// </remarks>
        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedOrigins
        {
            get
            {
                return null;
            }
        }

        /// <summary>Are credentials allowed in CORS requests? Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app#support_credentials WindowsWebApp#support_credentials}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "supportCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SupportCredentials
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSiteConfigCors), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigCors")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebApp.IWindowsWebAppSiteConfigCors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies a list of origins that should be allowed to make cross-origin calls.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app#allowed_origins WindowsWebApp#allowed_origins}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedOrigins
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Are credentials allowed in CORS requests? Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app#support_credentials WindowsWebApp#support_credentials}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "supportCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SupportCredentials
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
