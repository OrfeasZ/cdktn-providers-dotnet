using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingPersonalizationDesign
{
    [JsiiInterface(nativeType: typeof(IIssuingPersonalizationDesignConfig), fullyQualifiedName: "stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignConfig")]
    public interface IIssuingPersonalizationDesignConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The physical bundle object belonging to this personalization design.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#physical_bundle IssuingPersonalizationDesign#physical_bundle}
        /// </remarks>
        [JsiiProperty(name: "physicalBundle", typeJson: "{\"primitive\":\"string\"}")]
        string PhysicalBundle
        {
            get;
        }

        /// <summary>The file for the card logo to use with physical bundles that support card logos.</summary>
        /// <remarks>
        /// Must have a <c>purpose</c> value of <c>issuing_logo</c>. Image must be in PNG format with dimensions of 1000px by 200px. It must be a binary (black and white) image containing a black logo on a white background. We don't accept grayscale.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#card_logo IssuingPersonalizationDesign#card_logo}
        /// </remarks>
        [JsiiProperty(name: "cardLogo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CardLogo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Hash containing carrier text, for use with physical bundles that support carrier text.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#carrier_text IssuingPersonalizationDesign#carrier_text}
        /// </remarks>
        [JsiiProperty(name: "carrierText", typeJson: "{\"fqn\":\"stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignCarrierText\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignCarrierText? CarrierText
        {
            get
            {
                return null;
            }
        }

        /// <summary>A lookup key used to retrieve personalization designs dynamically from a static string.</summary>
        /// <remarks>
        /// This may be up to 200 characters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#lookup_key IssuingPersonalizationDesign#lookup_key}
        /// </remarks>
        [JsiiProperty(name: "lookupKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LookupKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#metadata IssuingPersonalizationDesign#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Friendly display name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#name IssuingPersonalizationDesign#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#preferences IssuingPersonalizationDesign#preferences}.</summary>
        [JsiiProperty(name: "preferences", typeJson: "{\"fqn\":\"stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignPreferences\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignPreferences? Preferences
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set to true, will atomically remove the lookup key from the existing personalization design, and assign it to this personalization design.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#transfer_lookup_key IssuingPersonalizationDesign#transfer_lookup_key}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "transferLookupKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TransferLookupKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingPersonalizationDesignConfig), fullyQualifiedName: "stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The physical bundle object belonging to this personalization design.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#physical_bundle IssuingPersonalizationDesign#physical_bundle}
            /// </remarks>
            [JsiiProperty(name: "physicalBundle", typeJson: "{\"primitive\":\"string\"}")]
            public string PhysicalBundle
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The file for the card logo to use with physical bundles that support card logos.</summary>
            /// <remarks>
            /// Must have a <c>purpose</c> value of <c>issuing_logo</c>. Image must be in PNG format with dimensions of 1000px by 200px. It must be a binary (black and white) image containing a black logo on a white background. We don't accept grayscale.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#card_logo IssuingPersonalizationDesign#card_logo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cardLogo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CardLogo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Hash containing carrier text, for use with physical bundles that support carrier text.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#carrier_text IssuingPersonalizationDesign#carrier_text}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "carrierText", typeJson: "{\"fqn\":\"stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignCarrierText\"}", isOptional: true)]
            public stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignCarrierText? CarrierText
            {
                get => GetInstanceProperty<stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignCarrierText?>();
            }

            /// <summary>A lookup key used to retrieve personalization designs dynamically from a static string.</summary>
            /// <remarks>
            /// This may be up to 200 characters.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#lookup_key IssuingPersonalizationDesign#lookup_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lookupKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LookupKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#metadata IssuingPersonalizationDesign#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Friendly display name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#name IssuingPersonalizationDesign#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#preferences IssuingPersonalizationDesign#preferences}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferences", typeJson: "{\"fqn\":\"stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignPreferences\"}", isOptional: true)]
            public stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignPreferences? Preferences
            {
                get => GetInstanceProperty<stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignPreferences?>();
            }

            /// <summary>If set to true, will atomically remove the lookup key from the existing personalization design, and assign it to this personalization design.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#transfer_lookup_key IssuingPersonalizationDesign#transfer_lookup_key}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transferLookupKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? TransferLookupKey
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
