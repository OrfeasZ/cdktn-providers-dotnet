using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.KeyManagerKeyMaterial
{
    [JsiiInterface(nativeType: typeof(IKeyManagerKeyMaterialConfig), fullyQualifiedName: "scaleway.keyManagerKeyMaterial.KeyManagerKeyMaterialConfig")]
    public interface IKeyManagerKeyMaterialConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>ID of the key to import key material into.</summary>
        /// <remarks>
        /// The key's origin must be external (UUID format). Can be a plain UUID or a regional ID.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#key_id KeyManagerKeyMaterial#key_id}
        /// </remarks>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyId
        {
            get;
        }

        /// <summary>The key material to import.</summary>
        /// <remarks>
        /// The key material is a random sequence of bytes used to derive a cryptographic key. Can be provided as raw bytes or a base64-encoded string (the provider will automatically normalize the input).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#key_material KeyManagerKeyMaterial#key_material}
        /// </remarks>
        [JsiiProperty(name: "keyMaterial", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyMaterial
        {
            get
            {
                return null;
            }
        }

        /// <summary>The key material to import in write-only mode.</summary>
        /// <remarks>
        /// The key material is a random sequence of bytes used to derive a cryptographic key. Can be provided as raw bytes or a base64-encoded string (the provider will automatically normalize the input). The key material will not be stored in the Terraform state.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#key_material_wo KeyManagerKeyMaterial#key_material_wo}
        /// </remarks>
        [JsiiProperty(name: "keyMaterialWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyMaterialWo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Version number to track changes to the write-only key material.</summary>
        /// <remarks>
        /// Increment this value to trigger resource recreation. Required when using 'key_material_wo'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#key_material_wo_version KeyManagerKeyMaterial#key_material_wo_version}
        /// </remarks>
        [JsiiProperty(name: "keyMaterialWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? KeyMaterialWoVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region of the key.</summary>
        /// <remarks>
        /// If not set, the region is derived from the key_id when possible or from the provider configuration.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#region KeyManagerKeyMaterial#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Optional salt for key derivation.</summary>
        /// <remarks>
        /// A salt is random data added to key material to ensure unique derived keys, even if the input is similar. It helps strengthen security when the key material has low randomness (low entropy). Can be provided as raw bytes or a base64-encoded string (the provider will automatically normalize the input).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#salt KeyManagerKeyMaterial#salt}
        /// </remarks>
        [JsiiProperty(name: "salt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Salt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Optional salt for key derivation in write-only mode.</summary>
        /// <remarks>
        /// A salt is random data added to key material to ensure unique derived keys. Can be provided as raw bytes or a base64-encoded string (the provider will automatically normalize the input). The salt will not be stored in the Terraform state.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#salt_wo KeyManagerKeyMaterial#salt_wo}
        /// </remarks>
        [JsiiProperty(name: "saltWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SaltWo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Version number to track changes to the write-only salt.</summary>
        /// <remarks>
        /// Increment this value to recreate the resource with new salt. Required when using 'salt_wo'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#salt_wo_version KeyManagerKeyMaterial#salt_wo_version}
        /// </remarks>
        [JsiiProperty(name: "saltWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SaltWoVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyManagerKeyMaterialConfig), fullyQualifiedName: "scaleway.keyManagerKeyMaterial.KeyManagerKeyMaterialConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.KeyManagerKeyMaterial.IKeyManagerKeyMaterialConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the key to import key material into.</summary>
            /// <remarks>
            /// The key's origin must be external (UUID format). Can be a plain UUID or a regional ID.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#key_id KeyManagerKeyMaterial#key_id}
            /// </remarks>
            [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The key material to import.</summary>
            /// <remarks>
            /// The key material is a random sequence of bytes used to derive a cryptographic key. Can be provided as raw bytes or a base64-encoded string (the provider will automatically normalize the input).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#key_material KeyManagerKeyMaterial#key_material}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyMaterial", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyMaterial
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The key material to import in write-only mode.</summary>
            /// <remarks>
            /// The key material is a random sequence of bytes used to derive a cryptographic key. Can be provided as raw bytes or a base64-encoded string (the provider will automatically normalize the input). The key material will not be stored in the Terraform state.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#key_material_wo KeyManagerKeyMaterial#key_material_wo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyMaterialWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyMaterialWo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Version number to track changes to the write-only key material.</summary>
            /// <remarks>
            /// Increment this value to trigger resource recreation. Required when using 'key_material_wo'.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#key_material_wo_version KeyManagerKeyMaterial#key_material_wo_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyMaterialWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? KeyMaterialWoVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Region of the key.</summary>
            /// <remarks>
            /// If not set, the region is derived from the key_id when possible or from the provider configuration.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#region KeyManagerKeyMaterial#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Optional salt for key derivation.</summary>
            /// <remarks>
            /// A salt is random data added to key material to ensure unique derived keys, even if the input is similar. It helps strengthen security when the key material has low randomness (low entropy). Can be provided as raw bytes or a base64-encoded string (the provider will automatically normalize the input).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#salt KeyManagerKeyMaterial#salt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "salt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Salt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Optional salt for key derivation in write-only mode.</summary>
            /// <remarks>
            /// A salt is random data added to key material to ensure unique derived keys. Can be provided as raw bytes or a base64-encoded string (the provider will automatically normalize the input). The salt will not be stored in the Terraform state.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#salt_wo KeyManagerKeyMaterial#salt_wo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "saltWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SaltWo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Version number to track changes to the write-only salt.</summary>
            /// <remarks>
            /// Increment this value to recreate the resource with new salt. Required when using 'salt_wo'.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/key_manager_key_material#salt_wo_version KeyManagerKeyMaterial#salt_wo_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "saltWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SaltWoVersion
            {
                get => GetInstanceProperty<double?>();
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
