using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.KeyManagerKeyMaterial
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.keyManagerKeyMaterial.KeyManagerKeyMaterialConfig")]
    public class KeyManagerKeyMaterialConfig : scaleway.KeyManagerKeyMaterial.IKeyManagerKeyMaterialConfig
    {
        /// <summary>ID of the key to import key material into.</summary>
        /// <remarks>
        /// The key's origin must be external (UUID format). Can be a plain UUID or a regional ID.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/key_manager_key_material#key_id KeyManagerKeyMaterial#key_id}
        /// </remarks>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyId
        {
            get;
            set;
        }

        /// <summary>The key material to import.</summary>
        /// <remarks>
        /// The key material is a random sequence of bytes used to derive a cryptographic key. Can be provided as raw bytes or a base64-encoded string (the provider will automatically normalize the input).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/key_manager_key_material#key_material KeyManagerKeyMaterial#key_material}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyMaterial", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyMaterial
        {
            get;
            set;
        }

        /// <summary>The key material to import in write-only mode.</summary>
        /// <remarks>
        /// The key material is a random sequence of bytes used to derive a cryptographic key. Can be provided as raw bytes or a base64-encoded string (the provider will automatically normalize the input). The key material will not be stored in the Terraform state.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/key_manager_key_material#key_material_wo KeyManagerKeyMaterial#key_material_wo}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyMaterialWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyMaterialWo
        {
            get;
            set;
        }

        /// <summary>Version number to track changes to the write-only key material.</summary>
        /// <remarks>
        /// Increment this value to trigger resource recreation. Required when using 'key_material_wo'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/key_manager_key_material#key_material_wo_version KeyManagerKeyMaterial#key_material_wo_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyMaterialWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? KeyMaterialWoVersion
        {
            get;
            set;
        }

        /// <summary>Region of the key.</summary>
        /// <remarks>
        /// If not set, the region is derived from the key_id when possible or from the provider configuration.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/key_manager_key_material#region KeyManagerKeyMaterial#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Optional salt for key derivation.</summary>
        /// <remarks>
        /// A salt is random data added to key material to ensure unique derived keys, even if the input is similar. It helps strengthen security when the key material has low randomness (low entropy). Can be provided as raw bytes or a base64-encoded string (the provider will automatically normalize the input).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/key_manager_key_material#salt KeyManagerKeyMaterial#salt}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "salt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Salt
        {
            get;
            set;
        }

        /// <summary>Optional salt for key derivation in write-only mode.</summary>
        /// <remarks>
        /// A salt is random data added to key material to ensure unique derived keys. Can be provided as raw bytes or a base64-encoded string (the provider will automatically normalize the input). The salt will not be stored in the Terraform state.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/key_manager_key_material#salt_wo KeyManagerKeyMaterial#salt_wo}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "saltWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SaltWo
        {
            get;
            set;
        }

        /// <summary>Version number to track changes to the write-only salt.</summary>
        /// <remarks>
        /// Increment this value to recreate the resource with new salt. Required when using 'salt_wo'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/key_manager_key_material#salt_wo_version KeyManagerKeyMaterial#salt_wo_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "saltWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SaltWoVersion
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
