using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeGroupOracle
{
    [JsiiClass(nativeType: typeof(azurerm.NetappVolumeGroupOracle.NetappVolumeGroupOracleVolumeOutputReference), fullyQualifiedName: "azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class NetappVolumeGroupOracleVolumeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public NetappVolumeGroupOracleVolumeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappVolumeGroupOracleVolumeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappVolumeGroupOracleVolumeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataProtectionReplication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionReplication\"}}]")]
        public virtual void PutDataProtectionReplication(azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionReplication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionReplication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataProtectionSnapshotPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy\"}}]")]
        public virtual void PutDataProtectionSnapshotPolicy(azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeExportPolicyRule" />)[]</param>
        [JsiiMethod(name: "putExportPolicyRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeExportPolicyRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExportPolicyRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeExportPolicyRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeExportPolicyRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeExportPolicyRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDataProtectionReplication")]
        public virtual void ResetDataProtectionReplication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataProtectionSnapshotPolicy")]
        public virtual void ResetDataProtectionSnapshotPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionKeySource")]
        public virtual void ResetEncryptionKeySource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyVaultPrivateEndpointId")]
        public virtual void ResetKeyVaultPrivateEndpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkFeatures")]
        public virtual void ResetNetworkFeatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProximityPlacementGroupId")]
        public virtual void ResetProximityPlacementGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZone")]
        public virtual void ResetZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dataProtectionReplication", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionReplicationOutputReference\"}")]
        public virtual azurerm.NetappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionReplicationOutputReference DataProtectionReplication
        {
            get => GetInstanceProperty<azurerm.NetappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionReplicationOutputReference>()!;
        }

        [JsiiProperty(name: "dataProtectionSnapshotPolicy", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicyOutputReference\"}")]
        public virtual azurerm.NetappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicyOutputReference DataProtectionSnapshotPolicy
        {
            get => GetInstanceProperty<azurerm.NetappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "exportPolicyRule", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeExportPolicyRuleList\"}")]
        public virtual azurerm.NetappVolumeGroupOracle.NetappVolumeGroupOracleVolumeExportPolicyRuleList ExportPolicyRule
        {
            get => GetInstanceProperty<azurerm.NetappVolumeGroupOracle.NetappVolumeGroupOracleVolumeExportPolicyRuleList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mountIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MountIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityPoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityPoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataProtectionReplicationInput", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionReplication\"}", isOptional: true)]
        public virtual azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionReplication? DataProtectionReplicationInput
        {
            get => GetInstanceProperty<azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionReplication?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataProtectionSnapshotPolicyInput", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy\"}", isOptional: true)]
        public virtual azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy? DataProtectionSnapshotPolicyInput
        {
            get => GetInstanceProperty<azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeySourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EncryptionKeySourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeExportPolicyRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exportPolicyRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeExportPolicyRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExportPolicyRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultPrivateEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyVaultPrivateEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkFeaturesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkFeaturesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ProtocolsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "proximityPlacementGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProximityPlacementGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityStyleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityStyleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotDirectoryVisibleInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SnapshotDirectoryVisibleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageQuotaInGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StorageQuotaInGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "throughputInMibpsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThroughputInMibpsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumePathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumePathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeSpecNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumeSpecNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "capacityPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityPoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encryptionKeySource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionKeySource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyVaultPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyVaultPrivateEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkFeatures", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkFeatures
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Protocols
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "proximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProximityPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityStyle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityStyle
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "snapshotDirectoryVisible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SnapshotDirectoryVisible
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "storageQuotaInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageQuotaInGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "throughputInMibps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThroughputInMibps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumePath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeSpecName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeSpecName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolume" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolume\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolume cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolume).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
