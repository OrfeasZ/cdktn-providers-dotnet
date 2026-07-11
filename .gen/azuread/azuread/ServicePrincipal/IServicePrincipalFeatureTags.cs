using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ServicePrincipal
{
    [JsiiInterface(nativeType: typeof(IServicePrincipalFeatureTags), fullyQualifiedName: "azuread.servicePrincipal.ServicePrincipalFeatureTags")]
    public interface IServicePrincipalFeatureTags
    {
        /// <summary>Whether this service principal represents a custom SAML application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#custom_single_sign_on ServicePrincipal#custom_single_sign_on}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "customSingleSignOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomSingleSignOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this service principal represents an Enterprise Application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#enterprise ServicePrincipal#enterprise}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enterprise", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enterprise
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this service principal represents a gallery application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#gallery ServicePrincipal#gallery}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "gallery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Gallery
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this app is invisible to users in My Apps and Office 365 Launcher.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#hide ServicePrincipal#hide}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "hide", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Hide
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicePrincipalFeatureTags), fullyQualifiedName: "azuread.servicePrincipal.ServicePrincipalFeatureTags")]
        internal sealed class _Proxy : DeputyBase, azuread.ServicePrincipal.IServicePrincipalFeatureTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether this service principal represents a custom SAML application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#custom_single_sign_on ServicePrincipal#custom_single_sign_on}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customSingleSignOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CustomSingleSignOn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether this service principal represents an Enterprise Application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#enterprise ServicePrincipal#enterprise}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enterprise", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enterprise
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether this service principal represents a gallery application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#gallery ServicePrincipal#gallery}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gallery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Gallery
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether this app is invisible to users in My Apps and Office 365 Launcher.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#hide ServicePrincipal#hide}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hide", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Hide
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
