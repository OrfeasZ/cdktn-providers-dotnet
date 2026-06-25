using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiClass(nativeType: typeof(oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsOutputReference), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DistributedDatabaseDistributedDatabaseShardDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DistributedDatabaseDistributedDatabaseShardDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DistributedDatabaseDistributedDatabaseShardDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DistributedDatabaseDistributedDatabaseShardDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDbStorageVaultDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetails\"}}]")]
        public virtual void PutDbStorageVaultDetails(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetails)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails" />)[]</param>
        [JsiiMethod(name: "putPeerDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPeerDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVmClusterDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetails\"}}]")]
        public virtual void PutVmClusterDetails(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAvailabilityDomain")]
        public virtual void ResetAvailabilityDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbStorageVaultDetails")]
        public virtual void ResetDbStorageVaultDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyId")]
        public virtual void ResetKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyVersionId")]
        public virtual void ResetKmsKeyVersionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPeerDetails")]
        public virtual void ResetPeerDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPeerVmClusterIds")]
        public virtual void ResetPeerVmClusterIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShardSpace")]
        public virtual void ResetShardSpace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVaultId")]
        public virtual void ResetVaultId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmClusterDetails")]
        public virtual void ResetVmClusterDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmClusterId")]
        public virtual void ResetVmClusterId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "containerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbHomeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbHomeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbStorageVaultDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetailsOutputReference\"}")]
        public virtual oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetailsOutputReference DbStorageVaultDetails
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsMetadataList\"}")]
        public virtual oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsMetadataList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsList\"}")]
        public virtual oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsList PeerDetails
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsList>()!;
        }

        [JsiiProperty(name: "shardGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShardGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportingResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SupportingResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmClusterDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetailsOutputReference\"}")]
        public virtual oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetailsOutputReference VmClusterDetails
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbStorageVaultDetailsInput", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetails\"}", isOptional: true)]
        public virtual oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetails? DbStorageVaultDetailsInput
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyVersionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyVersionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "peerDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PeerDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerVmClusterIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PeerVmClusterIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shardSpaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShardSpaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vaultIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VaultIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmClusterDetailsInput", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetails\"}", isOptional: true)]
        public virtual oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetails? VmClusterDetailsInput
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VmClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyVersionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerVmClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PeerVmClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shardSpace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShardSpace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetails\"}]}}", isOptional: true)]
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
                        case oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetails cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetails).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
