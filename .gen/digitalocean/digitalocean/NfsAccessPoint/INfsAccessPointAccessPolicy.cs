using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.NfsAccessPoint
{
    [JsiiInterface(nativeType: typeof(INfsAccessPointAccessPolicy), fullyQualifiedName: "digitalocean.nfsAccessPoint.NfsAccessPointAccessPolicy")]
    public interface INfsAccessPointAccessPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.94.0/docs/resources/nfs_access_point#anongid NfsAccessPoint#anongid}.</summary>
        [JsiiProperty(name: "anongid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Anongid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.94.0/docs/resources/nfs_access_point#anonuid NfsAccessPoint#anonuid}.</summary>
        [JsiiProperty(name: "anonuid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Anonuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.94.0/docs/resources/nfs_access_point#identity_enforcement_enabled NfsAccessPoint#identity_enforcement_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "identityEnforcementEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdentityEnforcementEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.94.0/docs/resources/nfs_access_point#protocols NfsAccessPoint#protocols}.</summary>
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Protocols
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.94.0/docs/resources/nfs_access_point#squash_config NfsAccessPoint#squash_config}.</summary>
        [JsiiProperty(name: "squashConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SquashConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INfsAccessPointAccessPolicy), fullyQualifiedName: "digitalocean.nfsAccessPoint.NfsAccessPointAccessPolicy")]
        internal sealed class _Proxy : DeputyBase, digitalocean.NfsAccessPoint.INfsAccessPointAccessPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.94.0/docs/resources/nfs_access_point#anongid NfsAccessPoint#anongid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "anongid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Anongid
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.94.0/docs/resources/nfs_access_point#anonuid NfsAccessPoint#anonuid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "anonuid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Anonuid
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.94.0/docs/resources/nfs_access_point#identity_enforcement_enabled NfsAccessPoint#identity_enforcement_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityEnforcementEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IdentityEnforcementEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.94.0/docs/resources/nfs_access_point#protocols NfsAccessPoint#protocols}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Protocols
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.94.0/docs/resources/nfs_access_point#squash_config NfsAccessPoint#squash_config}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "squashConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SquashConfig
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
