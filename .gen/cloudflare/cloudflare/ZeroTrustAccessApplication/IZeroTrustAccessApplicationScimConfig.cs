using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationScimConfig), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationScimConfig")]
    public interface IZeroTrustAccessApplicationScimConfig
    {
        /// <summary>The UID of the IdP to use as the source for SCIM resources to provision to this application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#idp_uid ZeroTrustAccessApplication#idp_uid}
        /// </remarks>
        [JsiiProperty(name: "idpUid", typeJson: "{\"primitive\":\"string\"}")]
        string IdpUid
        {
            get;
        }

        /// <summary>The base URI for the application's SCIM-compatible API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#remote_uri ZeroTrustAccessApplication#remote_uri}
        /// </remarks>
        [JsiiProperty(name: "remoteUri", typeJson: "{\"primitive\":\"string\"}")]
        string RemoteUri
        {
            get;
        }

        /// <summary>Attributes for configuring HTTP Basic authentication scheme for SCIM provisioning to an application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#authentication ZeroTrustAccessApplication#authentication}
        /// </remarks>
        [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationScimConfigAuthentication\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationScimConfigAuthentication? Authentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>If false, propagates DELETE requests to the target application for SCIM resources.</summary>
        /// <remarks>
        /// If true, sets 'active' to false on the SCIM resource. Note: Some targets do not support DELETE operations.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#deactivate_on_delete ZeroTrustAccessApplication#deactivate_on_delete}
        /// </remarks>
        [JsiiProperty(name: "deactivateOnDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeactivateOnDelete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether SCIM provisioning is turned on for this application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#enabled ZeroTrustAccessApplication#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of mappings to apply to SCIM resources before provisioning them in this application.</summary>
        /// <remarks>
        /// These can transform or filter the resources to be provisioned.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#mappings ZeroTrustAccessApplication#mappings}
        /// </remarks>
        [JsiiProperty(name: "mappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationScimConfigMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Mappings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationScimConfig), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationScimConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationScimConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The UID of the IdP to use as the source for SCIM resources to provision to this application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#idp_uid ZeroTrustAccessApplication#idp_uid}
            /// </remarks>
            [JsiiProperty(name: "idpUid", typeJson: "{\"primitive\":\"string\"}")]
            public string IdpUid
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The base URI for the application's SCIM-compatible API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#remote_uri ZeroTrustAccessApplication#remote_uri}
            /// </remarks>
            [JsiiProperty(name: "remoteUri", typeJson: "{\"primitive\":\"string\"}")]
            public string RemoteUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Attributes for configuring HTTP Basic authentication scheme for SCIM provisioning to an application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#authentication ZeroTrustAccessApplication#authentication}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationScimConfigAuthentication\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationScimConfigAuthentication? Authentication
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationScimConfigAuthentication?>();
            }

            /// <summary>If false, propagates DELETE requests to the target application for SCIM resources.</summary>
            /// <remarks>
            /// If true, sets 'active' to false on the SCIM resource. Note: Some targets do not support DELETE operations.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#deactivate_on_delete ZeroTrustAccessApplication#deactivate_on_delete}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deactivateOnDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeactivateOnDelete
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether SCIM provisioning is turned on for this application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#enabled ZeroTrustAccessApplication#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A list of mappings to apply to SCIM resources before provisioning them in this application.</summary>
            /// <remarks>
            /// These can transform or filter the resources to be provisioned.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#mappings ZeroTrustAccessApplication#mappings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationScimConfigMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Mappings
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
